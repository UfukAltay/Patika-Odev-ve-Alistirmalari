# Insertion Sort Projesi


# Question 1

[22,27,16,2,18,6] -> Insertion Sort

22 - 27, 16, 2, 18, 6 

1 - 22, 27 - 16, 2, 18, 6 --> Birinci aşamada yanındaki ile kontrol ediyor ve bir değişiklik yapmıyor
2 - 16, 22, 27 - 2, 18, 6 --> İkinci aşamada ise bir sonraki sayıyı kontrol ediyor ve 16 sayısını en başa yazıyor.
3 - 2, 16, 22, 27 - 18, 6 --> Üçüncü aşamada bir sonraki sayıyı kontrol ediyor ve 2 yi başa yazıyor.
4 - 2, 16, 18, 22, 27 - 6 --> Dördüncü aşamada ise yine bir sonraki sayıyı kontrol ediyor ve 18 i 16 nın yanına yazıyor.
5 - 2, 6, 16, 18, 22, 27  --> Son aşamada ise sıralanmış hali.


# Question 2

Big-O gösterimini yazınız.

O(n^2)


# Question 3

Time Complexity: 
  Average case: Aradığımız sayının ortada olması,
  Worst case: Aradığımız sayının sonda olması,
  Best case: Aradığımız sayının dizinin en başında olması.

Average case -> Worst ve Best olmayan durumların tamamıdır. O(n^2)
Best case -> En iyi durum olma, yani dizimizin küçükten büyüğe sıralı olması durumudur. O(n)
Worst case -> En kötü durum olma, yani dizimizin büyükten küçüğe sıralı olması durumudur. O(n^2)



# Question 4

Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

Average case



[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

1 - 3,7,5,8,2,9,4,15,6
2 - 3,5,7,8,2,9,4,15,6
3 - 3,5,7,8,2,9,4,15,6
4 - 2,3,5,7,8,9,4,15,6
