using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DetectFace.Api
{
    public static class api
    {
        #region Các hàm gọi api
        public static async Task<Boolean> Train()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost:5000/train");
            return (int) response.StatusCode == 200;
        }

        public static async Task<Boolean> AddImageTrain(string people, byte[] _image, string filename)
        {
            HttpClient client = new HttpClient();

            MultipartFormDataContent form = new MultipartFormDataContent();

            var stream = new ByteArrayContent(_image);
            stream.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
            form.Add(stream, "image", filename);

            var str = new StringContent(people);
            form.Add(str, "people");

            var response = await client.PostAsync("http://127.0.0.1:5000/addImageTrain", form);
            return (int) response.StatusCode == 200;
        }

        public static async Task<String> Detect(byte[] _image)
        {
            HttpClient client = new HttpClient();

            MultipartFormDataContent form = new MultipartFormDataContent();

            var stream = new ByteArrayContent(_image);
            stream.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
            form.Add(stream, "file", "image.jpg");


            var response = await client.PostAsync("http://127.0.0.1:5000/detect", form);
            var ans = await response.Content.ReadAsStringAsync();
            return ans;
        }

        public static async Task<Image> getResultImage()
        {
            HttpClient client = new HttpClient();
            byte[] result = await client.GetByteArrayAsync("http://127.0.0.1:5000/imageResult");
            return byteArrayToImage(result);
        }
        #endregion

        #region Hàm hỗ trợ
        private static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

    }
}
