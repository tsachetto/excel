Public Function CONTCAR(ByRef Texto As String, ByVal Caractere As String) As Integer

'Contar Caracteres:
'Função elaborada para contar a quantidade de caracteres ou uma série de caracteres dentro de uma célula.
'Retorna um resultado numérico. Funciona assim: A1 = “|oi|td|bem|”  =CONTCAR(A1;”|”) Resultado: 4

Dim tamanho, tmn, total As Variant

total = 0
tamanho = Len(Texto)
tmn = Len(Caractere)

    For i = 1 To tamanho
    
        If Mid(Texto, i, tmn) = Caractere Then
        
            total = total + 1
        
        Else: End If
    Next

CONTCAR = total

End Function
