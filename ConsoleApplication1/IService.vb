Public Interface IService
    <OperationContract()>
    Function GetPrice(ByVal symbol As String) As Double

    <OperationContract()>
    Function GetName(ByVal symbol As String) As String
End Interface