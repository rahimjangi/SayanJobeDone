using AutoMapper;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Utilities;

public class ExpressionConverter : ITypeConverter<Expression<Func<CountryDto, bool>>, Expression<Func<Country, bool>>>
{
    public Expression<Func<Country, bool>> Convert(Expression<Func<CountryDto, bool>> source, Expression<Func<Country, bool>> destination, ResolutionContext context)
    {
        var parameter = Expression.Parameter(typeof(Country), source.Parameters[0].Name);

        var body = new ReplaceExpressionVisitor(source.Parameters[0], parameter).Visit(source.Body);

        return Expression.Lambda<Func<Country, bool>>(body, parameter);
    }

    private class ReplaceExpressionVisitor : ExpressionVisitor
    {
        private readonly Expression _source;
        private readonly Expression _destination;

        public ReplaceExpressionVisitor(Expression source, Expression destination)
        {
            _source = source;
            _destination = destination;
        }

        public override Expression Visit(Expression node)
        {
            return node == _source ? _destination : base.Visit(node);
        }
    }
}


