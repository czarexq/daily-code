menu = "Welcome to my coffee shop!!\n--------------Menu--------------\n1.Latte - 3.50$\n2.Americano - 3.00$\n3.Cappucino - 2.00$\n4.Buy\n5.See your list\n6.See Menu\n7.Cancel\n--------------------------------"
print(menu)
price = 0
bought_list = ""

#Note [ps just copy it and then read its quite long]: Hiii guys!! Thanks for anyone that clicked on this, well if you don't mind i will tell you a bit of my plans. Okay so basically now i will just do this quick prototype later i will do late in JS because i need to practice it too and i know Python already. Yeahhh I plan to make a website simulating a coffee shop later so stay tunned!! Love you guys and sorry for not being active for so long i just had to figure myself out ykyk im overthinking too much sometimes. I promise to post more soon gotta get back in the grind 

while True:
  
  choice = int(input("What's your choice?: "))

  if choice == 1:
    price += 3.50
    bought_list += "Latte\n"
    print("Okii sure one Latte coming right up")

  elif choice == 2:
    price += 3
    bought_list += "Americano\n"
    print("Okayyy sure one Americano for you")

  elif choice == 3:
    price += 2
    bought_list += "Cappucino\n"
    print("Sure thing, there one Cappucino for you")

  elif choice == 4:
    print(f"Your total is {price}$, thanks for shopping!")
    break

  elif choice == 5:
    print(bought_list)

  elif choice == 6:
    print(menu)

  elif choice == 7:
    price == 0
    bought_list == ""
    print("Okii, thanks for stopping by")
    break
    
  else:
      print("Awhhh wrong choice dummy")
