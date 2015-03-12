Module Module1

    Class CompanyINFO

        'COMPANY INFORMATION'

        Public companyName As String
        Public companyOwner As String
        Public companyContactNumber As New Integer
        Public companyAddress As New Integer
        Public companyRate As New Integer

    End Class

    Dim company As New CompanyINFO
    Sub LoadInfo()









    End Sub

    Sub CreateUserInfo()

        'USER INFORMATION CREATION'

        'PAGE 2'
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green

        Console.WriteLine("No company information has been found. We'll setup a profile before we begin.")
        Console.WriteLine("")
        Console.WriteLine("Press any key to continue")

        Console.ReadKey()
        Console.Clear()

        'PAGE 3'
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.ForegroundColor = ConsoleColor.Green

        Console.WriteLine("Here you need to enter the details for your new company profile.")
        Console.WriteLine("")

        'COMPANY NAME'
        Console.Write("Company name: ")
        company.companyName = Console.ReadLine

        'COMPANY OWNERS NAME'
        Console.Write("Company ownser's Name: ")
        company.companyOwner = Console.ReadLine

        'COMPANY CONTACT NUMBER'
        Console.Write("Company contact number: ")
        company.companyContactNumber = Console.ReadLine

        'COMPANY ADDRESS'
        Console.Write("Company address: ")
        company.companyAddress = Console.ReadLine

        'COMPANY HOURLY RATE'
        Console.Write("Company hourly rate: $")
        company.companyRate = Console.ReadLine

    End Sub

    Sub Main()

        'MAIN PAGE'

        'PAGE 1'

        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green

        Console.SetCursorPosition(23, 0)
        Console.WriteLine("Welcome to Fun With Lawns v0.1")

        Console.SetCursorPosition(18, 1)
        Console.WriteLine("Your all in one lawn management system.")

        Console.SetCursorPosition(25, 3)
        Console.WriteLine("Press any key to Continue...")

        Console.ReadKey()
        Console.Clear()


        If IO.File.Exists("Company.txt") Then
            LoadInfo()

        Else
            CreateUserInfo()

        End If

        Console.ReadLine()

    End Sub

End Module


