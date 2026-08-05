using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api.Protobuf;
using Circuits.Shared.RecRoom.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD50", Offset = "0x28BB750", VA = "0x1828BCD50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct CircuitsColor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly float B;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly float A;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly CircuitsColor Black;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly CircuitsColor White;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2D0", Offset = "0x28B8CD0", VA = "0x1828BA2D0")]
		public CircuitsColor(float r, float g, float b, float a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct CircuitsMtx4x4 : IEquatable<CircuitsMtx4x4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly float Value00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly float Value10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly float Value20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly float Value30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly float Value01;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly float Value11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly float Value21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly float Value31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly float Value02;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly float Value12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly float Value22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly float Value32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly float Value03;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly float Value13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly float Value23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly float Value33;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly CircuitsMtx4x4 Zero;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly CircuitsMtx4x4 Identity;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28BAFA0", Offset = "0x28B99A0", VA = "0x1828BAFA0")]
		public CircuitsMtx4x4(float value00, float value10, float value20, float value30, float value01, float value11, float value21, float value31, float value02, float value12, float value22, float value32, float value03, float value13, float value23, float value33)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28BA420", Offset = "0x28B8E20", VA = "0x1828BA420")]
		public static bool FYOQTCVQVIR([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28BA530", Offset = "0x28B8F30", VA = "0x1828BA530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28BA350", Offset = "0x28B8D50", VA = "0x1828BA350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28BA690", Offset = "0x28B9090", VA = "0x1828BA690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2F0", Offset = "0x28B8CF0", VA = "0x1828BA2F0", Slot = "4")]
		public bool Equals(CircuitsMtx4x4 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct CircuitsQuat : IEquatable<CircuitsQuat>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly float X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly float Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float Z;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float W;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly CircuitsQuat Identity;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly CircuitsQuat FullNaN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly CircuitsQuat UnitX;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly CircuitsQuat UnitY;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly CircuitsQuat UnitZ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2D0", Offset = "0x28B8CD0", VA = "0x1828BA2D0")]
		public CircuitsQuat(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB580", Offset = "0x28B9F80", VA = "0x1828BB580")]
		public static CircuitsQuat New(float x, float y, float z, float w)
		{
			return default(CircuitsQuat);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BB1E0", Offset = "0x28B9BE0", VA = "0x1828BB1E0")]
		public static bool FYOQTCVQVIR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BB4F0", Offset = "0x28B9EF0", VA = "0x1828BB4F0")]
		public static bool IDTAQAUODHM([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28BB220", Offset = "0x28B9C20", VA = "0x1828BB220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28BB050", Offset = "0x28B9A50", VA = "0x1828BB050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BB5A0", Offset = "0x28B9FA0", VA = "0x1828BB5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28BB280", Offset = "0x28B9C80", VA = "0x1828BB280")]
		public string HMFSIWGYSAH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BB150", Offset = "0x28B9B50", VA = "0x1828BB150", Slot = "4")]
		public bool Equals(CircuitsQuat other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PHEZCABQOSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28BCE80", Offset = "0x28BB880", VA = "0x1828BCE80")]
		public static KPKIFSBUTYI JVPEYACKYLR([In] this CircuitsQuat self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28BD020", Offset = "0x28BBA20", VA = "0x1828BD020")]
		public static CircuitsQuat WDKEUGVWMDY(this KPKIFSBUTYI a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28BCDD0", Offset = "0x28BB7D0", VA = "0x1828BCDD0")]
		public static KPKIFSBUTYI? FJFBKKYGXHE([In] this CircuitsQuat? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28BCF00", Offset = "0x28BB900", VA = "0x1828BCF00")]
		public static CircuitsQuat? UEGWFXAKCQL(this KPKIFSBUTYI? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct CircuitsRigidTransform : IEquatable<CircuitsRigidTransform>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CircuitsQuat Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CircuitsVec3 Position;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly CircuitsRigidTransform Identity;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAD0", Offset = "0x28BA4D0", VA = "0x1828BBAD0")]
		public CircuitsRigidTransform([In] CircuitsQuat rotation, [In] CircuitsVec3 position)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28BB7B0", Offset = "0x28BA1B0", VA = "0x1828BB7B0")]
		public static bool FYOQTCVQVIR([In] CircuitsRigidTransform lhs, [In] CircuitsRigidTransform rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28BB890", Offset = "0x28BA290", VA = "0x1828BB890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB6F0", Offset = "0x28BA0F0", VA = "0x1828BB6F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28BB990", Offset = "0x28BA390", VA = "0x1828BB990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28BB690", Offset = "0x28BA090", VA = "0x1828BB690", Slot = "4")]
		public bool Equals(CircuitsRigidTransform other)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 12)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CircuitsVec3 : IEquatable<CircuitsVec3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly float X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly float Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly float Z;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly CircuitsVec3 Zero;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly CircuitsVec3 One;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly CircuitsVec3 FullNaN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly CircuitsVec3 UnitX;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly CircuitsVec3 UnitY;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly CircuitsVec3 UnitZ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly CircuitsVec3 UnitNegativeX;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly CircuitsVec3 UnitNegativeY;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly CircuitsVec3 UnitNegativeZ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly CircuitsVec3 Max;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CircuitsVec3 MaxX;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly CircuitsVec3 MaxY;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CircuitsVec3 MaxZ;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly CircuitsVec3 Min;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly CircuitsVec3 MinX;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly CircuitsVec3 MinY;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly CircuitsVec3 MinZ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28BC580", Offset = "0x28BAF80", VA = "0x1828BC580")]
		public CircuitsVec3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28BBF50", Offset = "0x28BA950", VA = "0x1828BBF50")]
		public static CircuitsVec3 New(float x, float y, float z)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC40", Offset = "0x28BA640", VA = "0x1828BBC40")]
		public static bool FYOQTCVQVIR([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28BBED0", Offset = "0x28BA8D0", VA = "0x1828BBED0")]
		public static bool IDTAQAUODHM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28BC090", Offset = "0x28BAA90", VA = "0x1828BC090")]
		public static CircuitsVec3 VUDHLVIBKUN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28BC250", Offset = "0x28BAC50", VA = "0x1828BC250")]
		public static CircuitsVec3 YZACLHWQFIB([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28BC170", Offset = "0x28BAB70", VA = "0x1828BC170")]
		public static CircuitsVec3 YMAGKTYDTKZ([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28BBF70", Offset = "0x28BA970", VA = "0x1828BBF70")]
		public static CircuitsVec3 PSPPZEYSDLA([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC70", Offset = "0x28BA670", VA = "0x1828BBC70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAF0", Offset = "0x28BA4F0", VA = "0x1828BBAF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28BC040", Offset = "0x28BAA40", VA = "0x1828BC040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28BBCC0", Offset = "0x28BA6C0", VA = "0x1828BBCC0")]
		public string HMFSIWGYSAH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBC0", Offset = "0x28BA5C0", VA = "0x1828BBBC0", Slot = "4")]
		public bool Equals(CircuitsVec3 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ZSNSXKICOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28BD1B0", Offset = "0x28BBBB0", VA = "0x1828BD1B0")]
		public static WSUMHOWBGPW JVPEYACKYLR([In] this CircuitsVec3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28BD2F0", Offset = "0x28BBCF0", VA = "0x1828BD2F0")]
		public static CircuitsVec3 WDKEUGVWMDY(this WSUMHOWBGPW a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28BD0F0", Offset = "0x28BBAF0", VA = "0x1828BD0F0")]
		public static WSUMHOWBGPW? FJFBKKYGXHE([In] this CircuitsVec3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28BD220", Offset = "0x28BBC20", VA = "0x1828BD220")]
		public static CircuitsVec3? UEGWFXAKCQL(this WSUMHOWBGPW? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface YRIRYJIPQVK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YRIRYJIPQVK KMMQDNBCODQ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YRIRYJIPQVK IHYFSRXQPHT(string a, string[] b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YRIRYJIPQVK EZOLNKIYKKB();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KYZXWOEKWKU();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface MTYFAQDZYHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YRIRYJIPQVK GZDBTLOGXDS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface WCHWBGPTGBX
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? FMEQEDEASIZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct Id128<TMarker> : IEquatable<Id128<TMarker>>, BYEJVEWXCEM<Id128<TMarker>>, IComparable<Id128<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Id128<TMarker> ZVPUUHTUYEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5087D60", Offset = "0x5086760", VA = "0x185087D60")]
			get
			{
				return default(Id128<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12707F0", Offset = "0x126F1F0", VA = "0x1812707F0")]
		public Id128([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5088300", Offset = "0x5086D00", VA = "0x185088300")]
		public static Id128<TMarker> UTTXOSJJRHO()
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5087810", Offset = "0x5086210", VA = "0x185087810")]
		public static Id128<TMarker> GDGIXQFHEQC(string a)
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5087A40", Offset = "0x5086440", VA = "0x185087A40")]
		public SSPYHJXVMMH? JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5087E20", Offset = "0x5086820", VA = "0x185087E20")]
		public SSPYHJXVMMH QPPITTOXEIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5087DF0", Offset = "0x50867F0", VA = "0x185087DF0")]
		public bool QGNBNUHOAWV([In] Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x50876B0", Offset = "0x50860B0", VA = "0x1850876B0", Slot = "4")]
		public bool Equals(Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5087670", Offset = "0x5086070", VA = "0x185087670", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x50875C0", Offset = "0x5085FC0", VA = "0x1850875C0", Slot = "6")]
		public int CompareTo(Id128<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50876B0", Offset = "0x50860B0", VA = "0x1850876B0")]
		public static bool FYOQTCVQVIR([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50879E0", Offset = "0x50863E0", VA = "0x1850879E0")]
		public static bool IDTAQAUODHM([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5087930", Offset = "0x5086330", VA = "0x185087930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5088220", Offset = "0x5086C20", VA = "0x185088220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50876B0", Offset = "0x50860B0", VA = "0x1850876B0", Slot = "5")]
		private bool ZPKJAKSHIBX([In] Id128<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WTLTBSEAWIX
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3BE4140", Offset = "0x3BE2B40", VA = "0x183BE4140")]
		public static Id128<a?> WDKEUGVWMDY<a>(this SSPYHJXVMMH? a)
		{
			return default(Id128<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3EF0", Offset = "0x3BE28F0", VA = "0x183BE3EF0")]
		public static Id128<TMarker> CDNVUQNKCRU<TMarker>(this SSPYHJXVMMH a) where TMarker : notnull
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE4000", Offset = "0x3BE2A00", VA = "0x183BE4000")]
		public static Id128<b?> OYBSVBNSLVE<b>([In] this Guid self)
		{
			return default(Id128<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class NPYRHQXAXMR<b>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal static readonly Id128<b> ZVPUUHTUYEI;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal static readonly Id128<b>? PGPGIGSFFAK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct Id32<TMarker> : IEquatable<Id32<TMarker>>, BYEJVEWXCEM<Id32<TMarker>>, IComparable<Id32<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly int Int32;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<TMarker> NQNUEHVSNFU
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5088D40", Offset = "0x5087740", VA = "0x185088D40")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<TMarker> IHTRAXPOLUC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5088E00", Offset = "0x5087800", VA = "0x185088E00")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
		public Id32(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x365DF60", Offset = "0x365C960", VA = "0x18365DF60")]
		public Id32<a> KMOKFAKLJCA<a>() where a : TMarker
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
		public int JVPEYACKYLR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5088DF0", Offset = "0x50877F0", VA = "0x185088DF0")]
		public bool QGNBNUHOAWV([In] Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x50888B0", Offset = "0x50872B0", VA = "0x1850888B0", Slot = "4")]
		public bool Equals(Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50889F0", Offset = "0x50873F0", VA = "0x1850889F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x20975C0", Offset = "0x2095FC0", VA = "0x1820975C0", Slot = "6")]
		public int CompareTo(Id32<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5088AA0", Offset = "0x50874A0", VA = "0x185088AA0")]
		public static bool FYOQTCVQVIR(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5088D00", Offset = "0x5087700", VA = "0x185088D00")]
		public static bool IDTAQAUODHM(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x131A8D0", Offset = "0x13192D0", VA = "0x18131A8D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5088F80", Offset = "0x5087980", VA = "0x185088F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5088AE0", Offset = "0x50874E0", VA = "0x185088AE0")]
		public string HSBCBQVTVIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50887E0", Offset = "0x50871E0", VA = "0x1850887E0", Slot = "5")]
		private bool ELHFTZSECON([In] Id32<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MYOVHZBVQBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE0FF50", Offset = "0xE0E950", VA = "0x180E0FF50")]
		public static Id32<a?> OYBSVBNSLVE<a>(this int a)
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE0FF50", Offset = "0xE0E950", VA = "0x180E0FF50")]
		public static Id32<b?> PJIXGMJEJYK<b>(this int a)
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x37A1880", Offset = "0x37A0280", VA = "0x1837A1880")]
		public static CopyEnumerable<Id32<c?>, Id32RangeEnumerator<c?>> RRIYTCZYDPG<c>(Id32<c> startInclusive, Id32<c> endExclusive)
		{
			return default(CopyEnumerable<Id32<c>, Id32RangeEnumerator<c>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37A16F0", Offset = "0x37A00F0", VA = "0x1837A16F0")]
		public static CopyEnumerable<Id32<d?>, Id32RangeEnumerator<d?>> JUKILYVPXQW<d>(this Id32<d> endExclusive)
		{
			return default(CopyEnumerable<Id32<d>, Id32RangeEnumerator<d>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x37A17B0", Offset = "0x37A01B0", VA = "0x1837A17B0")]
		public static Id32<TMarker?> Offset<TMarker>(this Id32<TMarker> self, int offset)
		{
			return default(Id32<TMarker>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class GARSNDARJWN<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x36300D0", Offset = "0x362EAD0", VA = "0x1836300D0")]
		public static Id32<b> GEWKGALZMRL<a>(Id32<a> self) where a : b
		{
			return default(Id32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Id32Enumerator<M> : IEnumerator<Id32<M>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int _current;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly Id32<M> Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5088520", Offset = "0x5086F20", VA = "0x185088520", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private readonly object IDRIDRBRWXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5088470", Offset = "0x5086E70", VA = "0x185088470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		private Id32Enumerator(int count, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5088420", Offset = "0x5086E20", VA = "0x185088420")]
		public static Id32Enumerator<M> JFQGFEWUUCS(int a)
		{
			return default(Id32Enumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5088460", Offset = "0x5086E60", VA = "0x185088460", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5088510", Offset = "0x5086F10", VA = "0x185088510", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PUIKNAVMTUN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x38D91B0", Offset = "0x38D7BB0", VA = "0x1838D91B0")]
		public static Id32Enumerator<a?> SERCJBYQQPR<a>(Id32<a> afterLast)
		{
			return default(Id32Enumerator<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct Id32RangeEnumerator<M> : IEnumerator<Id32<M>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly int _startExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int _endExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int _current;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly Id32<M> Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x50887A0", Offset = "0x50871A0", VA = "0x1850887A0", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private readonly object IDRIDRBRWXH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5088680", Offset = "0x5087080", VA = "0x185088680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBF1DA0", Offset = "0xBF07A0", VA = "0x180BF1DA0")]
		internal Id32RangeEnumerator(int startExclusive, int endExclusive, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50885D0", Offset = "0x5086FD0", VA = "0x1850885D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5088720", Offset = "0x5087120", VA = "0x185088720", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class YZQOQICWSDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BDC0", Offset = "0x3C0A7C0", VA = "0x183C0BDC0")]
		public static Id32RangeEnumerator<M?> New<M>(Id32<M> startInclusive, Id32<M> endExclusive)
		{
			return default(Id32RangeEnumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BF00", Offset = "0x3C0A900", VA = "0x183C0BF00")]
		public static CopyEnumerable<Id32<a?>, Id32RangeEnumerator<a?>> SDORXQTOBAJ<a>(Id32<a> startInclusive, Id32<a> endExclusive)
		{
			return default(CopyEnumerable<Id32<a>, Id32RangeEnumerator<a>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct IdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Id32<M> KYZXWOEKWKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x50898C0", Offset = "0x50882C0", VA = "0x1850898C0")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28C6C30", Offset = "0x28C5630", VA = "0x1828C6C30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x35BBF50", Offset = "0x35BA950", VA = "0x1835BBF50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		internal IdArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5089770", Offset = "0x5088170", VA = "0x185089770")]
		public static IdArray<M, T> New(int length)
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50894B0", Offset = "0x5087EB0", VA = "0x1850894B0")]
		public static IdArray<M, T> Empty()
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC00D70", Offset = "0xBFF770", VA = "0x180C00D70")]
		public IEnumerable<T> RTOAZYNIIXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5089260", Offset = "0x5087C60", VA = "0x185089260")]
		public IdSpan<M, T> AIWLHXHQSTM()
		{
			return default(IdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5089800", Offset = "0x5088200", VA = "0x185089800")]
		public ReadOnlyIdArray<M, T> OVELFCUOCLP()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5089630", Offset = "0x5088030", VA = "0x185089630")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x50899F0", Offset = "0x50883F0", VA = "0x1850899F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class AFOQNGKSPBW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3018290", Offset = "0x3016C90", VA = "0x183018290")]
		public static IdArray<a, T> EPTIUAEBBDS<T>(params T[] array) where T : notnull
		{
			return default(IdArray<a, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class EJMRGVWNUPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x35BBEB0", Offset = "0x35BA8B0", VA = "0x1835BBEB0")]
		public static b? BCWSWZHXEWR<b, a>(this IdArray<a, b> self, Id32<a> i)
		{
			return (b?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35BBF50", Offset = "0x35BA950", VA = "0x1835BBF50")]
		public static d? EEIMAHKHUGN<d, c>(this IdArray<c, d> self, Id32<c> i)
		{
			return (d?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x35BC230", Offset = "0x35BAC30", VA = "0x1835BC230")]
		public static void Set<M, T>(this IdArray<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x35BC0E0", Offset = "0x35BAAE0", VA = "0x1835BC0E0")]
		public static void SWMAQODUKIJ<i, j>(this IdArray<i, j> self, Id32<i> i, j value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[DefaultMember("Item")]
	public ref struct IdSpan<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly Span<T> _span;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12707F0", Offset = "0x126F1F0", VA = "0x1812707F0")]
		internal IdSpan([In] Span<T> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1004B50", Offset = "0x1003550", VA = "0x181004B50")]
		public readonly Span<T> BCSSCXYFQHN()
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x508AB60", Offset = "0x5089560", VA = "0x18508AB60")]
		public readonly ReadOnlyIdSpan<M, T> XQEGEIVWPJS()
		{
			return default(ReadOnlyIdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x508A810", Offset = "0x5089210", VA = "0x18508A810", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class HNYKLALCKMZ<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3060EF0", Offset = "0x305F8F0", VA = "0x183060EF0")]
		public static IdSpan<c?, b?> GVUZGCZDHJN<b>([In] Span<b> span)
		{
			return default(IdSpan<c, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class BDQTMHYJZES
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x33BA860", Offset = "0x33B9260", VA = "0x1833BA860")]
		public static void Set<M, T>([In] this IdSpan<M, T> self, Id32<M> i, [In] T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface JIZXHTKSSHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float VMENPPAGJLM([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float FQYCKGVNWYW([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitsColor UAKFZBUGRPF([In] CircuitsColor a, [In] CircuitsColor b, float a);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float TRQLECVKPKH([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CircuitsVec3 KGAPTTXXXKB([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CircuitsQuat WDMCWAWOUEM([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitsMtx4x4 XELZGTQUBNU([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CircuitsMtx4x4 GBPEXFWQEFA([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CircuitsMtx4x4 APBAUGNMVTA([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		float HCCZDQSJRNV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CircuitsQuat RPFWVETUHLQ(float a, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		CircuitsQuat FBBVFLRPVHX([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		CircuitsQuat HPFBLYCAFRB([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CircuitsQuat HSZREEMGWEB([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CircuitsQuat JUJPACXOSWM([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CircuitsQuat IEHRBHLGNLT([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CircuitsQuat OPILEZFEVRC([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float XNGUQZMUGLT([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CircuitsQuat IPSNVPDBMEE([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		CircuitsQuat QOUGKAMHGIH([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CircuitsQuat ZSQYIQKEZHX([In] CircuitsQuat from, [In] CircuitsQuat to, float a);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CircuitsVec3 MUDGHFRWQEA([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		CircuitsQuat WYYMJUFMRKI([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void YPTZQTDUIGN([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		CircuitsVec3 LHQZPLBZFCW([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CircuitsVec3 KDGEZYSGPDV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		CircuitsVec3 NKBGQEZYVOX([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		CircuitsVec3 FMFELMPUFJW([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		CircuitsVec3 FRFDIAUXEWI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		CircuitsVec3 ZBWASVKQJDO([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		CircuitsVec3 MMCMNJISFYA([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		float BPYQBNTTKVJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		float WASRZVPHUNF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		float PLYFHTXANPE([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		CircuitsVec3 NIZOJWIIDTD([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		CircuitsVec3 AELIYEAQMFG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		float EGKYCEEXEHT([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		CircuitsVec3 EQFBPMOZEIT([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		CircuitsVec3 JFWYTPHRVHU([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		CircuitsVec3 VZYMFNMLOMX([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CircuitsVec3 RHCFNKUNNBD([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		CircuitsVec3 QZCQLHNKFYS([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		CircuitsVec3 XCJZRJEWCUO([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		CircuitsVec3 ZIKYUQKLZNW([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		CircuitsVec3 GLKOOSPDBME([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		CircuitsVec3 SZRSBPEHCCU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task EZHTLXTJMFW(Func<Task> a);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void EBBFYAAZENO([Optional] string? a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		PDZCNDGPMJR<NSOJHEXWUKL> ODOCBVFBVXA();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		PDZCNDGPMJR<NSOJHEXWUKL> PBNCGYKJZET();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		float QRAIJYHXFEF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class FRFDGBEWLSX
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28BC590", Offset = "0x28BAF90", VA = "0x1828BC590")]
		public static CircuitsRigidTransform KUZFXJHWEVV(this JIZXHTKSSHE a, [In] CircuitsRigidTransform rigidTransform, [In] CircuitsMtx4x4 transform)
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Output
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface QYBKDSUBDHB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool DOVZCAMKXGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface WMXFPDHFSSW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		QYBKDSUBDHB IYLXMBGRHWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FVCFXJGTXVV
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x36A0B70", Offset = "0x369F570", VA = "0x1836A0B70")]
		public static bool LYRHOBDLLLN<TSelf>(this TSelf a) where TSelf : notnull, WMXFPDHFSSW
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct LogDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly LogDelegates Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Obsolete("Code using LogFlags.Debug should not be checked in!")]
		public readonly LogDelegates Debug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly LogDelegates CircuitsV2CloudData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly LogDelegates CircuitsV2DebugLogNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly LogDelegates CircuitsV2Environments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly LogDelegates CircuitsV2EventBus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly LogDelegates CircuitsV2Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly LogDelegates CircuitsV2Heat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly LogDelegates CircuitsV2Memory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly LogDelegates CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly LogDelegates CircuitsV2Reduce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly LogDelegates CircuitsV2Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly LogDelegates CircuitsV2State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly LogDelegates CircuitsV2CloudDataOrMemory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly LogDelegates DefaultOrCircuitsV2DebugLogNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LogDelegates CircuitsV2Stopwatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly LogDelegates CircuitsV2VerboseStopwatches;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28BC900", Offset = "0x28BB300", VA = "0x1828BC900")]
		public LogDeps([In] LogDelegates @default, [In] LogDelegates debug, [In] LogDelegates circuitsV2CloudData, [In] LogDelegates circuitsV2DebugLogNode, [In] LogDelegates circuitsV2Environments, [In] LogDelegates circuitsV2EventBus, [In] LogDelegates circuitsV2Graph, [In] LogDelegates circuitsV2Heat, [In] LogDelegates circuitsV2Memory, [In] LogDelegates circuitsV2RecRoomIntegration, [In] LogDelegates circuitsV2Reduce, [In] LogDelegates circuitsV2Root, [In] LogDelegates circuitsV2State, [In] LogDelegates circuitsV2CloudDataOrMemory, [In] LogDelegates defaultOrCircuitsV2DebugLogNode, [In] LogDelegates circuitsV2Stopwatches, [In] LogDelegates circuitsV2VerboseStopwatches)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class KQPBKUZCJXR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class TTSTDRWIEBX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class VJKOEGYQQCQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class ASDRXZXCACQ<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class MLQMNZEWPGO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class WBZFYOYOFGY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ReadOnlyIdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ReadOnlyArray<T> _array;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<M> KYZXWOEKWKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBAD0", Offset = "0x5DDA4D0", VA = "0x185DDBAD0")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5DDB120", Offset = "0x5DD9B20", VA = "0x185DDB120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5DDBF80", Offset = "0x5DDA980", VA = "0x185DDBF80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287A820", VA = "0x18287BE20")]
		internal ReadOnlyIdArray(ReadOnlyArray<T> array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAEC0", Offset = "0x5DD98C0", VA = "0x185DDAEC0")]
		public static ReadOnlyIdArray<M, T> Empty()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2530", Offset = "0x3CF0F30", VA = "0x183CF2530")]
		public IEnumerable<T> RTOAZYNIIXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xC00D70", Offset = "0xBFF770", VA = "0x180C00D70")]
		public ReadOnlyArray<T> OMHBPTSDWVM()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBDF0", Offset = "0x5DDA7F0", VA = "0x185DDBDF0")]
		public ReadOnlySpan<T> YRBDSNZHXQF()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB890", Offset = "0x5DDA290", VA = "0x185DDB890")]
		public bool KYQLKMUDLVU(Id32<M> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB960", Offset = "0x5DDA360", VA = "0x185DDB960")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> LKTRUZVFLRI()
		{
			return default(ConstEnumerable<T, ReadOnlyArray<T>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB060", Offset = "0x5DD9A60", VA = "0x185DDB060")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB160", Offset = "0x5DD9B60", VA = "0x185DDB160")]
		public T? JKUTLUUBQZW(Id32<M> id)
		{
			return (T?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBD30", Offset = "0x5DDA730", VA = "0x185DDBD30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EIGNIIQLMJU<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x362FF60", Offset = "0x362E960", VA = "0x18362FF60")]
		public static ReadOnlyIdArray<b, T> EPTIUAEBBDS<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyIdArray<b, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x35BA520", Offset = "0x35B8F20", VA = "0x1835BA520")]
		public static ReadOnlyIdArray<b?, a?> NEIUPHJEIPY<a>(ReadOnlyArray<a> readOnlyArray)
		{
			return default(ReadOnlyIdArray<b, a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public ref struct ReadOnlyIdSpan<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReadOnlySpan<T> _readOnlySpan;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5DDC3B0", Offset = "0x5DDADB0", VA = "0x185DDC3B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x12707F0", Offset = "0x126F1F0", VA = "0x1812707F0")]
		internal ReadOnlyIdSpan([In] ReadOnlySpan<T> readOnlySpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC200", Offset = "0x5DDAC00", VA = "0x185DDC200", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class YQKRJEVOKEH<f>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3060EF0", Offset = "0x305F8F0", VA = "0x183060EF0")]
		public static ReadOnlyIdSpan<f?, d?> NIVHAQNWMAJ<d>([In] ReadOnlySpan<d> readOnlySpan)
		{
			return default(ReadOnlyIdSpan<f, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3060DE0", Offset = "0x305F7E0", VA = "0x183060DE0")]
		public static ReadOnlyIdSpan<f?, e?> GVUZGCZDHJN<e>([In] Span<e> span)
		{
			return default(ReadOnlyIdSpan<f, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum RoomVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		V1,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		V2
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
