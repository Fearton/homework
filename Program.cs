// first task

// void multiplicity(int numb) {
//     if (numb % 7 == 0 && numb % 23 == 0) {
//         System.Console.WriteLine("yes");
//     } else {
//         System.Console.WriteLine("no");
//     }
// }

// int number = Convert.ToInt32(Console.ReadLine());
// multiplicity(number);

// second task

// void coordinatePlane (double x, double y) {
//     if (x > 0 && y > 0) {
//         System.Console.WriteLine("I plane");
//     } if (x < 0 && y > 0) {
//         System.Console.WriteLine("II plane");
//     } if (x < 0 && y < 0) {
//         System.Console.WriteLine("III plane");
//     } if (x > 0 && y < 0) {
//         System.Console.WriteLine("IV plane");
//     } if (x == 0 || y == 0) {
//         System.Console.WriteLine("ERROR 404");
//     }
// }

// System.Console.WriteLine("Enter x:");
// double x = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Enter y:");
// double y = Convert.ToDouble(Console.ReadLine());

// coordinatePlane(x,y);

// third task

// void highNumber(int number) {
//     int ed = number % 10;
//     int dec = (number - ed) / 10;

//     if (number >= 10 && number <= 99) {
//         if (ed > dec) {
//             System.Console.WriteLine("highest number is: " + ed);
//         } else {
//             System.Console.WriteLine("highest number is: " + dec);
//         } 
//     } else {
//         System.Console.WriteLine("Wrong number");
//     }
// }

// System.Console.WriteLine("Enter your number:");
// int yourNumber = Convert.ToInt32(Console.ReadLine());
// highNumber(yourNumber);

//fourth task

void numberDivision(int number) {
    if (number < 1) {
        System.Console.WriteLine("Wrong number");
    } else {
        for(int i = 0; i < Convert.ToString(number).Length; i++) {
            if (i == Convert.ToString(number).Length - 1) {
                System.Console.WriteLine(Convert.ToString(number)[i]);
            } else {
                System.Console.Write(Convert.ToString(number)[i] + ",");
            }
        }
    }
}

System.Console.WriteLine("Enter your number:");
int yourNumber = Convert.ToInt32(Console.ReadLine());
numberDivision(yourNumber);