using System;
using System.Runtime.CompilerServices;

// 1. 익명 타입 생성
{
    var p = new { Name = "김철수", Grade = 3, Score = 95.5 };

    Console.WriteLine($"이름 : {p.Name}");
    Console.WriteLine($"학년 : {p.Grade}");
    Console.WriteLine($"점수 : {p.Score}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 명시적 이름 지정
{
    string name = "이영희";
    int age = 28;

    var p = new { Name = name, Age = age };

    Console.WriteLine($"person1 : {p.Name}, {p.Age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 변수명으로 자동 추론
{
    string name = "이영희";
    int age = 28;

    var p = new { name, age };

    Console.WriteLine($"person1 : {p.name}, {p.age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 표현식에서 속성 이름 추론
{
    string str = "Hello";

    var p = new { str };
    Console.WriteLine($"텍스트 : {p.str}");
    Console.WriteLine($"길이 : {p.str.Length}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 복합 속성 일므 추론 예제
{
    int id = 100;
    int price = 25000;
    string name = "마우스";

    var product = new { id, name, price, formattedPrice = $"{price:N0}"};
    Console.WriteLine($"ID : {product.id}");
    Console.WriteLine($"상품명 : {product.name}");
    Console.WriteLine($"가격 : {product.price}");
    Console.WriteLine($"포맷된 가격 : {product.formattedPrice}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 타입 동일성
{
    var p1 = new { x = 30, y = 40 };
    var p2 = p1;

    Console.WriteLine($"같은 타입 : {p1.GetType() == p2.GetType()}");
    Console.WriteLine($"Point1 : ({p1.x}, {p1.y})");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 값 동등성
{
    var p1 = new { x = 30, y = 40 };
    var p2 = new { x = 30, y = 40 };
    var p3 = p1;

    Console.WriteLine($"a.Equals(b) : {p1.Equals(p2)}");
    Console.WriteLine($"a.Equals(c) : {p1.Equals(p3)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 참조 동등성
{
    var p1 = new { x = 30, y = 40 };
    var p2 = new { x = 30, y = 40 };
    var p3 = p1;

    Console.WriteLine($"a == b : {p1 == p2}");
    Console.WriteLine($"a == c : {p1 == p3}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 익명 타입 배열
{  
    var students = new[] {
        new { name = "김철수", score = 85 },
        new { name = "이영희", score = 92 },
        new { name = "박민수", score = 78 },
    };

    Console.WriteLine($"=== 학생 점수 목록 ===");
    foreach (var student in students) {
        Console.WriteLine($"{student.name} : {student.score}점");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 배열 요소 접근
{
    var p = new[] {
        new { name = "키보드", quantity = 3, price = 125000 }
    };

    Console.WriteLine($"첫 번째 상품 : {p[0].name}");
    Console.WriteLine($"상품 개수 : {p[0].quantity}");
    Console.WriteLine($"총 가격 : {p[0].price * p[0].quantity:N0}원");
    Console.WriteLine();
    Console.WriteLine();
}


// 10. 구조 기반 타입 동일성
{
    var p1 = new { name = "a", age = 5 };
    Console.WriteLine($"1 - {p1.age}");

    p1 = new { name = "b", age = 10 };
    Console.WriteLine($"2 - {p1.age}");

    Console.WriteLine();
    Console.WriteLine();
}

// 11. 익명 타입 vs 튜플
{
    var p = new { name = "홍길동", age = 30 };
    var t = (name : "홍길동", age : 30);

    Console.WriteLine($"익명 타입 : {p.name}, {p.age}");
    Console.WriteLine($"튜플 : {t.name}, {t.age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. ToString() 메서드
{
    var p = new { name = "김영희", age = 25, city = "서울" };

    Console.WriteLine(p);
    Console.WriteLine(p.ToString());
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 데이터 그룹화
{      
    var employees = new[] {
        new { name = "김철수", dept = "개발팀", salary = 5000 },
        new { name = "이영희", dept = "기획팀", salary = 4500 },
        new { name = "박민수", dept = "개발팀", salary = 5500 },
    };

    Console.WriteLine($"=== 직원 정보 ===");
    foreach (var employee in employees) {
        Console.WriteLine($"{employee.name} ({employee.dept}) - {employee.salary:N0}만원");
    }

    Console.WriteLine();
    Console.WriteLine();
}

// 14. 임시 데이터 변환
{
    string[] names = new string[] { "사과", "바나나", "오렌지" };
    int[] prices = new int[] { 1000, 1500, 2000 };
    
    var fruits = new[] {
        new { Name = names[0], Price = prices[0] },
        new { Name = names[1], Price = prices[1] },
        new { Name = names[2], Price = prices[2] }
    };

    Console.WriteLine($"=== 과일 가격표 ===");
    foreach (var fruit in fruits) {
        Console.WriteLine($"{fruit.Name} : {fruit.Price:N0}원");
    }
    Console.WriteLine();
    Console.WriteLine();
}