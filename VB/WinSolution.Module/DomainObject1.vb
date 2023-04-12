Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module

    <DefaultClassOptions>
    Public Class DomainObject1
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private _person As Person

        Public Property Person As Person
            Get
                Return _person
            End Get

            Set(ByVal value As Person)
                SetPropertyValue("Person", _person, value)
            End Set
        End Property
    End Class
End Namespace
