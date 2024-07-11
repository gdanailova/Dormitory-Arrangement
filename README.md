### Управление на общежитие - Задание 2
# Конзолно приложение за управление на студентско общежитие

## Какъв проблем решава програмата: Помага на потребителя да получава, въвежда, премахва, търси и списва стаи и студенти в общежитието. Приложението включва управление на резервации и настаняване на студенти.

## По какъв начин се решават проблемите в програмата (алгоритми, технологии, библиотеки)
### Итерация (Iteration)
Итерацията чрез цикли foreach е използвана за преминаване през списъци с стаи и студенти. Това е базов механизъм за работа с колекции от данни.

#### Примери:

* Цикъл foreach за преминаване през списъка с стаи в метода ListAllRooms.
  
  ![image](https://github.com/gdanailova/Dormitory-Arrangement/assets/174993189/82f1ec7e-26d7-4771-b231-959a56ad5509)
* Цикъл foreach за преминаване през списъка с стаи в метода GenerateReport.

  ![image](https://github.com/gdanailova/Dormitory-Arrangement/assets/174993189/43b71e4d-d757-41a4-bea1-2964b1b75995)

  
### Използване на колекции (Collections)
Колекциите като List<T> са използвани за съхранение и управление на списъци със стаи и студенти. List<T> е динамична структура от данни, която позволява добавяне, премахване и търсене на елементи.

#### Примери:

* Списък със стаи (List<Room> rooms) в класа Dormitory.
* Списък със студенти (List<Student> students) в класа Dormitory.

  ![image](https://github.com/gdanailova/Dormitory-Arrangement/assets/174993189/f56b57ee-5898-4045-ae9f-941de0ef1622)

  
### Обектно-ориентирано програмиране (Object-Oriented Programming)
Обектно-ориентираните принципи са използвани за организиране на кода. Класовете Dormitory, Room и Student капсулират съответните данни и методи, които оперират с тези данни.

#### Примери:

* Класът Dormitory управлява логиката за общежитието, включително добавяне и премахване на стаи, регистриране на студенти и разпределяне на стаи.
* Класът Room капсулира данните и логиката, свързани с стаите.
* Класът Student капсулира данните и логиката, свързани със студентите.
* Класът Program обединява останалите класове и позволява на потребителя да въведе данните си, необходими за изпълнение на действията в класовете и извеждане на желания от него резултат

  ![image](https://github.com/gdanailova/Dormitory-Arrangement/assets/174993189/9c04d9b7-1167-42be-9a70-f0a4a4e17abe)


## Използвани технологии и библиотеки
* C#: Програмният език, използван за разработка на приложението.
* .NET: Рамката за изграждане и изпълнение на приложението.
* System.Collections.Generic: За използване на колекции като List<T>.
* System: За основни системни функционалности.
* System.Linq: За удобни операции с колекции.

### Чрез тази таблицата показваме примерни данни за студентите, стаите и техните състояния, които ще съхранява и изобразява тази програма
## Примерни данни за общежитието

| Студент ID | Име на студент | Номер на стая |
|------------|----------------|---------------|
| S12345     | Иван Иванов    | R101          |
| S23456     | Мария Петрова  | R102          |
| S34567     | Георги Георгиев| R103          |
| S45678     | Анна Димитрова | R104          |

## Примерни данни за стаите

| Номер на стая | Етаж | Капацитет | Заети легла | Наличност |
|---------------|------|-----------|-------------|-----------|
| R101          | 1    | 2         | 1           | Да        |
| R102          | 1    | 2         | 1           | Да        |
| R103          | 2    | 2         | 1           | Да        |
| R104          | 2    | 2         | 1           | Да        |

## Примерна операция

| Операция                   | Входни данни            | Изход/Резултат                   |
|----------------------------|-------------------------|----------------------------------|
| Регистрация на студент     | Иван Иванов, S12345     | Студентът е регистриран успешно |
| Добавяне на стая           | R101, 1, 2              | Стаята е добавена успешно       |
| Настаняване на студент     | S12345, R101            | Студентът е настанен успешно    |
| Търсене на стая по номер   | R101                    | Стая: R101, Етаж: 1, Капацитет: 2, Заети легла: 1, Наличност: Да |
| Освобождаване на стая      | S12345                  | Студентът е освободен успешно   |
| Премахване на стая         | R101                    | Стаята е премахната успешно     |
  
### [Source Code](https://github.com/gdanailova/Dormitory-Arrangement.git)
