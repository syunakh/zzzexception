# zzzexception

```
Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Microsoft.EntityFrameworkCore.Query.SqlExpressions.SqlParameterExpression' to type 'Microsoft.EntityFrameworkCore.Query.SqlExpressions.SqlConstantExpression'.
   at Microsoft.EntityFrameworkCore.Query.QuerySqlGenerator.VisitIn(InExpression inExpression)
   at Microsoft.EntityFrameworkCore.Query.SqlExpressionVisitor.VisitExtension(Expression extensionExpression)
   at System.Linq.Expressions.Expression.Accept(ExpressionVisitor visitor)
   at System.Linq.Expressions.ExpressionVisitor.Visit(Expression node)
   at Microsoft.EntityFrameworkCore.Query.QuerySqlGenerator.VisitSelect(SelectExpression selectExpression)
   at Microsoft.EntityFrameworkCore.Query.QuerySqlGenerator.GetCommand(SelectExpression selectExpression)
   at Z.EntityFramework.Plus.BatchUpdate.CreateCommand(IQueryable query, IEntityType entity, List`1 values)
   at Z.EntityFramework.Plus.BatchUpdate.Execute[T](IQueryable`1 query, Expression`1 updateFactory)
   at Z.EntityFramework.Plus.BatchUpdateExtensions.Update[T](IQueryable`1 query, Expression`1 updateFactory, Action`1 batchUpdateBuilder)
   at Z.EntityFramework.Plus.BatchUpdateExtensions.Update[T](IQueryable`1 query, Expression`1 updateFactory)
   at zzzexception.Program.Main(String[] args) in /Users/yunakh/Projects/zzzexception/Program.cs:line 19```
