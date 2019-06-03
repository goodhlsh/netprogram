using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Album family = new Album(3); // 创建一个容量为 3 的相册
            // 创建 3 张照片 
            Photo first = new Photo("Jeny");
            Photo second = new Photo("Smith");
            Photo third = new Photo("Lono");
            // 向相册加载照片 
            family[0] = first;
            family[1] = second;
            family[2] = third;
            // 按索引检索 
            Photo objPhoto1 = family[2];
            Console.WriteLine(objPhoto1.Title);
            // 按名称检索 
            Photo objPhoto2 = family["Jeny"];
            Console.WriteLine(objPhoto2.Title);

            Console.ReadKey();

        }
    }
    class Photo    //定义照片类
    {
        string _title;   //照片标题
        public Photo(string title)   //构造函数
        {
            this._title = title;
        }
        public string Title   //只读属性
        {
            get
            {
                return _title;
            }
        }
    }
    class Album    //类的定义
    {
        Photo[] photos;// 该数组用于存放照片 
        public Album(int capacity)
        {
            photos = new Photo[capacity];
        }
        //带有int参数的Photo读写索引器
        public Photo this[int index]
        {
            get
            { 	// 验证索引范围
                if (index < 0 || index >= photos.Length)
                {
                    Console.WriteLine("索引无效");
                    // 使用 null 指示失败
                    return null;
                }
                // 对于有效索引，返回请求的照片
                return photos[index];
            }
            set
            {
                if (index < 0 || index >= photos.Length)
                {
                    Console.WriteLine("索引无效");
                    return;
                }
                photos[index] = value;
            }
        }
        //带有 string 参数的 Photo 只读索引器
        public Photo this[string title]
        {
            get
            {
                // 遍历数组中的所有照片 
                foreach (Photo p in photos)
                {
                    // 将照片中的标题与索引器参数进行比较 
                    if (p.Title == title)
                        return p;
                }
                Console.WriteLine("未找到");
                // 使用 null 指示失败 
                return null;
            }
        }
    }

}
