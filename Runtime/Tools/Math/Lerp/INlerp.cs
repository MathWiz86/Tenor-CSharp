/**************************************************************************************************/
/*!
\file   INlerp.cs
\author Craig Williams
\par    Last Updated
        2021-05-31
\par    Copyright
        Copyright � 2021 Craig Joseph Williams, All Rights Reserved.

\brief
  A file for an interface used for marking a type as able to normalized-linearly interpolate.

\par Bug List

\par References
*/
/**************************************************************************************************/

namespace CodeParadox.Tenor.Math
{
  /************************************************************************************************/
  /// <summary>
  /// A useful <see langword="interface"/> for normalized-linearly interpolating a value.
  /// Use in conjunction with the <see cref="Tools.Lerp"/> tools.
  /// </summary>
  /// <typeparam name="T">The type being lerped. This is the inheriting type.</typeparam>
  public interface INlerp<T> where T : INlerp<T>
  {
    /// <summary>
    /// A function to normalized-linearly between two <typeparamref name="T"/>s.
    /// </summary>
    /// <param name="a">The start <typeparamref name="T"/>, at a <paramref name="t"/> of 0.</param>
    /// <param name="b">The end <typeparamref name="T"/>, at a <paramref name="t"/> of 1.</param>
    /// <param name="t">The interpolation, on a scale of 0 to 1 between the two values.</param>
    /// <returns>Returns the interpolated value.</returns>
    public abstract T Nlerp(T a, T b, float t);

    /// <summary>
    /// A function to normalized-linearly between two <typeparamref name="T"/>s.
    /// </summary>
    /// <param name="a">The start <typeparamref name="T"/>, at a <paramref name="t"/> of 0.</param>
    /// <param name="b">The end <typeparamref name="T"/>, at a <paramref name="t"/> of 1.</param>
    /// <param name="t">The interpolation, on a scale of 0 to 1 between the two values.</param>
    /// <returns>Returns the interpolated value.</returns>
    public abstract T Nlerp(T a, T b, double t);

    /// <summary>
    /// A function to normalized-linearly interpolate between two <typeparamref name="T"/>s,
    /// without a clamp.
    /// </summary>
    /// <param name="a">The first <typeparamref name="T"/>, at a <paramref name="t"/> of 0.</param>
    /// <param name="b">The second <typeparamref name="T"/>, at a <paramref name="t"/> of 1.</param>
    /// <param name="t">The interpolation between the two values.</param>
    /// <returns>Returns the interpolated value. <paramref name="t"/> values outside the range of
    /// 0 to 1 still affect the returned value.</returns>
    public abstract T NlerpUnclamped(T a, T b, float t);

    /// <summary>
    /// A function to normalized-linearly  interpolate between two <typeparamref name="T"/>s,
    /// without a clamp.
    /// </summary>
    /// <param name="a">The first <typeparamref name="T"/>, at a <paramref name="t"/> of 0.</param>
    /// <param name="b">The second <typeparamref name="T"/>, at a <paramref name="t"/> of 1.</param>
    /// <param name="t">The interpolation between the two values.</param>
    /// <returns>Returns the interpolated value. <paramref name="t"/> values outside the range of
    /// 0 to 1 still affect the returned value.</returns>
    public abstract T NlerpUnclamped(T a, T b, double t);
  }
  /************************************************************************************************/
}