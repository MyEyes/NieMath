namespace Nie.Math
{

    public interface IConstVector3D<T>
    {
        T x { get; }
        T y { get; }
        T z { get; }
    }
    public interface IVector3D<T> 
    {
        T x { get; set; }
        T y { get; set; }
        T z { get; set; }
    }
}