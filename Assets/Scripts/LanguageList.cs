using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageList : MonoBehaviour
{
    [HideInInspector] public  List<Question> EtoA;
    [HideInInspector] public  List<Question> RtoA;

    void Awake()
    {
        EtoA = new List<Question>
        {
            new Question("Bicycle", new List<string> { "Հեծանիվ", "Մոտո", "Անիվ","Ղեկ" }, 0),
            new Question("House", new List<string> { "Շենք", "Տուն","Բակ" ,"Տանիք"},1),
            new Question("Face", new List<string> { "Քիթ", "Ատամ", "Դեմք","Ականջ" }, 2),
            new Question("Fane", new List<string> { "Օդամղիչ", "Լրագրող", "Օդորակիչ","Երկրպագու" }, 3),
            new Question("Team", new List<string> { "Թիմ", "Կոլեկտիվ", "Կոլլեգա","Ակումբ" }, 0),
            new Question("Finger", new List<string> { "Ձեռք", "Ծունկ", "Մատ","Դաստակ" }, 2),
            new Question("Cat", new List<string> { "Վագր", "Կատու", "Լուսան","Հովազ" }, 1),
            new Question("Lion", new List<string> { "Արքա", "Շուն", "Ձի","Առյուծ" }, 3),
            new Question("Doctor", new List<string> { "Բուժքույր", "Բժիշկ", "Անասնաբույժ","Վիրաբույժ" }, 1),
            new Question("Cherry", new List<string> { "Բալ", "Կեռաս", "Ազնվամորի", "Հաղարջ" }, 0),
            new Question("Blueberry", new List<string> { "Մոշ", "Ելակ", "Հապալաս","Թուզ" }, 2),
            new Question("Bed", new List<string> { "Վատ", "Աթոռ", "Բազմոց","Մահճակալ" }, 3),
            new Question("Keyboard", new List<string> { "Կողպեկ", "Ստեղնաշար", "Տախտակ","Գրատախտակ" }, 1),
            new Question("Stone", new List<string> { "Քար", "Պատ", "Սյուն","Տուֆ" }, 0),
            new Question("Window", new List<string> { "Ապակի", "Էկրան", "Պատուհան","Ծրագիր" }, 2),
            new Question("Kitchen", new List<string> { "Խոհարար", "Ուտեստ", "Թավա","Խոհանոց" }, 3),
            new Question("Programmer", new List<string> { "Ծրագրավորող", "Համակարգիչ", "Ծրագիր","Կոդ" }, 0),
            new Question("Bus", new List<string> { "Գնացք", "Կանգառ", "Ավտոբուս","Երթուղային" }, 2),
            new Question("Work", new List<string> { "Աշխատող", "Աշխատանք", "Հանձնարարություն","Գործարան" }, 1),
            new Question("Teacher", new List<string> { "Սովորել", "Ուսուցանել", "Դպրոց","Ուսուցիչ" }, 3),
            new Question("Artist", new List<string> { "Դերասան", "Դիզայներ", "Նկարիչ","Երգիչ" }, 2)

        };
        RtoA  = new List<Question>
        {
            new Question("Город", new List<string> { "Քաղաք", "Համայնք", "Մարզ","Պետություն" }, 0),
            new Question("Стол", new List<string> { "Կահույք", "Աթոռ","Սեղան" ,"Դուռ"},2),
            new Question("Курица", new List<string> { "Թռչուն", "Հավ", "Աքլոր","Աղավնի" }, 1),
            new Question("Деревня", new List<string> { "Գյուղ", "Հող", "Այգի","Քաղաք" }, 0),
            new Question("Мечта", new List<string> { "Երազ", "Մտածմունք", "Միտք","Երազանք" }, 3),
            new Question("Рука", new List<string> { "Ձեռք", "Լիճ", "Գետ","Դաստակ" }, 0),
            new Question("Медведь", new List<string> { "Վագր", "Առջ", "Գայլ","Նապաստակ" }, 1),
            new Question("Нога", new List<string> { "Ծունկ", "Մատ", "Ոտք","Ուս" }, 2),
            new Question("Телевизор", new List<string> { "Էկրան", "Լար", "Համակարգիչ","Հեռուստացույց" }, 3),
            new Question("Работник", new List<string> { "Աշխատող", "Գործարան", "Ստրուկ", "Աշխատանք" }, 0),
            new Question("Телефон", new List<string> { "Խոսնակ",  "Թել","Հեռախոս","Թելել" }, 2),
            new Question("Дерево", new List<string> { "Համայնք", "Ծառ", "Փայտ","Մահճակալ" }, 1),
            new Question("Колесо", new List<string> { "Կողպեկ", "Անվադող", "Երկաթ","Ակ" }, 3),
            new Question("Школа", new List<string> { "Դպրոց", "Քոլեջ", "Համալսարան","Բուհ" }, 0),
            new Question("Музей", new List<string> { "Երգ", "Պահոց", "Թանգարան","Արվեստ" }, 2),
            new Question("Проект", new List<string> { "Պրոյեկտոր", "Նախագիծ", "Թեմա","Ծրագիր" }, 1),
            new Question("Жизнь", new List<string> { "Դժգոհ", "Մահ", "Ապրել","Կյանք" }, 3),
            new Question("Сторона", new List<string> { "Կողմ", "Նահանգներ", "Պետություն","Միակողմ" }, 0),
            new Question("Страна", new List<string> { "Միակողմ", "Պետություն", "Երկիր","Նահանգներ" }, 2),
            new Question("Общий", new List<string> { "Ընդհանրապես", "Ընդհանուր", "Բոլոր","ՄԻայն" }, 1),
            new Question("Результат", new List<string> { "Վատագույն", "Արդյունավետ", "Անարդյունք","Արդյունք" }, 3)

        };
    }

}
