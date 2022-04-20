# Final_Project_643450076_9
Finalproject oop <br>
### วัตถุประสงค์ของโปรแกรม
ใช้ในการบันททึกและคำนวณข้อมูลเบื้ยงต้นในการเช่า ปืนBBgun <br>
### Class Diagram
```mermaid
classDiagram
direction RL
  Form2 <|-- BBgun
  Form1 <|-- Form2
class Form1{
  login()
  clear()
  }
class Form2{
  -BBgun
  -P1
  -A1
  -Sum
  -Total
  -As1
  -As2
  -As3
  -As4
  -As5
  -K
  -B
  -T
  calculate()
  add()
  Clear()
  Close()
  SaveFile()
  }
class BBgun{
  -name
  -num
  -type
  -amount
  -price
  -date
  -accessories
  getName()
  getNum()
  getType()
  getAmount()
  getPrice()
  getDate()
  getAccessories()
}
```
## นายธนาธิป เตชะ
