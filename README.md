### ความเป็นมา 
อยากแนะนำสรรพคุณของสมุนไพรที่น่าจะมีประโยชน์สำหรับผู็ที่ต้องการศึกษามัน เพราะสมุนไพรบางชนิดบางคนอาจมองมัน
เป็นแค่พืช มองเป็นสารเสพติด มองเป็นแค่ต้นไม้ต้นหนึ่ง แต่ บางทีพืชที่คุณอาจจะมองข้ามอาจมีประโยชน์มากมากจนคุณคิดไม่ถึง
### วัตถุประสงค์
เพื่อแนะนำสรรคุณของพืชสมุนไพร
เพื่อบงบอกแหล่งที่มาของพืชสมุนไพร
เพื่อบอกข้อมูลเพื่อเพิ่มความรู้ของพืชสมุนไพรนั้นๆ
### โครงสร้างโปรแกรม
```mermaid
classDiagram
    Herb <|-- KratomLeaves
    Herb <|-- Marijuana
    Herb <|-- SpringOnion
    Form1 <-- Form2
    Form1 <-- Form3
    Form1 <-- Form4
    Form2 <-- SpringOnion
    Form3 <-- KratomLeaves
    Form4 <-- Marijuana 
    class Marijuana{
      +Marijuana()
    }
    class KratomLeaves{
        +KratomLeaves()
    }
    class SpringOnion{
        +SpringOnion()
    }
    class Herb{
        #string properties
        #string source
        #string price

        +GetProperties()
        +GetSource()
        +GetPrice()

    }
    class Form1{
        +Form1()
        -button1_Click(object sender, EventArgs e)
        +Form2 form2 
        -button3_Click(object sender, EventArgs e)
        +Form3 form3 
        -button2_Click(object sender, EventArgs e)
        + Form4 form4
    }
    class Form2{
        -Form2()
        +SpringOnion SpringOnion
        -SaveCSV_Click(object sender, EventArgs e)
        -buttonback_Click(object sender, EventArgs e)
    }   
    class Form3{
        +KratomLeaves kratom 
        - SaveCSV_Click(object sender, EventArgs e)
        -buttonback_Click(object sender, EventArgs e)
    }
    class Form4{
        +Form4()
        +Marijuana marijuana
        -SaveCSV_Click(object sender, EventArgs e)
        -buttonback_Click(object sender, EventArgs e)
    }
```
### ผู้พัฒนาโปรแกรม
นาย รัชชานนท์ ค้ำชู รหัสนักศึกษา 663450178-3

