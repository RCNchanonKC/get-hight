### �������� 
��ҡ�й���þ�س�ͧ��ع�÷���Ҩ��ջ���ª������Ѻ������ͧ����֡���ѹ ������ع�úҧ��Դ�ҧ���Ҩ�ͧ�ѹ
����ת �ͧ������ʾ�Դ �ͧ���������˹�� �� �ҧ�վת���س�Ҩ���ͧ�����Ҩ�ջ���ª���ҡ�ҡ���س�Դ���֧
### �ѵ�ػ��ʧ��
�����й���äس�ͧ�ת��ع��
���ͺ��͡���觷���Ңͧ�ת��ع��
���ͺ͡���������������������ͧ�ת��ع�ù���
### �ç���ҧ�����
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
### ���Ѳ�������
��� �Ѫ�ҹ��� ��Ӫ� ���ʹѡ�֡�� 663450178-3

