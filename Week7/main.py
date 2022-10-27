import mysql.connector

mydb = mysql.connector.connect(
    host="127.0.0.1",
    user="root",
    password="PssMySQL!123",
    database="Collections"
)

my_cursor = mydb.cursor()


def createFossil():
    types = input("Enter type of fossil: ")
    amount = int(input("How many do you have: "))
    name = input("What is the fossil name: ")
    price = float(input("how much is the fossil: "))
    size = input("What is the size: ")

    my_cursor.execute(
        f"INSERT INTO collections.fossils(type, amount, name, price, size) VALUES('{types}', '{amount}', '{name}', "
        f"'{price}', '{size}')")
    mydb.commit()


def readAllFossils():
    my_cursor.execute("SELECT * FROM collections.fossils")
    myresult = my_cursor.fetchall()

    for x in myresult:
        print(x)


def readSpecific():
    id_num = input("Enter the ID of record you want to select: ")
    my_cursor.execute("SELECT * FROM collections.fossils")
    my_result = my_cursor.fetchall()
    id_set = set()
    for x in my_result:
        id_set.add(x[0])
    if int(id_num) in id_set:
        my_cursor.execute(f"SELECT * FROM collections.fossils WHERE id = {id_num}")
        myresults = my_cursor.fetchall()

        for y in myresults:
            print('\n')
            print(y)
            print()
    else:
        print("\n******* ID isn't in the database *******\n")


def updateFossilRecord():
    ids = input("Enter the ID of record you want to change: ")
    my_cursor.execute("SELECT * FROM collections.fossils")
    my_result = my_cursor.fetchall()
    id_set = set()
    for x in my_result:
        id_set.add(x[0])
    if int(ids) in id_set:
        types = input("Enter type: ")
        amount = int(input("How many do you have: "))
        name = input("What is the fossil name: ")
        price = float(input("how much is the fossil: "))
        size = input("What is the size: ")
        my_cursor.execute(
            f"UPDATE collections.fossils SET type = '{types}', amount = {amount}, name = '{name}', price = {price}, "
            f"size = '{size}' "
            f"WHERE id = {ids};")
        mydb.commit()
    else:
        print("\n******* ID isn't in the database *******\n")
        mydb.rollback()


def deleteFossilRecord():
    ids = input("Enter the ID of record you want to delete: ")
    my_cursor.execute("SELECT * FROM collections.fossils")
    my_result = my_cursor.fetchall()
    id_set = set()
    for x in my_result:
        id_set.add(x[0])
    if int(ids) in id_set:
        my_cursor.execute(f"DELETE from collections.fossils WHERE id = {ids};")
        mydb.commit()
    else:
        print("\n******* ID isn't in the database *******\n")
        mydb.rollback()


def main():
    selection = ''
    while not selection == 'Q':
        print("""              Enter the option you want
              (C) Create a Fossil Record
              (R) Read a Fossil Record
              (U) Update a Fossil Record
              (D) Delete a Fossil Record
              (S) Select specific Record
              (Q) Quit
               """)
        selection = input('What would you like to do?').upper()

        if selection == 'C':
            createFossil()
        elif selection == 'R':
            readAllFossils()
        elif selection == 'U':
            updateFossilRecord()
        elif selection == 'D':
            deleteFossilRecord()
        elif selection == 'S':
            readSpecific()
        else:
            continue


if __name__ == '__main__':
    main()