Public Class account

    Private _internal_id As String = String.Empty
    Private _uid As String = String.Empty
    Private _name As String = String.Empty
    Private _nameKana As String = String.Empty
    Private _organizationName As String = String.Empty
    Private _divisionName As String = String.Empty
    Private _email As String = String.Empty
    Private _invalid As Boolean = False
    Private _createAt As Date
    Private _modifyAt As Date

    Public Property InternalID As String
        Get
            Return Me._internal_id
        End Get
        Set(value As String)
            Me._internal_id = value
        End Set
    End Property

    Public Property UID As String
        Get
            Return Me._uid
        End Get
        Set(value As String)
            Me._uid = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property

    Public Property NameKana As String
        Get
            Return Me._nameKana
        End Get
        Set(value As String)
            Me._nameKana = value
        End Set
    End Property

    Public Property OrganizatinName As String
        Get
            Return Me._organizationName
        End Get
        Set(value As String)
            Me._organizationName = value
        End Set
    End Property




    Public Overloads Overrides Function Equals(obj As [Object]) As Boolean
        If obj Is Nothing Or Not Me.GetType() Is obj.GetType() Then
            Return False
        End If
        Dim r As account = CType(obj, account)
        ' Use Equals to compare instance variables.
        Return Me._internal_id.Equals(r._internal_id) _
            And Me._uid.Equals(r._uid) _
            And Me._name.Equals(r._name) _
            And Me._nameKana.Equals(r._nameKana) _
            And Me._organizationName.Equals(r._organizationName) _
            And Me._divisionName.Equals(r._divisionName) _
            And Me._email.Equals(r._email) _
            And Me._invalid.Equals(r._invalid) _
            And Me._createAt.Equals(r._createAt)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Me._internal_id.GetHashCode _
            ^ Me._uid.GetHashCode _
            ^ Me._name.GetHashCode _
            ^ Me._nameKana.GetHashCode _
            ^ Me._organizationName.GetHashCode _
            ^ Me._divisionName.GetHashCode _
            ^ Me._email.GetHashCode _
            ^ Me._invalid.GetHashCode _
            ^ Me._createAt.GetHashCode
    End Function


End Class
