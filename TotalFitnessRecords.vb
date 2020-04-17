Module TotalFitnessRecords
    Public Structure MemberType
        ' Creating a new record to store new members' details
        <VBFixedString(50)> Dim Email As String ' Primary Key 
        <VBFixedString(25)> Dim Name As String
        <VBFixedString(25)> Dim Surname As String
        <VBFixedString(10)> Dim Gender As String
        <VBFixedString(15)> Dim DOB As String
        <VBFixedString(15)> Dim Mobile As String
        <VBFixedString(50)> Dim Password As String
    End Structure

    Public Structure StaffType
        <VBFixedString(50)> Dim StaffID As String ' Primary Key 
        <VBFixedString(25)> Dim Name As String
        <VBFixedString(25)> Dim Surname As String
        <VBFixedString(15)> Dim Mobile As String
        <VBFixedString(50)> Dim Role As String
        <VBFixedString(50)> Dim Password As String

    End Structure

    Public Structure FacilityType
        ' creating new record to store new facility information

        <VBFixedString(10)> Dim FacilityID As String ' Primary Key 
        <VBFixedString(50)> Dim Name As String
        <VBFixedString(10)> Dim ClassNo As String
        <VBFixedString(50)> Dim StaffID As String ' Foreign key


    End Structure

    Public Structure BookingType
        <VBFixedString(10)> Dim BookingID As Integer ' Primary Key 
        <VBFixedString(50)> Dim MemberEmail As String ' Foreign Key I
        <VBFixedString(10)> Dim FacilityID As String ' Foreign Key II
        <VBFixedString(12)> Dim ParticipationID As String ' Foregn key III

    End Structure

    Public Structure ParticipationDatesType
        <VBFixedString(12)> Dim ParticipationID As String ' PrimaryKey
        <VBFixedString(10)> Dim FacilityID As String ' Foreign Key I
        <VBFixedString(14)> Dim Day As String
        <VBFixedString(10)> Dim Time As String
        <VBFixedString(10)> Dim AvailSpaces As String
    End Structure


End Module
