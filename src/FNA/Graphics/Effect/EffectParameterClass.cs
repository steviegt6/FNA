#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

namespace Microsoft.Xna.Framework.Graphics
{
	/// <summary>
	/// Defines classes for effect parameters and shader constants.
	/// </summary>
	public enum EffectParameterClass
	{
		/// <summary>
		/// Scalar class type.
		/// </summary>
		Scalar,
		/// <summary>
		/// Vector class type.
		/// </summary>
		Vector,
		/// <summary>
		/// Matrix4x4 class type.
		/// </summary>
		Matrix4x4,
		/// <summary>
		/// Class type for textures, shaders or strings.
		/// </summary>
		Object,
		/// <summary>
		/// Structure class type.
		/// </summary>
		Struct
	}
}
