using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStation
{
    //делегаты, события
    class Event
    {
        //звонок
        delegate void callingHandler(string message); //метод
        //event callingHandler Notify; // событие
        
        //входящий звонок
        delegate void incomingCallHandler(string message); //метод
        //event incomingCallHandler Notify; // событие

        //ответ
        delegate void answeringHandler(string message); //метод
        //event answeringHandler Notify; // событие       

        //начало разговора
        delegate void startOfConversationHandler(string message); //метод
        //event startOfConversationHandler Notify; // событие       

        //получение ответа
        delegate void reseivingAnswerHandler(string message); //метод
        //event reseivingAnswerHandler Notify; // событие
       
        //окончание вызова
        delegate void endingCallHandler(string message); //метод
        //event endingCallHandler Notify; // событие

        //конец разговора
        delegate void endOfConversationHandler(string message); //метод
        //event endOfConversationHandler Notify; // событие 

        //прием звонка
        delegate void receivingEndCallHandler(string message); //метод
        //event receivingEndCallHandler Notify; // событие

       
    }
}
