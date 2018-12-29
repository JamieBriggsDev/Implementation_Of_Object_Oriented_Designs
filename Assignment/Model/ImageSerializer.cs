using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
    public class ImageSerializer
    {
        public static ImageSerializer m_instance;
        public ImageSerializer()
        {

        }

        public static ImageSerializer Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new ImageSerializer();
                }
                return m_instance;
            }
        }

        public byte[] SerializeImage(Image _image)
        {
            byte[] array = null;
            using (MemoryStream myStream = new MemoryStream())
            {
                _image.Save(myStream, _image.RawFormat);
                array = myStream.ToArray();
                return array;

            }
        }

        public Image DeserializeImage(byte[] _image)
        {
            Image image = null;
            using (MemoryStream myStream = new MemoryStream(_image))
            {
                image = Image.FromStream(myStream);

                return image;
            }
        }

    }
}
