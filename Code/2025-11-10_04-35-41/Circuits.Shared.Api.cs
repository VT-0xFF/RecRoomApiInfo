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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2866AB0", Offset = "0x2865EB0", VA = "0x182866AB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x28643A0", Offset = "0x28637A0", VA = "0x1828643A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2865070", Offset = "0x2864470", VA = "0x182865070")]
		public CircuitsMtx4x4(float value00, float value10, float value20, float value30, float value01, float value11, float value21, float value31, float value02, float value12, float value22, float value32, float value03, float value13, float value23, float value33)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2864ED0", Offset = "0x28642D0", VA = "0x182864ED0")]
		public static bool ZWISVWGZSLY([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28644F0", Offset = "0x28638F0", VA = "0x1828644F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2864420", Offset = "0x2863820", VA = "0x182864420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2864650", Offset = "0x2863A50", VA = "0x182864650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28643C0", Offset = "0x28637C0", VA = "0x1828643C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x28643A0", Offset = "0x28637A0", VA = "0x1828643A0")]
		public CircuitsQuat(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2865310", Offset = "0x2864710", VA = "0x182865310")]
		public static CircuitsQuat New(float x, float y, float z, float w)
		{
			return default(CircuitsQuat);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2865680", Offset = "0x2864A80", VA = "0x182865680")]
		public static bool ZWISVWGZSLY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28655F0", Offset = "0x28649F0", VA = "0x1828655F0")]
		public static bool ZPGHGHNXRJT([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28652B0", Offset = "0x28646B0", VA = "0x1828652B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2865120", Offset = "0x2864520", VA = "0x182865120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2865330", Offset = "0x2864730", VA = "0x182865330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2865380", Offset = "0x2864780", VA = "0x182865380")]
		public string XHULETXXDPM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2865220", Offset = "0x2864620", VA = "0x182865220", Slot = "4")]
		public bool Equals(CircuitsQuat other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class YKHHXHOEFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2867240", Offset = "0x2866640", VA = "0x182867240")]
		public static HZHTAVTSSEV CQVTSUWTJSM([In] this CircuitsQuat self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28672C0", Offset = "0x28666C0", VA = "0x1828672C0")]
		public static CircuitsQuat FLGKTDORRZX(this HZHTAVTSSEV a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2867390", Offset = "0x2866790", VA = "0x182867390")]
		public static HZHTAVTSSEV? HAEQWLTITHX([In] this CircuitsQuat? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2867120", Offset = "0x2866520", VA = "0x182867120")]
		public static CircuitsQuat? CIKQACMRCZK(this HZHTAVTSSEV? a)
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
		[Cpp2IlInjected.Address(RVA = "0x2865BA0", Offset = "0x2864FA0", VA = "0x182865BA0")]
		public CircuitsRigidTransform([In] CircuitsQuat rotation, [In] CircuitsVec3 position)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2865A20", Offset = "0x2864E20", VA = "0x182865A20")]
		public static bool ZWISVWGZSLY([In] CircuitsRigidTransform lhs, [In] CircuitsRigidTransform rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2865880", Offset = "0x2864C80", VA = "0x182865880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28657C0", Offset = "0x2864BC0", VA = "0x1828657C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2865980", Offset = "0x2864D80", VA = "0x182865980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2865760", Offset = "0x2864B60", VA = "0x182865760", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2866650", Offset = "0x2865A50", VA = "0x182866650")]
		public CircuitsVec3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2865FF0", Offset = "0x28653F0", VA = "0x182865FF0")]
		public static CircuitsVec3 New(float x, float y, float z)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28663D0", Offset = "0x28657D0", VA = "0x1828663D0")]
		public static bool ZWISVWGZSLY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2866350", Offset = "0x2865750", VA = "0x182866350")]
		public static bool ZPGHGHNXRJT([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2865BC0", Offset = "0x2864FC0", VA = "0x182865BC0")]
		public static CircuitsVec3 BWNDTZPGZAW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2866010", Offset = "0x2865410", VA = "0x182866010")]
		public static CircuitsVec3 QQCFMIEADJS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2865F10", Offset = "0x2865310", VA = "0x182865F10")]
		public static CircuitsVec3 IHFXLNCYKKG([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2865DF0", Offset = "0x28651F0", VA = "0x182865DF0")]
		public static CircuitsVec3 GAFHFCWCCND([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2865EC0", Offset = "0x28652C0", VA = "0x182865EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2865CA0", Offset = "0x28650A0", VA = "0x182865CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28660F0", Offset = "0x28654F0", VA = "0x1828660F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2866140", Offset = "0x2865540", VA = "0x182866140")]
		public string XHULETXXDPM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2865D70", Offset = "0x2865170", VA = "0x182865D70", Slot = "4")]
		public bool Equals(CircuitsVec3 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class UKLHGPTLFYW
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2866F50", Offset = "0x2866350", VA = "0x182866F50")]
		public static ZKAZBGIAWZT CQVTSUWTJSM([In] this CircuitsVec3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2866FC0", Offset = "0x28663C0", VA = "0x182866FC0")]
		public static CircuitsVec3 FLGKTDORRZX(this ZKAZBGIAWZT a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2867060", Offset = "0x2866460", VA = "0x182867060")]
		public static ZKAZBGIAWZT? HAEQWLTITHX([In] this CircuitsVec3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2866E80", Offset = "0x2866280", VA = "0x182866E80")]
		public static CircuitsVec3? CIKQACMRCZK(this ZKAZBGIAWZT? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface JUWRUXWLBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JUWRUXWLBDH FXGTGZNNVQN(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JUWRUXWLBDH CAPMJDSZAKE(string a, string[] b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JUWRUXWLBDH QDTWGNCGXHG();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EQHRYZKONUP();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IONTNODDBKQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JUWRUXWLBDH YEPRRGOHSQR(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface EXSBOVGLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? GKSJGBWDQPA(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct Id128<TMarker> : IEquatable<Id128<TMarker>>, XLJSAODWXND<Id128<TMarker>>, IComparable<Id128<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Id128<TMarker> XHOMZVKVVEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5030760", Offset = "0x502FB60", VA = "0x185030760")]
			get
			{
				return default(Id128<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x120B3B0", Offset = "0x120A7B0", VA = "0x18120B3B0")]
		public Id128([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5030360", Offset = "0x502F760", VA = "0x185030360")]
		public static Id128<TMarker> OHJMIWVLSAF()
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5030610", Offset = "0x502FA10", VA = "0x185030610")]
		public static Id128<TMarker> VGEAHQWEIVR(string a)
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x502FDC0", Offset = "0x502F1C0", VA = "0x18502FDC0")]
		public WIPQKVQJUBS? CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x502FAA0", Offset = "0x502EEA0", VA = "0x18502FAA0")]
		public WIPQKVQJUBS CKFIKLXDGOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5030730", Offset = "0x502FB30", VA = "0x185030730")]
		public bool XFFAACZDUDS([In] Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x50301D0", Offset = "0x502F5D0", VA = "0x1850301D0", Slot = "4")]
		public bool Equals(Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5030190", Offset = "0x502F590", VA = "0x185030190", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x50300E0", Offset = "0x502F4E0", VA = "0x1850300E0", Slot = "6")]
		public int CompareTo(Id128<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50301D0", Offset = "0x502F5D0", VA = "0x1850301D0")]
		public static bool ZWISVWGZSLY([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50307F0", Offset = "0x502FBF0", VA = "0x1850307F0")]
		public static bool ZPGHGHNXRJT([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50302A0", Offset = "0x502F6A0", VA = "0x1850302A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5030530", Offset = "0x502F930", VA = "0x185030530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50301D0", Offset = "0x502F5D0", VA = "0x1850301D0", Slot = "5")]
		private bool OJWZZFXJNJQ([In] Id128<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class NSHKHENYENK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x38247C0", Offset = "0x3823BC0", VA = "0x1838247C0")]
		public static Id128<a?> FLGKTDORRZX<a>(this WIPQKVQJUBS? a)
		{
			return default(Id128<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38245D0", Offset = "0x38239D0", VA = "0x1838245D0")]
		public static Id128<TMarker> CLDLVNLOQTV<TMarker>(this WIPQKVQJUBS a) where TMarker : notnull
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3824490", Offset = "0x3823890", VA = "0x183824490")]
		public static Id128<b?> AWYTSESJWZN<b>([In] this Guid self)
		{
			return default(Id128<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MZLWANFINKE<b>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal static readonly Id128<b> XHOMZVKVVEP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal static readonly Id128<b>? TIRUCKHSHJZ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct Id32<TMarker> : IEquatable<Id32<TMarker>>, XLJSAODWXND<Id32<TMarker>>, IComparable<Id32<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly int Int32;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<TMarker> PSAZZCEBCFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x50312B0", Offset = "0x50306B0", VA = "0x1850312B0")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<TMarker> HUNKQYVNABB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5031130", Offset = "0x5030530", VA = "0x185031130")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
		public Id32(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x35C6220", Offset = "0x35C5620", VA = "0x1835C6220")]
		public Id32<a> IUPPKCUYRVH<a>() where a : TMarker
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
		public int CQVTSUWTJSM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50312A0", Offset = "0x50306A0", VA = "0x1850312A0")]
		public bool XFFAACZDUDS([In] Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5030C70", Offset = "0x5030070", VA = "0x185030C70", Slot = "4")]
		public bool Equals(Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5030DB0", Offset = "0x50301B0", VA = "0x185030DB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5BA0", Offset = "0x1FE4FA0", VA = "0x181FE5BA0", Slot = "6")]
		public int CompareTo(Id32<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5031410", Offset = "0x5030810", VA = "0x185031410")]
		public static bool ZWISVWGZSLY(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50313D0", Offset = "0x50307D0", VA = "0x1850313D0")]
		public static bool ZPGHGHNXRJT(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12D6880", Offset = "0x12D5C80", VA = "0x1812D6880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5031060", Offset = "0x5030460", VA = "0x185031060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5030EC0", Offset = "0x50302C0", VA = "0x185030EC0")]
		public string MDOOEUPIKGV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50311E0", Offset = "0x50305E0", VA = "0x1850311E0", Slot = "5")]
		private bool VHFFHDZIFEI([In] Id32<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class RRIEOCZLURU
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xDC3BA0", Offset = "0xDC2FA0", VA = "0x180DC3BA0")]
		public static Id32<a?> AWYTSESJWZN<a>(this int a)
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xDC3BA0", Offset = "0xDC2FA0", VA = "0x180DC3BA0")]
		public static Id32<b?> UZEQTHTRXWJ<b>(this int a)
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x39A1880", Offset = "0x39A0C80", VA = "0x1839A1880")]
		public static CopyEnumerable<Id32<c?>, Id32RangeEnumerator<c?>> CVEXSPWVYBJ<c>(Id32<c> startInclusive, Id32<c> endExclusive)
		{
			return default(CopyEnumerable<Id32<c>, Id32RangeEnumerator<c>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x39A1960", Offset = "0x39A0D60", VA = "0x1839A1960")]
		public static CopyEnumerable<Id32<d?>, Id32RangeEnumerator<d?>> ECWUYGAITNL<d>(this Id32<d> endExclusive)
		{
			return default(CopyEnumerable<Id32<d>, Id32RangeEnumerator<d>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x39A1A20", Offset = "0x39A0E20", VA = "0x1839A1A20")]
		public static Id32<TMarker?> Offset<TMarker>(this Id32<TMarker> self, int offset)
		{
			return default(Id32<TMarker>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class UCRESNCDVIO<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC190", Offset = "0x3BBB590", VA = "0x183BBC190")]
		public static Id32<b> KUPUZGYOOOY<a>(Id32<a> self) where a : b
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
			[Cpp2IlInjected.Address(RVA = "0x50309C0", Offset = "0x502FDC0", VA = "0x1850309C0", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private readonly object MSIUOYXLJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5030920", Offset = "0x502FD20", VA = "0x185030920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		private Id32Enumerator(int count, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x50308D0", Offset = "0x502FCD0", VA = "0x1850308D0")]
		public static Id32Enumerator<M> AUPPZPGCJUV(int a)
		{
			return default(Id32Enumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5030910", Offset = "0x502FD10", VA = "0x185030910", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x50309B0", Offset = "0x502FDB0", VA = "0x1850309B0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class TFGOUPZCXAU
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4270", Offset = "0x3AA3670", VA = "0x183AA4270")]
		public static Id32Enumerator<a?> VPEOJODTDTO<a>(Id32<a> afterLast)
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
			[Cpp2IlInjected.Address(RVA = "0x5030C30", Offset = "0x5030030", VA = "0x185030C30", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private readonly object MSIUOYXLJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5030A80", Offset = "0x502FE80", VA = "0x185030A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBA79F0", Offset = "0xBA6DF0", VA = "0x180BA79F0")]
		internal Id32RangeEnumerator(int startExclusive, int endExclusive, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5030A70", Offset = "0x502FE70", VA = "0x185030A70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5030BB0", Offset = "0x502FFB0", VA = "0x185030BB0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PNNBWAOULIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x387C8B0", Offset = "0x387BCB0", VA = "0x18387C8B0")]
		public static Id32RangeEnumerator<M?> New<M>(Id32<M> startInclusive, Id32<M> endExclusive)
		{
			return default(Id32RangeEnumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x387C7D0", Offset = "0x387BBD0", VA = "0x18387C7D0")]
		public static CopyEnumerable<Id32<a?>, Id32RangeEnumerator<a?>> ITNHQZSSJCS<a>(Id32<a> startInclusive, Id32<a> endExclusive)
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
		public Id32<M> EQHRYZKONUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5031F70", Offset = "0x5031370", VA = "0x185031F70")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2870720", Offset = "0x286FB20", VA = "0x182870720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3C207A0", Offset = "0x3C1FBA0", VA = "0x183C207A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		internal IdArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5031C80", Offset = "0x5031080", VA = "0x185031C80")]
		public static IdArray<M, T> New(int length)
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5031580", Offset = "0x5030980", VA = "0x185031580")]
		public static IdArray<M, T> Empty()
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
		public IEnumerable<T> YIIYBOBUNJS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x50318A0", Offset = "0x5030CA0", VA = "0x1850318A0")]
		public IdSpan<M, T> GELSWRKUHVV()
		{
			return default(IdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x50314C0", Offset = "0x50308C0", VA = "0x1850314C0")]
		public ReadOnlyIdArray<M, T> CWZFWKOHBUO()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5031B40", Offset = "0x5030F40", VA = "0x185031B40")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5031D00", Offset = "0x5031100", VA = "0x185031D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class YCYTVIPIPGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3002660", Offset = "0x3001A60", VA = "0x183002660")]
		public static IdArray<a, T> FEAYBPRFWFJ<T>(params T[] array) where T : notnull
		{
			return default(IdArray<a, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class YXQKELUKGAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3C208E0", Offset = "0x3C1FCE0", VA = "0x183C208E0")]
		public static b? LCZHNBGFSCE<b, a>(this IdArray<a, b> self, Id32<a> i)
		{
			return (b?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C207A0", Offset = "0x3C1FBA0", VA = "0x183C207A0")]
		public static d? BOODFOMVPUA<d, c>(this IdArray<c, d> self, Id32<c> i)
		{
			return (d?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C20A20", Offset = "0x3C1FE20", VA = "0x183C20A20")]
		public static void Set<M, T>(this IdArray<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C20BB0", Offset = "0x3C1FFB0", VA = "0x183C20BB0")]
		public static void ZFUJWYXPJYQ<i, j>(this IdArray<i, j> self, Id32<i> i, j value)
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
		[Cpp2IlInjected.Address(RVA = "0x120B3B0", Offset = "0x120A7B0", VA = "0x18120B3B0")]
		internal IdSpan([In] Span<T> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xFB4270", Offset = "0xFB3670", VA = "0x180FB4270")]
		public readonly Span<T> ZJMBNJKFXPA()
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5032C10", Offset = "0x5032010", VA = "0x185032C10")]
		public readonly ReadOnlyIdSpan<M, T> JJVGIIWBXZP()
		{
			return default(ReadOnlyIdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5032CF0", Offset = "0x50320F0", VA = "0x185032CF0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class GTZCHDOJLQI<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x35C3780", Offset = "0x35C2B80", VA = "0x1835C3780")]
		public static IdSpan<c?, b?> HYURMBOVWKG<b>([In] Span<b> span)
		{
			return default(IdSpan<c, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class CCLUAQECLQL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x341B790", Offset = "0x341AB90", VA = "0x18341B790")]
		public static void Set<M, T>([In] this IdSpan<M, T> self, Id32<M> i, [In] T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface TNQBFZGPRNT
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float FEWHIVKBQUN([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float ORYDBIZYDZJ([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitsColor WQEVPSZFVYQ([In] CircuitsColor a, [In] CircuitsColor b, float a);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float YYYXSRTYEDY([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CircuitsVec3 IGGNQSAVFTU([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CircuitsQuat ADTOJOADHQX([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitsMtx4x4 DQJJYGXKKFP([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CircuitsMtx4x4 GHRCSKBKUPZ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CircuitsMtx4x4 UFBPMIRHJVZ([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		float YITIFXJLPRC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CircuitsQuat GHGDBJAWNXP(float a, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		CircuitsQuat ZJVMMWVCGDA([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		CircuitsQuat EDIUZAYFBQW([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CircuitsQuat JCNPGZFTJWE([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CircuitsQuat WPGFDZWWUBJ([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CircuitsQuat YOFOGRWEGRW([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CircuitsQuat YOEEYINSVFF([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float CYNUEDPWWSO([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CircuitsQuat GJAJNOTTTBX([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		CircuitsQuat RBLSXHJMANK([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CircuitsQuat UJLSMJVZXRM([In] CircuitsQuat from, [In] CircuitsQuat to, float a);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CircuitsVec3 AOIRFITVHEF([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		CircuitsQuat RIRWZGBYJML([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void TTRZVUBOAQK([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		CircuitsVec3 AOIAGCLDUGF([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CircuitsVec3 ILPQTJCQXFG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		CircuitsVec3 VAUQDSKLWUS([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		CircuitsVec3 NREYAAUKFDB([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		CircuitsVec3 AEYKTVPNRKL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		CircuitsVec3 YBGVCKBZJWT([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		CircuitsVec3 WECRXTNTLIB([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		float NSKNCRSRIBO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		float IBRBJPGIQIY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		float TYRRXZDQUCP([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		CircuitsVec3 CVTIRTUHRDO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		CircuitsVec3 DKLOJMHOSYT([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		float PRTGYIJZBMW([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		CircuitsVec3 FWMDLJYXBSI([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		CircuitsVec3 EBZVJOPFBBV([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		CircuitsVec3 VETWEEMHIMM([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CircuitsVec3 AGIXTRDRTLM([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		CircuitsVec3 KKDORVOVYAX([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		CircuitsVec3 DEGLLGLVDHH([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		CircuitsVec3 QCLQZNZMNRH([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		CircuitsVec3 TNZCOWYPCUJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		CircuitsVec3 RQTINMZALVJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task IGIBMXJMWZB(Func<Task> a);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void XRYJOUAMOVN([Optional] string? a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		KWWIFHUGOFY<PXOECLXUDAS> EMUXLWFJPNB();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		KWWIFHUGOFY<PXOECLXUDAS> UIFCBRMOBQK();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		float EUKRCUCPRNS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class PPSZQVRFYPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2866B30", Offset = "0x2865F30", VA = "0x182866B30")]
		public static CircuitsRigidTransform QLYIBAKUDGE(this TNQBFZGPRNT a, [In] CircuitsRigidTransform rigidTransform, [In] CircuitsMtx4x4 transform)
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
	public interface ZIDJAMSNONC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool PTDGGKWCEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface SFGLUSMFRGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ZIDJAMSNONC VTSDFFBTWFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class NKLFKLOVHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x38202A0", Offset = "0x381F6A0", VA = "0x1838202A0")]
		public static bool ZSJZJBDGUYW<TSelf>(this TSelf a) where TSelf : notnull, SFGLUSMFRGD
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
		[Cpp2IlInjected.Address(RVA = "0x2866660", Offset = "0x2865A60", VA = "0x182866660")]
		public LogDeps([In] LogDelegates @default, [In] LogDelegates debug, [In] LogDelegates circuitsV2CloudData, [In] LogDelegates circuitsV2DebugLogNode, [In] LogDelegates circuitsV2Environments, [In] LogDelegates circuitsV2EventBus, [In] LogDelegates circuitsV2Graph, [In] LogDelegates circuitsV2Heat, [In] LogDelegates circuitsV2Memory, [In] LogDelegates circuitsV2RecRoomIntegration, [In] LogDelegates circuitsV2Reduce, [In] LogDelegates circuitsV2Root, [In] LogDelegates circuitsV2State, [In] LogDelegates circuitsV2CloudDataOrMemory, [In] LogDelegates defaultOrCircuitsV2DebugLogNode, [In] LogDelegates circuitsV2Stopwatches, [In] LogDelegates circuitsV2VerboseStopwatches)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FJSVDCFYEAW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IZXQRWKUWLU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class TVYIBYSHUKT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class IMFYYDLBECV<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NTOQNIRTTPF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class FVPAIKKPAFL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ReadOnlyIdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ReadOnlyArray<T> _array;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<M> EQHRYZKONUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5CC7C50", Offset = "0x5CC7050", VA = "0x185CC7C50")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5CC6F90", Offset = "0x5CC6390", VA = "0x185CC6F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5CC7D60", Offset = "0x5CC7160", VA = "0x185CC7D60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x281DB50", Offset = "0x281CF50", VA = "0x18281DB50")]
		internal ReadOnlyIdArray(ReadOnlyArray<T> array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6D40", Offset = "0x5CC6140", VA = "0x185CC6D40")]
		public static ReadOnlyIdArray<M, T> Empty()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5260", Offset = "0x3CE4660", VA = "0x183CE5260")]
		public IEnumerable<T> YIIYBOBUNJS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
		public ReadOnlyArray<T> KMPNEQCGTCJ()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7B00", Offset = "0x5CC6F00", VA = "0x185CC7B00")]
		public ReadOnlySpan<T> XXAVRHORTYY()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7340", Offset = "0x5CC6740", VA = "0x185CC7340")]
		public bool UQSOMDABLOL(Id32<M> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6FD0", Offset = "0x5CC63D0", VA = "0x185CC6FD0")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> SDMUYTIWQSD()
		{
			return default(ConstEnumerable<T, ReadOnlyArray<T>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6ED0", Offset = "0x5CC62D0", VA = "0x185CC6ED0")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7740", Offset = "0x5CC6B40", VA = "0x185CC7740")]
		public T? UTAJMDEYQEX(Id32<M> id)
		{
			return (T?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7280", Offset = "0x5CC6680", VA = "0x185CC7280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class AOCODOTELEN<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC140", Offset = "0x2FBB540", VA = "0x182FBC140")]
		public static ReadOnlyIdArray<b, T> FEAYBPRFWFJ<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyIdArray<b, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2FBC1F0", Offset = "0x2FBB5F0", VA = "0x182FBC1F0")]
		public static ReadOnlyIdArray<b?, a?> LHWLZMUGGFP<a>(ReadOnlyArray<a> readOnlyArray)
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
			[Cpp2IlInjected.Address(RVA = "0x5CC8150", Offset = "0x5CC7550", VA = "0x185CC8150")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x120B3B0", Offset = "0x120A7B0", VA = "0x18120B3B0")]
		internal ReadOnlyIdSpan([In] ReadOnlySpan<T> readOnlySpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7FA0", Offset = "0x5CC73A0", VA = "0x185CC7FA0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class JOYMNIYJBQC<f>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x35C3780", Offset = "0x35C2B80", VA = "0x1835C3780")]
		public static ReadOnlyIdSpan<f?, d?> ASTCBOOMVAI<d>([In] ReadOnlySpan<d> readOnlySpan)
		{
			return default(ReadOnlyIdSpan<f, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35C64F0", Offset = "0x35C58F0", VA = "0x1835C64F0")]
		public static ReadOnlyIdSpan<f?, e?> HYURMBOVWKG<e>([In] Span<e> span)
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
