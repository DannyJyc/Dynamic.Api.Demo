using Dynamic.Api.Demo.Dynamic.Api.Core;
using Dynamic.Api.Demo.Dynamic.Api.Core.Attributes;

namespace Dynamic.Api.Demo.Services
{
    public class User
    {
        public string? Name { get; set; }
    }
    public class UsersService : IService
    {
        /// <summary>
        /// 新增测试
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Create(User user)
        {
            return $"创建了：{user.Name} ";
        }

        public string Delete(int id)
        {
            return $"ID：{id} 已删除";
        }

        public string Get(int id)
        {
            return $"你输入的 ID 是：{id}";
        }

        public List<User> GetAll()
        {
            return "一堆用户信息"
                .ToCharArray()
                .Select(temp => new User
                {
                    Name = temp.ToString()
                })
                .ToList();
        }

        public string Update(int id, User user)
        {
            return $" ID：{id} 的名字改成了 {user.Name}";
        }

        [NonDynamicAction]
        public string GetTest(int id)
        {
            return $"TEST你输入的 ID 是：{id}";
        }
    }
}
