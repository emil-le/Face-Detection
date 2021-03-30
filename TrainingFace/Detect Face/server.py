import os

from flask import Flask
from flask_cors import CORS
from flask import send_file, request, flash, redirect, abort

from identify_face_image import Detect
from train_main import  train
from data_preprocess import pre

app = Flask(__name__)
CORS(
    app,
    resources={r"/*": {"origins": "*"}},
    headers=['Content-Type', 'X-Requested-With', 'Authorization']
)

@app.route('/detect', methods=['POST'])
def hello():
    #lấy file request của client
    if request.method == 'POST':
        # check if the post request has the file part
        if 'file' not in request.files:
            flash('No file part')
            return redirect(request.url)
        file = request.files['file']
        # if user does not select file, browser also
        # submit a empty part without filename
        filename="input.jpg"
        file.save(os.path.join(filename))

    # nhận dạng
    ans = Detect()
    return ans

@app.route('/imageResult')
def getResult():
    filename='result.jpg'
    return send_file(filename, mimetype="image/jpeg")

trainning = 0
@app.route('/train')
def trainImages():
    global  trainning
    if (trainning == 1):
        return 'Modal is trainning'

    trainning = 1
    pre()
    train()
    trainning = 0
    return 'success'

@app.route('/addImageTrain', methods=['POST'])
def addImageTrain():
    if (not request.form['people'] or 'image' not in request.files):
        return abort(500)

    people = request.form['people']
    image = request.files['image']

    dirName = 'train_img/'+people
    if not os.path.exists(dirName):
        os.mkdir(dirName)

    file_path = dirName+"/"+image.filename
    image.save(os.path.join(file_path))

    return 'success'

if __name__ == '__main__':

    app.run()