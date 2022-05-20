using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSSTUDY3202
{
    /// <summary>
    /// 자동차 주차장 입차, 출차 시간 등을 지정하는 클래스입니다.
    /// </summary>
    class Car
    {
        /// <summary>
        /// 자동차 번호 입니다.
        /// </summary>
        int carNumber;
        /// <summary>
        /// 자동차 입차 시간
        /// </summary>
        DateTime inTime;
        /// <summary>
        /// 자동차 출차 시간
        /// </summary>
        DateTime outTime;
        
        /// <summary>
        /// 자동차 입차 시간을 지정합니다.
        /// </summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        /// <summary>
        /// 자동차 출차 시간을 지정합닏.
        /// </summary>
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="foo"></param>
        /// <returns>foo * 10</returns>
        public int some(int foo)
        {
            return foo * 10;
        }
    }
}
