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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6DCE0", Offset = "0x2B6C6E0", VA = "0x182B6DCE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6AC20", Offset = "0x2B69620", VA = "0x182B6AC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6B920", Offset = "0x2B6A320", VA = "0x182B6B920")]
		public CircuitsMtx4x4(float value00, float value10, float value20, float value30, float value01, float value11, float value21, float value31, float value02, float value12, float value22, float value32, float value03, float value13, float value23, float value33)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AED0", Offset = "0x2B698D0", VA = "0x182B6AED0")]
		public static bool IQJYWSDTJLC([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD70", Offset = "0x2B69770", VA = "0x182B6AD70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ACA0", Offset = "0x2B696A0", VA = "0x182B6ACA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AFE0", Offset = "0x2B699E0", VA = "0x182B6AFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC40", Offset = "0x2B69640", VA = "0x182B6AC40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6AC20", Offset = "0x2B69620", VA = "0x182B6AC20")]
		public CircuitsQuat(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BE80", Offset = "0x2B6A880", VA = "0x182B6BE80")]
		public static CircuitsQuat New(float x, float y, float z, float w)
		{
			return default(CircuitsQuat);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BE40", Offset = "0x2B6A840", VA = "0x182B6BE40")]
		public static bool IQJYWSDTJLC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BEA0", Offset = "0x2B6A8A0", VA = "0x182B6BEA0")]
		public static bool OOOEUMVNSLV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BDE0", Offset = "0x2B6A7E0", VA = "0x182B6BDE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B9D0", Offset = "0x2B6A3D0", VA = "0x182B6B9D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BF30", Offset = "0x2B6A930", VA = "0x182B6BF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BB70", Offset = "0x2B6A570", VA = "0x182B6BB70")]
		public string FXPDZKSVARC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BAE0", Offset = "0x2B6A4E0", VA = "0x182B6BAE0", Slot = "4")]
		public bool Equals(CircuitsQuat other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GHXBLYXPOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CF80", Offset = "0x2B6B980", VA = "0x182B6CF80")]
		public static ZBVMUDIETPN GHRXOLGFAHI([In] this CircuitsQuat self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D000", Offset = "0x2B6BA00", VA = "0x182B6D000")]
		public static CircuitsQuat GTHJBIMUMZN(this ZBVMUDIETPN a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D0D0", Offset = "0x2B6BAD0", VA = "0x182B6D0D0")]
		public static ZBVMUDIETPN? KLSODAJNEMT([In] this CircuitsQuat? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D180", Offset = "0x2B6BB80", VA = "0x182B6D180")]
		public static CircuitsQuat? OTVQASNCDGG(this ZBVMUDIETPN? a)
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
		[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6AE80", VA = "0x182B6C480")]
		public CircuitsRigidTransform([In] CircuitsQuat rotation, [In] CircuitsVec3 position)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C250", Offset = "0x2B6AC50", VA = "0x182B6C250")]
		public static bool IQJYWSDTJLC([In] CircuitsRigidTransform lhs, [In] CircuitsRigidTransform rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C150", Offset = "0x2B6AB50", VA = "0x182B6C150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C090", Offset = "0x2B6AA90", VA = "0x182B6C090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C330", Offset = "0x2B6AD30", VA = "0x182B6C330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C030", Offset = "0x2B6AA30", VA = "0x182B6C030", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6CF70", Offset = "0x2B6B970", VA = "0x182B6CF70")]
		public CircuitsVec3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CA40", Offset = "0x2B6B440", VA = "0x182B6CA40")]
		public static CircuitsVec3 New(float x, float y, float z)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C930", Offset = "0x2B6B330", VA = "0x182B6C930")]
		public static bool IQJYWSDTJLC([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CA60", Offset = "0x2B6B460", VA = "0x182B6CA60")]
		public static bool OOOEUMVNSLV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C960", Offset = "0x2B6B360", VA = "0x182B6C960")]
		public static CircuitsVec3 NYJZWIHHGTK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CC10", Offset = "0x2B6B610", VA = "0x182B6CC10")]
		public static CircuitsVec3 ZWXIXGSHNLY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CAE0", Offset = "0x2B6B4E0", VA = "0x182B6CAE0")]
		public static CircuitsVec3 SPDBFPSYQZO([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C860", Offset = "0x2B6B260", VA = "0x182B6C860")]
		public static CircuitsVec3 HBAWSLJSGMD([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C810", Offset = "0x2B6B210", VA = "0x182B6C810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C4A0", Offset = "0x2B6AEA0", VA = "0x182B6C4A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CBC0", Offset = "0x2B6B5C0", VA = "0x182B6CBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C600", Offset = "0x2B6B000", VA = "0x182B6C600")]
		public string FXPDZKSVARC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C580", Offset = "0x2B6AF80", VA = "0x182B6C580", Slot = "4")]
		public bool Equals(CircuitsVec3 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class MCVMPRTXKVS
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D6F0", Offset = "0x2B6C0F0", VA = "0x182B6D6F0")]
		public static FOBEDORKDJF GHRXOLGFAHI([In] this CircuitsVec3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D760", Offset = "0x2B6C160", VA = "0x182B6D760")]
		public static CircuitsVec3 GTHJBIMUMZN(this FOBEDORKDJF a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D800", Offset = "0x2B6C200", VA = "0x182B6D800")]
		public static FOBEDORKDJF? KLSODAJNEMT([In] this CircuitsVec3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D8C0", Offset = "0x2B6C2C0", VA = "0x182B6D8C0")]
		public static CircuitsVec3? OTVQASNCDGG(this FOBEDORKDJF? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NNUVDKBLROH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NNUVDKBLROH OBQIHAJMBSL(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NNUVDKBLROH GRFKSHXEHZI(string a, string[] b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NNUVDKBLROH VDZNUPNJXHE();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CLJSAMBXECZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CCEZIAZAKCW
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NNUVDKBLROH QPHYVBXREPR(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface GYLDOFPAMRI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? XKUIOVSBEAA(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct Id128<TMarker> : IEquatable<Id128<TMarker>>, OBLVMRVNUCX<Id128<TMarker>>, IComparable<Id128<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Id128<TMarker> IYCZABTNUWN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x65D1E50", Offset = "0x65D0850", VA = "0x1865D1E50")]
			get
			{
				return default(Id128<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x152A0D0", Offset = "0x1528AD0", VA = "0x18152A0D0")]
		public Id128([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65D1FC0", Offset = "0x65D09C0", VA = "0x1865D1FC0")]
		public static Id128<TMarker> PWPOYCWPTLV()
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x65D1D50", Offset = "0x65D0750", VA = "0x1865D1D50")]
		public static Id128<TMarker> HQKDKSPPNUV(string a)
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65D1970", Offset = "0x65D0370", VA = "0x1865D1970")]
		public VLBRSWSXMQG? GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65D17E0", Offset = "0x65D01E0", VA = "0x1865D17E0")]
		public VLBRSWSXMQG FJDYDDVRQGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65D2290", Offset = "0x65D0C90", VA = "0x1865D2290")]
		public bool VPMCMGYWJAO([In] Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65D1580", Offset = "0x65CFF80", VA = "0x1865D1580", Slot = "4")]
		public bool Equals(Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65D1540", Offset = "0x65CFF40", VA = "0x1865D1540", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x65D1490", Offset = "0x65CFE90", VA = "0x1865D1490", Slot = "6")]
		public int CompareTo(Id128<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x65D1580", Offset = "0x65CFF80", VA = "0x1865D1580")]
		public static bool IQJYWSDTJLC([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x65D1EE0", Offset = "0x65D08E0", VA = "0x1865D1EE0")]
		public static bool OOOEUMVNSLV([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65D1C90", Offset = "0x65D0690", VA = "0x1865D1C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65D21B0", Offset = "0x65D0BB0", VA = "0x1865D21B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65D1580", Offset = "0x65CFF80", VA = "0x1865D1580", Slot = "5")]
		private bool UKYTEBTGFOI([In] Id128<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class TLNPLSZPQHQ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3F512A0", Offset = "0x3F4FCA0", VA = "0x183F512A0")]
		public static Id128<a?> GTHJBIMUMZN<a>(this VLBRSWSXMQG? a)
		{
			return default(Id128<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F514F0", Offset = "0x3F4FEF0", VA = "0x183F514F0")]
		public static Id128<TMarker> IUZFKNOVLFP<TMarker>(this VLBRSWSXMQG a) where TMarker : notnull
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3F513B0", Offset = "0x3F4FDB0", VA = "0x183F513B0")]
		public static Id128<b?> HQDNGTXYQSZ<b>([In] this Guid self)
		{
			return default(Id128<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MVRSWHIWQHM<b>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal static readonly Id128<b> IYCZABTNUWN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal static readonly Id128<b>? GXOSMXEUVYJ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct Id32<TMarker> : IEquatable<Id32<TMarker>>, OBLVMRVNUCX<Id32<TMarker>>, IComparable<Id32<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly int Int32;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<TMarker> WOQMWIAUPTH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x65D29B0", Offset = "0x65D13B0", VA = "0x1865D29B0")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<TMarker> PWNVHYWZRON
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65D26D0", Offset = "0x65D10D0", VA = "0x1865D26D0")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
		public Id32(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x39A0C10", Offset = "0x399F610", VA = "0x1839A0C10")]
		public Id32<a> FYOVYMNUENR<a>() where a : TMarker
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0")]
		public int GHRXOLGFAHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x65D2DE0", Offset = "0x65D17E0", VA = "0x1865D2DE0")]
		public bool VPMCMGYWJAO([In] Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x65D2710", Offset = "0x65D1110", VA = "0x1865D2710", Slot = "4")]
		public bool Equals(Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x65D2850", Offset = "0x65D1250", VA = "0x1865D2850", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2389AD0", Offset = "0x23884D0", VA = "0x182389AD0", Slot = "6")]
		public int CompareTo(Id32<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x65D2890", Offset = "0x65D1290", VA = "0x1865D2890")]
		public static bool IQJYWSDTJLC(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65D29F0", Offset = "0x65D13F0", VA = "0x1865D29F0")]
		public static bool OOOEUMVNSLV(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1618D80", Offset = "0x1617780", VA = "0x181618D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x65D2D10", Offset = "0x65D1710", VA = "0x1865D2D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x65D2AA0", Offset = "0x65D14A0", VA = "0x1865D2AA0")]
		public string QZAZHIUZYCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x65D2DF0", Offset = "0x65D17F0", VA = "0x1865D2DF0", Slot = "5")]
		private bool ZUWKUZTZAJE([In] Id32<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class PDABEAEUXAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x10C3090", Offset = "0x10C1A90", VA = "0x1810C3090")]
		public static Id32<a?> HQDNGTXYQSZ<a>(this int a)
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x10C3090", Offset = "0x10C1A90", VA = "0x1810C3090")]
		public static Id32<b?> KLWGYZTNQWX<b>(this int a)
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EC20", Offset = "0x3D8D620", VA = "0x183D8EC20")]
		public static CopyEnumerable<Id32<c?>, Id32RangeEnumerator<c?>> ZBVRIGYEROF<c>(Id32<c> startInclusive, Id32<c> endExclusive)
		{
			return default(CopyEnumerable<Id32<c>, Id32RangeEnumerator<c>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EA90", Offset = "0x3D8D490", VA = "0x183D8EA90")]
		public static CopyEnumerable<Id32<d?>, Id32RangeEnumerator<d?>> BZFVMLVSPVF<d>(this Id32<d> endExclusive)
		{
			return default(CopyEnumerable<Id32<d>, Id32RangeEnumerator<d>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EB50", Offset = "0x3D8D550", VA = "0x183D8EB50")]
		public static Id32<TMarker?> Offset<TMarker>(this Id32<TMarker> self, int offset)
		{
			return default(Id32<TMarker>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class GJVARSFFUMA<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x37D20D0", Offset = "0x37D0AD0", VA = "0x1837D20D0")]
		public static Id32<b> YUPBFVSGMCC<a>(Id32<a> self) where a : b
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
			[Cpp2IlInjected.Address(RVA = "0x65D23B0", Offset = "0x65D0DB0", VA = "0x1865D23B0", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private readonly object RTHQPUQEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x65D22C0", Offset = "0x65D0CC0", VA = "0x1865D22C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		private Id32Enumerator(int count, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65D2350", Offset = "0x65D0D50", VA = "0x1865D2350")]
		public static Id32Enumerator<M> LIRHMMEOVUT(int a)
		{
			return default(Id32Enumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x65D2390", Offset = "0x65D0D90", VA = "0x1865D2390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x65D23A0", Offset = "0x65D0DA0", VA = "0x1865D23A0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LYMATDYVPZE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7B70", Offset = "0x3BF6570", VA = "0x183BF7B70")]
		public static Id32Enumerator<a?> UARPUQRGEBE<a>(Id32<a> afterLast)
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
			[Cpp2IlInjected.Address(RVA = "0x65D2620", Offset = "0x65D1020", VA = "0x1865D2620", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private readonly object RTHQPUQEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x65D2500", Offset = "0x65D0F00", VA = "0x1865D2500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEB8280", Offset = "0xEB6C80", VA = "0x180EB8280")]
		internal Id32RangeEnumerator(int startExclusive, int endExclusive, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65D2590", Offset = "0x65D0F90", VA = "0x1865D2590", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65D25A0", Offset = "0x65D0FA0", VA = "0x1865D25A0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class FDAIHFUBMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3AB38C0", Offset = "0x3AB22C0", VA = "0x183AB38C0")]
		public static Id32RangeEnumerator<M?> New<M>(Id32<M> startInclusive, Id32<M> endExclusive)
		{
			return default(Id32RangeEnumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AB37E0", Offset = "0x3AB21E0", VA = "0x183AB37E0")]
		public static CopyEnumerable<Id32<a?>, Id32RangeEnumerator<a?>> NVIIWIUAOBK<a>(Id32<a> startInclusive, Id32<a> endExclusive)
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
		public Id32<M> CLJSAMBXECZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x65D38B0", Offset = "0x65D22B0", VA = "0x1865D38B0")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B76A50", Offset = "0x2B75450", VA = "0x182B76A50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3B90440", Offset = "0x3B8EE40", VA = "0x183B90440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6AB0", VA = "0x180EC80B0")]
		internal IdArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x65D35B0", Offset = "0x65D1FB0", VA = "0x1865D35B0")]
		public static IdArray<M, T> New(int length)
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65D2EB0", Offset = "0x65D18B0", VA = "0x1865D2EB0")]
		public static IdArray<M, T> Empty()
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
		public IEnumerable<T> QGYXVPSWMAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65D3450", Offset = "0x65D1E50", VA = "0x1865D3450")]
		public IdSpan<M, T> HQMFSQCIIKF()
		{
			return default(IdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65D3630", Offset = "0x65D2030", VA = "0x1865D3630")]
		public ReadOnlyIdArray<M, T> OQEVVHVVNOQ()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65D3020", Offset = "0x65D1A20", VA = "0x1865D3020")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65D36F0", Offset = "0x65D20F0", VA = "0x1865D36F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class YOZROFYVBKB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3366860", Offset = "0x3365260", VA = "0x183366860")]
		public static IdArray<a, T> POQXTOXNHSF<T>(params T[] array) where T : notnull
		{
			return default(IdArray<a, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MYEXCEWTHWO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B90130", Offset = "0x3B8EB30", VA = "0x183B90130")]
		public static b? JUNOPUDEALM<b, a>(this IdArray<a, b> self, Id32<a> i)
		{
			return (b?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3B90440", Offset = "0x3B8EE40", VA = "0x183B90440")]
		public static d? QOPCXEBIBWS<d, c>(this IdArray<c, d> self, Id32<c> i)
		{
			return (d?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3B946E0", Offset = "0x3B930E0", VA = "0x183B946E0")]
		public static void Set<M, T>(this IdArray<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B8F110", Offset = "0x3B8DB10", VA = "0x183B8F110")]
		public static void DAVEWOUFRRA<i, j>(this IdArray<i, j> self, Id32<i> i, j value)
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
		[Cpp2IlInjected.Address(RVA = "0x152A0D0", Offset = "0x1528AD0", VA = "0x18152A0D0")]
		internal IdSpan([In] Span<T> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B74B0", VA = "0x1812B8AB0")]
		public readonly Span<T> KINPYRRBFOI()
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x65D4600", Offset = "0x65D3000", VA = "0x1865D4600")]
		public readonly ReadOnlyIdSpan<M, T> IMRXWUFKIVV()
		{
			return default(ReadOnlyIdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65D46E0", Offset = "0x65D30E0", VA = "0x1865D46E0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class WFSWCZUJMCC<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x39BD090", Offset = "0x39BBA90", VA = "0x1839BD090")]
		public static IdSpan<c?, b?> NVXAIMCVQGM<b>([In] Span<b> span)
		{
			return default(IdSpan<c, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class TZYGKIIFDFT
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F67300", Offset = "0x3F65D00", VA = "0x183F67300")]
		public static void Set<M, T>([In] this IdSpan<M, T> self, Id32<M> i, [In] T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface TNPFMTBMEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float KLOJWOMZICX([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float CZEIJWBPGZH([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitsColor YDPRYNNTNYS([In] CircuitsColor a, [In] CircuitsColor b, float a);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float XJLXKGXHXNO([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CircuitsVec3 KNZPKNBBVTO([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CircuitsQuat TRMDUJQCKSZ([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitsMtx4x4 GASMRAZDKPZ([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CircuitsMtx4x4 TEIRXIVMFEV([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CircuitsMtx4x4 YNJYYPLJSGB([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		float MTNKVOCEDSS([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CircuitsQuat RFSPRWEAFSX(float a, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		CircuitsQuat LVURUGMEFNK([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		CircuitsQuat OVLOCOYXTME([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CircuitsQuat EQMGYRMRIZM([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CircuitsQuat KHMQEQRVCJH([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CircuitsQuat PUKXWCPAKYW([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CircuitsQuat DHFVQTFFIPH([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float ZJFQAZKGUKA([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CircuitsQuat VEMNYAXMNML([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		CircuitsQuat JXQPKOPNIIK([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CircuitsQuat MCAVQOHYSYA([In] CircuitsQuat from, [In] CircuitsQuat to, float a);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CircuitsVec3 ZTTBYWHKDKD([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		CircuitsQuat JVBLTAINJMB([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void VDMUQXFVUMQ([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		CircuitsVec3 YWNKNOUQPQH([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CircuitsVec3 ZDTWWGHATRA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		CircuitsVec3 XODVKIKVRRG([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		CircuitsVec3 VHLKXUYCMSV([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		CircuitsVec3 FWDYENITHAN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		CircuitsVec3 YVIPWEPDIRD([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		CircuitsVec3 KLMDTWALRJF([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		float RBWMBLNIAZU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		float RVXZVORSCCW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		float PDDTIMFUVIZ([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		CircuitsVec3 TSFROZVLIQC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		CircuitsVec3 XHZJBLUXBKZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		float FQPCJGLGECU([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		CircuitsVec3 ILNXRRLKUPU([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		CircuitsVec3 EZBDUWSNKRP([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		CircuitsVec3 MYGDUBZAXWW([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CircuitsVec3 VTZKFWMGBEU([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		CircuitsVec3 YGXOUIIEOCN([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		CircuitsVec3 QQAGJSJWMDN([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		CircuitsVec3 LXTQHSUMVYL([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		CircuitsVec3 FXIBPKPWQST([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		CircuitsVec3 RAQMQQEHLZL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task FDIKZSMAYVH(Func<Task> a);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void ZCPPZGSRGMV([Optional] string? a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		UBEBOZCAVGU<KONMMJWHXTO> ROYFGZQKBAF();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		UBEBOZCAVGU<KONMMJWHXTO> KNUUDIXVUWE();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		float UXUAXSCMTPY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class MQJXJGIXWWI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D990", Offset = "0x2B6C390", VA = "0x182B6D990")]
		public static CircuitsRigidTransform VXCMHSBUKPY(this TNPFMTBMEDB a, [In] CircuitsRigidTransform rigidTransform, [In] CircuitsMtx4x4 transform)
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
	public interface EQFICGHEXRE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool ATPYNSOEZHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface CNJWCYVXBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		EQFICGHEXRE ZMZHZWJQYGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class MDXWRWPFUGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AE00", Offset = "0x3C19800", VA = "0x183C1AE00")]
		public static bool JRBNKKTFGUA<TSelf>(this TSelf a) where TSelf : notnull, CNJWCYVXBGJ
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
		[Cpp2IlInjected.Address(RVA = "0x2B6D2A0", Offset = "0x2B6BCA0", VA = "0x182B6D2A0")]
		public LogDeps([In] LogDelegates @default, [In] LogDelegates debug, [In] LogDelegates circuitsV2CloudData, [In] LogDelegates circuitsV2DebugLogNode, [In] LogDelegates circuitsV2Environments, [In] LogDelegates circuitsV2EventBus, [In] LogDelegates circuitsV2Graph, [In] LogDelegates circuitsV2Heat, [In] LogDelegates circuitsV2Memory, [In] LogDelegates circuitsV2RecRoomIntegration, [In] LogDelegates circuitsV2Reduce, [In] LogDelegates circuitsV2Root, [In] LogDelegates circuitsV2State, [In] LogDelegates circuitsV2CloudDataOrMemory, [In] LogDelegates defaultOrCircuitsV2DebugLogNode, [In] LogDelegates circuitsV2Stopwatches, [In] LogDelegates circuitsV2VerboseStopwatches)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GEJEFIAWMNS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CQQKHLGBDOQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BEQDFDHTNDH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class UTDLMYHANGH<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class FKAHYQVBHTH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class RRRVXHRUCXR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ReadOnlyIdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ReadOnlyArray<T> _array;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<M> CLJSAMBXECZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x77E11E0", Offset = "0x77DFBE0", VA = "0x1877E11E0")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x77E1270", Offset = "0x77DFC70", VA = "0x1877E1270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x77E1330", Offset = "0x77DFD30", VA = "0x1877E1330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D390", Offset = "0x2B1BD90", VA = "0x182B1D390")]
		internal ReadOnlyIdArray(ReadOnlyArray<T> array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x77E03E0", Offset = "0x77DEDE0", VA = "0x1877E03E0")]
		public static ReadOnlyIdArray<M, T> Empty()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x507DC10", Offset = "0x507C610", VA = "0x18507DC10")]
		public IEnumerable<T> QGYXVPSWMAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
		public ReadOnlyArray<T> SNYDRGOSJGH()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x77E0E80", Offset = "0x77DF880", VA = "0x1877E0E80")]
		public ReadOnlySpan<T> TIUNFNFIHFI()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x77E0310", Offset = "0x77DED10", VA = "0x1877E0310")]
		public bool ADQOMBJOKFP(Id32<M> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x77E06C0", Offset = "0x77DF0C0", VA = "0x1877E06C0")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> KCHPSGHADWZ()
		{
			return default(ConstEnumerable<T, ReadOnlyArray<T>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x77E0570", Offset = "0x77DEF70", VA = "0x1877E0570")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x77E08F0", Offset = "0x77DF2F0", VA = "0x1877E08F0")]
		public T? MNWKCAEMOIB(Id32<M> id)
		{
			return (T?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77E1120", Offset = "0x77DFB20", VA = "0x1877E1120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class TNIJJXSWCFR<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4169DA0", Offset = "0x41687A0", VA = "0x184169DA0")]
		public static ReadOnlyIdArray<b, T> POQXTOXNHSF<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyIdArray<b, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4102810", Offset = "0x4101210", VA = "0x184102810")]
		public static ReadOnlyIdArray<b?, a?> VMUMLXGAOOD<a>(ReadOnlyArray<a> readOnlyArray)
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
			[Cpp2IlInjected.Address(RVA = "0x77E1720", Offset = "0x77E0120", VA = "0x1877E1720")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x152A0D0", Offset = "0x1528AD0", VA = "0x18152A0D0")]
		internal ReadOnlyIdSpan([In] ReadOnlySpan<T> readOnlySpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x77E1570", Offset = "0x77DFF70", VA = "0x1877E1570", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class MPFXVOINLAY<f>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x39BD090", Offset = "0x39BBA90", VA = "0x1839BD090")]
		public static ReadOnlyIdSpan<f?, d?> MOUPZKZRBJA<d>([In] ReadOnlySpan<d> readOnlySpan)
		{
			return default(ReadOnlyIdSpan<f, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x39BD0F0", Offset = "0x39BBAF0", VA = "0x1839BD0F0")]
		public static ReadOnlyIdSpan<f?, e?> NVXAIMCVQGM<e>([In] Span<e> span)
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
