using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace socket.Controllers
{
    public class HomeController : Controller
    {
        private Socket mainSock;

        public ActionResult Index()
        {
            try
            {
                // 소캣생성
                mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                //주소바인딩 생성
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 8080);
                // 소캣에 바인딩
                mainSock.Bind(serverEP);
                // 클라이언트 요청 건수 10개가 되면 실행하게 설정
                mainSock.Listen(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}