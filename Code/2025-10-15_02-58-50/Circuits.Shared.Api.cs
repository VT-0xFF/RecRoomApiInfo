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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B0A490", Offset = "0x2B09290", VA = "0x182B0A490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B07690", Offset = "0x2B06490", VA = "0x182B07690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B08360", Offset = "0x2B07160", VA = "0x182B08360")]
		public CircuitsMtx4x4(float value00, float value10, float value20, float value30, float value01, float value11, float value21, float value31, float value02, float value12, float value22, float value32, float value03, float value13, float value23, float value33)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B07940", Offset = "0x2B06740", VA = "0x182B07940")]
		public static bool TRHVNHMHPTX([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B077E0", Offset = "0x2B065E0", VA = "0x182B077E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B07710", Offset = "0x2B06510", VA = "0x182B07710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B07A50", Offset = "0x2B06850", VA = "0x182B07A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B076B0", Offset = "0x2B064B0", VA = "0x182B076B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B07690", Offset = "0x2B06490", VA = "0x182B07690")]
		public CircuitsQuat(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B08870", Offset = "0x2B07670", VA = "0x182B08870")]
		public static CircuitsQuat New(float x, float y, float z, float w)
		{
			return default(CircuitsQuat);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B08890", Offset = "0x2B07690", VA = "0x182B08890")]
		public static bool TRHVNHMHPTX([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B08920", Offset = "0x2B07720", VA = "0x182B08920")]
		public static bool VVLYKZHTTRM([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B085A0", Offset = "0x2B073A0", VA = "0x182B085A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B08410", Offset = "0x2B07210", VA = "0x182B08410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B088D0", Offset = "0x2B076D0", VA = "0x182B088D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B08600", Offset = "0x2B07400", VA = "0x182B08600")]
		public string KOYROKBXKQT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B08510", Offset = "0x2B07310", VA = "0x182B08510", Slot = "4")]
		public bool Equals(CircuitsQuat other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DTQUADOPCWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B09A70", Offset = "0x2B08870", VA = "0x182B09A70")]
		public static EQTZPTSQUTC HPFTFJWMZQX([In] this CircuitsQuat self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B099A0", Offset = "0x2B087A0", VA = "0x182B099A0")]
		public static CircuitsQuat CLFJUUWNTXI(this EQTZPTSQUTC a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B09C10", Offset = "0x2B08A10", VA = "0x182B09C10")]
		public static EQTZPTSQUTC? YEMYFMOPVPA([In] this CircuitsQuat? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B09AF0", Offset = "0x2B088F0", VA = "0x182B09AF0")]
		public static CircuitsQuat? XDRKQRPYWXR(this EQTZPTSQUTC? a)
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
		[Cpp2IlInjected.Address(RVA = "0x2B08EB0", Offset = "0x2B07CB0", VA = "0x182B08EB0")]
		public CircuitsRigidTransform([In] CircuitsQuat rotation, [In] CircuitsVec3 position)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B08C80", Offset = "0x2B07A80", VA = "0x182B08C80")]
		public static bool TRHVNHMHPTX([In] CircuitsRigidTransform lhs, [In] CircuitsRigidTransform rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B08B80", Offset = "0x2B07980", VA = "0x182B08B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B08AC0", Offset = "0x2B078C0", VA = "0x182B08AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B08D60", Offset = "0x2B07B60", VA = "0x182B08D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B08A60", Offset = "0x2B07860", VA = "0x182B08A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B09990", Offset = "0x2B08790", VA = "0x182B09990")]
		public CircuitsVec3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B09510", Offset = "0x2B08310", VA = "0x182B09510")]
		public static CircuitsVec3 New(float x, float y, float z)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B09530", Offset = "0x2B08330", VA = "0x182B09530")]
		public static bool TRHVNHMHPTX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B09690", Offset = "0x2B08490", VA = "0x182B09690")]
		public static bool VVLYKZHTTRM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B08ED0", Offset = "0x2B07CD0", VA = "0x182B08ED0")]
		public static CircuitsVec3 CLLEOMDRUNH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B09430", Offset = "0x2B08230", VA = "0x182B09430")]
		public static CircuitsVec3 LKLBGDTMESF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B095B0", Offset = "0x2B083B0", VA = "0x182B095B0")]
		public static CircuitsVec3 UAHREKDKSAF([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B09150", Offset = "0x2B07F50", VA = "0x182B09150")]
		public static CircuitsVec3 JPNASYGBUOK([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B09100", Offset = "0x2B07F00", VA = "0x182B09100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B08FB0", Offset = "0x2B07DB0", VA = "0x182B08FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B09560", Offset = "0x2B08360", VA = "0x182B09560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B09220", Offset = "0x2B08020", VA = "0x182B09220")]
		public string KOYROKBXKQT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B09080", Offset = "0x2B07E80", VA = "0x182B09080", Slot = "4")]
		public bool Equals(CircuitsVec3 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class CLNXXBCAUCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B07430", Offset = "0x2B06230", VA = "0x182B07430")]
		public static LNQFZYTISWE HPFTFJWMZQX([In] this CircuitsVec3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B07390", Offset = "0x2B06190", VA = "0x182B07390")]
		public static CircuitsVec3 CLFJUUWNTXI(this LNQFZYTISWE a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B07570", Offset = "0x2B06370", VA = "0x182B07570")]
		public static LNQFZYTISWE? YEMYFMOPVPA([In] this CircuitsVec3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B074A0", Offset = "0x2B062A0", VA = "0x182B074A0")]
		public static CircuitsVec3? XDRKQRPYWXR(this LNQFZYTISWE? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IAFQQJCFIIQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IAFQQJCFIIQ SMOJGMTZJOC(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IAFQQJCFIIQ CVJOVUFXROJ(string a, string[] b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IAFQQJCFIIQ BOSXNBAHSGV();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PKVJCOOHHUA();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface RKOCWUGHZBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IAFQQJCFIIQ YNAIRBCLZEU(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface WPOMOYRBFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? KMKPNWBEWZL(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct Id128<TMarker> : IEquatable<Id128<TMarker>>, IWKTMLXEDYU<Id128<TMarker>>, IComparable<Id128<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Id128<TMarker> ADQZGMDDDFW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x51F0BC0", Offset = "0x51EF9C0", VA = "0x1851F0BC0")]
			get
			{
				return default(Id128<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public Id128([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x51F16E0", Offset = "0x51F04E0", VA = "0x1851F16E0")]
		public static Id128<TMarker> VQFTFBJTWGI()
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x51F1030", Offset = "0x51EFE30", VA = "0x1851F1030")]
		public static Id128<TMarker> IHXEHVYEADY(string a)
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x51F0E00", Offset = "0x51EFC00", VA = "0x1851F0E00")]
		public QKDLCGRMYRZ? HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51F14B0", Offset = "0x51F02B0", VA = "0x1851F14B0")]
		public QKDLCGRMYRZ URTFNAETIAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public bool JECCPMWTKQN([In] Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x51F0AF0", Offset = "0x51EF8F0", VA = "0x1851F0AF0", Slot = "4")]
		public bool Equals(Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51F0AB0", Offset = "0x51EF8B0", VA = "0x1851F0AB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "6")]
		public int CompareTo(Id128<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51F0AF0", Offset = "0x51EF8F0", VA = "0x1851F0AF0")]
		public static bool TRHVNHMHPTX([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x51F17D0", Offset = "0x51F05D0", VA = "0x1851F17D0")]
		public static bool VVLYKZHTTRM([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51F1240", Offset = "0x51F0040", VA = "0x1851F1240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51F0AF0", Offset = "0x51EF8F0", VA = "0x1851F0AF0", Slot = "5")]
		private bool LBMBWRSMZIR([In] Id128<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WQTTAWTIUSH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E988C0", Offset = "0x3E976C0", VA = "0x183E988C0")]
		public static Id128<a?> CLFJUUWNTXI<a>(this QKDLCGRMYRZ? a)
		{
			return default(Id128<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B10", Offset = "0x3E97910", VA = "0x183E98B10")]
		public static Id128<TMarker> TCHDXNLVVHA<TMarker>(this QKDLCGRMYRZ a) where TMarker : notnull
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E989D0", Offset = "0x3E977D0", VA = "0x183E989D0")]
		public static Id128<b?> DIFQLVGULMS<b>([In] this Guid self)
		{
			return default(Id128<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AXBOZHNGKDT<b>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal static readonly Id128<b> ADQZGMDDDFW;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal static readonly Id128<b>? NTBCSZPOKHE;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct Id32<TMarker> : IEquatable<Id32<TMarker>>, IWKTMLXEDYU<Id32<TMarker>>, IComparable<Id32<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly int Int32;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<TMarker> XYTCBKNEVMS
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x51F1FD0", Offset = "0x51F0DD0", VA = "0x1851F1FD0")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<TMarker> VSWGDISKUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x51F1D40", Offset = "0x51F0B40", VA = "0x1851F1D40")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
		public Id32(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3A60A90", Offset = "0x3A5F890", VA = "0x183A60A90")]
		public Id32<a> RDNVFCCRLMI<a>() where a : TMarker
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
		public int HPFTFJWMZQX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51F1F50", Offset = "0x51F0D50", VA = "0x1851F1F50")]
		public bool JECCPMWTKQN([In] Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x51F1DF0", Offset = "0x51F0BF0", VA = "0x1851F1DF0", Slot = "4")]
		public bool Equals(Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x51F1F10", Offset = "0x51F0D10", VA = "0x1851F1F10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x255E0F0", Offset = "0x255CEF0", VA = "0x18255E0F0", Slot = "6")]
		public int CompareTo(Id32<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x51F2010", Offset = "0x51F0E10", VA = "0x1851F2010")]
		public static bool TRHVNHMHPTX(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x51F22D0", Offset = "0x51F10D0", VA = "0x1851F22D0")]
		public static bool VVLYKZHTTRM(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1641F60", Offset = "0x1640D60", VA = "0x181641F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51F2190", Offset = "0x51F0F90", VA = "0x1851F2190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x51F1C70", Offset = "0x51F0A70", VA = "0x1851F1C70")]
		public string DXEHTLESBAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x51F2310", Offset = "0x51F1110", VA = "0x1851F2310", Slot = "5")]
		private bool XXGCQFHPKSB([In] Id32<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class EHNMQTUVUJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x11604C0", Offset = "0x115F2C0", VA = "0x1811604C0")]
		public static Id32<a?> DIFQLVGULMS<a>(this int a)
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x11604C0", Offset = "0x115F2C0", VA = "0x1811604C0")]
		public static Id32<b?> CGUCKDFNCWG<b>(this int a)
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3805380", Offset = "0x3804180", VA = "0x183805380")]
		public static CopyEnumerable<Id32<c?>, Id32RangeEnumerator<c?>> HADKHETFKSQ<c>(Id32<c> startInclusive, Id32<c> endExclusive)
		{
			return default(CopyEnumerable<Id32<c>, Id32RangeEnumerator<c>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3805500", Offset = "0x3804300", VA = "0x183805500")]
		public static CopyEnumerable<Id32<d?>, Id32RangeEnumerator<d?>> TQCSVQAAGFU<d>(this Id32<d> endExclusive)
		{
			return default(CopyEnumerable<Id32<d>, Id32RangeEnumerator<d>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3805440", Offset = "0x3804240", VA = "0x183805440")]
		public static Id32<TMarker?> Offset<TMarker>(this Id32<TMarker> self, int offset)
		{
			return default(Id32<TMarker>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class PYGHXPZKKBP<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3C13470", Offset = "0x3C12270", VA = "0x183C13470")]
		public static Id32<b> VYHBHFQKFTX<a>(Id32<a> self) where a : b
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
			[Cpp2IlInjected.Address(RVA = "0x51F1900", Offset = "0x51F0700", VA = "0x1851F1900", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private readonly object SQVTSFKREWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x51F1830", Offset = "0x51F0630", VA = "0x1851F1830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		private Id32Enumerator(int count, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x51F18D0", Offset = "0x51F06D0", VA = "0x1851F18D0")]
		public static Id32Enumerator<M> YNRHSHSAAGG(int a)
		{
			return default(Id32Enumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51F1820", Offset = "0x51F0620", VA = "0x1851F1820", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51F18C0", Offset = "0x51F06C0", VA = "0x1851F18C0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class CQHDSMIMHZH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x36F0900", Offset = "0x36EF700", VA = "0x1836F0900")]
		public static Id32Enumerator<a?> BDTONIVQPDB<a>(Id32<a> afterLast)
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
			[Cpp2IlInjected.Address(RVA = "0x51F1B60", Offset = "0x51F0960", VA = "0x1851F1B60", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private readonly object SQVTSFKREWF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x51F19C0", Offset = "0x51F07C0", VA = "0x1851F19C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xF2B010", Offset = "0xF29E10", VA = "0x180F2B010")]
		internal Id32RangeEnumerator(int startExclusive, int endExclusive, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x51F19B0", Offset = "0x51F07B0", VA = "0x1851F19B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x51F1AE0", Offset = "0x51F08E0", VA = "0x1851F1AE0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class CVFJWPVCPQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3736EA0", Offset = "0x3735CA0", VA = "0x183736EA0")]
		public static Id32RangeEnumerator<M?> New<M>(Id32<M> startInclusive, Id32<M> endExclusive)
		{
			return default(Id32RangeEnumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3736DC0", Offset = "0x3735BC0", VA = "0x183736DC0")]
		public static CopyEnumerable<Id32<a?>, Id32RangeEnumerator<a?>> EXIZBIUWGNH<a>(Id32<a> startInclusive, Id32<a> endExclusive)
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
		public Id32<M> PKVJCOOHHUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x51F2480", Offset = "0x51F1280", VA = "0x1851F2480")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int WKYILYEQKLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B13210", Offset = "0x2B12010", VA = "0x182B13210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3B03590", Offset = "0x3B02390", VA = "0x183B03590")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		internal IdArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x51F27A0", Offset = "0x51F15A0", VA = "0x1851F27A0")]
		public static IdArray<M, T> New(int length)
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x51F24F0", Offset = "0x51F12F0", VA = "0x1851F24F0")]
		public static IdArray<M, T> Empty()
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xBB6870", Offset = "0xBB5670", VA = "0x180BB6870")]
		public IEnumerable<T> SCQZFKNOVSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x51F28D0", Offset = "0x51F16D0", VA = "0x1851F28D0")]
		public IdSpan<M, T> QSBPOSUVAGK()
		{
			return default(IdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x51F2820", Offset = "0x51F1620", VA = "0x1851F2820")]
		public ReadOnlyIdArray<M, T> PHVXPVARQBX()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x51F2660", Offset = "0x51F1460", VA = "0x1851F2660")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x51F2D00", Offset = "0x51F1B00", VA = "0x1851F2D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NUHXQESKJTW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x36DD400", Offset = "0x36DC200", VA = "0x1836DD400")]
		public static IdArray<a, T> OBGKTEPPBAM<T>(params T[] array) where T : notnull
		{
			return default(IdArray<a, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class XECHPEKFXOT
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B07520", Offset = "0x3B06320", VA = "0x183B07520")]
		public static b? DFGZTYJBBFL<b, a>(this IdArray<a, b> self, Id32<a> i)
		{
			return (b?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3B03590", Offset = "0x3B02390", VA = "0x183B03590")]
		public static d? ALLBMPGAGHP<d, c>(this IdArray<c, d> self, Id32<c> i)
		{
			return (d?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3B190D0", Offset = "0x3B17ED0", VA = "0x183B190D0")]
		public static void Set<M, T>(this IdArray<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B08BE0", Offset = "0x3B079E0", VA = "0x183B08BE0")]
		public static void MDXIXRKSDYR<i, j>(this IdArray<i, j> self, Id32<i> i, j value)
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
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		internal IdSpan([In] Span<T> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public readonly Span<T> EZTBBKVSXAT()
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x51F3DE0", Offset = "0x51F2BE0", VA = "0x1851F3DE0")]
		public readonly ReadOnlyIdSpan<M, T> WMUBBYTBTKU()
		{
			return default(ReadOnlyIdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x51F3AA0", Offset = "0x51F28A0", VA = "0x1851F3AA0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class WKCZQTMOPPD<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x32C2490", Offset = "0x32C1290", VA = "0x1832C2490")]
		public static IdSpan<c?, b?> GHZPECVGBCP<b>([In] Span<b> span)
		{
			return default(IdSpan<c, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class WDNXSYIZFNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3E953B0", Offset = "0x3E941B0", VA = "0x183E953B0")]
		public static void Set<M, T>([In] this IdSpan<M, T> self, Id32<M> i, [In] T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface GJSQFSXWHJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float ERDBREJALWK([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float DQAHJGBRPYG([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitsColor KHDPQULHEOH([In] CircuitsColor a, [In] CircuitsColor b, float a);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float SPDVHNKXCUT([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CircuitsVec3 IEJDLLDXBIZ([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CircuitsQuat TJAUDMTEAEA([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitsMtx4x4 AKQTNFQYQWC([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CircuitsMtx4x4 ZYFIVKTQAFU([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CircuitsMtx4x4 ICXAQXVNMCK([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		float OSFUIVCEAUH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CircuitsQuat ZVHJXJUTZOO(float a, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		CircuitsQuat HNEFCZGVHZH([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		CircuitsQuat WBRAHOFYDKT([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CircuitsQuat TKTLFMMZVEB([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CircuitsQuat JXSLWETFTRW([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CircuitsQuat HDLYHDPVVAV([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CircuitsQuat IDIGWVBMCVK([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float ZHLOLCZMXVP([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CircuitsQuat ATXPQXBAZWI([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		CircuitsQuat JCOKEFXWUTV([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CircuitsQuat SLZUJNYUEIF([In] CircuitsQuat from, [In] CircuitsQuat to, float a);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CircuitsVec3 HMGMGOTHEWA([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		CircuitsQuat RMPPHJXLJSE([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void KWPCGHXAYTP([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		CircuitsVec3 KZJLNPTIEVY([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CircuitsVec3 MSWCTSZGWCH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		CircuitsVec3 ABGKUHELPTZ([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		CircuitsVec3 DBDQGQKFEYQ([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		CircuitsVec3 JJDAQFBBGRO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		CircuitsVec3 JRYTSUWHWQM([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		CircuitsVec3 YCKVMKTVHQU([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		float FSRWACXZDML([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		float EMZCIIWWGDN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		float GWJYZJCVHTY([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		CircuitsVec3 ATBNDRSTJMV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		CircuitsVec3 RNUPLAHKBYY([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		float UQFMFPMALGN([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		CircuitsVec3 VNEOLDFPOWD([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		CircuitsVec3 NHOTSTSAWAC([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		CircuitsVec3 BKPRDMNETUX([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CircuitsVec3 VRNRKNREQBL([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		CircuitsVec3 IMICHVMBBQW([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		CircuitsVec3 EYIOCCBKIGW([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		CircuitsVec3 YHHBSGUQZZC([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		CircuitsVec3 EAKMTXUKKIE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		CircuitsVec3 COXIMTSDYLG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task THHBFCVNSRS(Func<Task> a);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void NWODIZSCJII([Optional] string? a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		RSUANDFJWHW DYHVPDQGJBA();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		RSUANDFJWHW RPEXFJNMMWP();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		float OWEWNXAEKFL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class JILPICJYVEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B09CC0", Offset = "0x2B08AC0", VA = "0x182B09CC0")]
		public static CircuitsRigidTransform FUQBNJKTROD(this GJSQFSXWHJY a, [In] CircuitsRigidTransform rigidTransform, [In] CircuitsMtx4x4 transform)
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
	public interface VITTVEGHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool QFWAQTPWMJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface LCSAJRMLRRQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		VITTVEGHMGL SSANEMPSJGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class CBZKMJZGYNV
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x36DCBF0", Offset = "0x36DB9F0", VA = "0x1836DCBF0")]
		public static bool EJNXNUGEGVR<TSelf>(this TSelf a) where TSelf : notnull, LCSAJRMLRRQ
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
		[Cpp2IlInjected.Address(RVA = "0x2B0A040", Offset = "0x2B08E40", VA = "0x182B0A040")]
		public LogDeps([In] LogDelegates @default, [In] LogDelegates debug, [In] LogDelegates circuitsV2CloudData, [In] LogDelegates circuitsV2DebugLogNode, [In] LogDelegates circuitsV2Environments, [In] LogDelegates circuitsV2EventBus, [In] LogDelegates circuitsV2Graph, [In] LogDelegates circuitsV2Heat, [In] LogDelegates circuitsV2Memory, [In] LogDelegates circuitsV2RecRoomIntegration, [In] LogDelegates circuitsV2Reduce, [In] LogDelegates circuitsV2Root, [In] LogDelegates circuitsV2State, [In] LogDelegates circuitsV2CloudDataOrMemory, [In] LogDelegates defaultOrCircuitsV2DebugLogNode, [In] LogDelegates circuitsV2Stopwatches, [In] LogDelegates circuitsV2VerboseStopwatches)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class VCZWSUVCRXV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HJVJIQEFSCR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BSPEMJYUXAE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class MTKWVKXUIVO<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class VHIMMWYWAFQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class CJHMTIIQUWA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ReadOnlyIdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ReadOnlyArray<T> _array;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<M> PKVJCOOHHUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5EFE160", Offset = "0x5EFCF60", VA = "0x185EFE160")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int WKYILYEQKLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5EFEC10", Offset = "0x5EFDA10", VA = "0x185EFEC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5EFF030", Offset = "0x5EFDE30", VA = "0x185EFF030")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC58F0", Offset = "0x2AC46F0", VA = "0x182AC58F0")]
		internal ReadOnlyIdArray(ReadOnlyArray<T> array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE2C0", Offset = "0x5EFD0C0", VA = "0x185EFE2C0")]
		public static ReadOnlyIdArray<M, T> Empty()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7F40", Offset = "0x3FD6D40", VA = "0x183FD7F40")]
		public IEnumerable<T> SCQZFKNOVSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xBB6870", Offset = "0xBB5670", VA = "0x180BB6870")]
		public ReadOnlyArray<T> DSLTOYTEPOC()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEED0", Offset = "0x5EFDCD0", VA = "0x185EFEED0")]
		public ReadOnlySpan<T> WENFXHJUWAN()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE1F0", Offset = "0x5EFCFF0", VA = "0x185EFE1F0")]
		public bool DXJXVEGWUAG(Id32<M> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE070", Offset = "0x5EFCE70", VA = "0x185EFE070")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> BKUSXJMHCOO()
		{
			return default(ConstEnumerable<T, ReadOnlyArray<T>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAF0", Offset = "0x5EFD8F0", VA = "0x185EFEAF0")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE6C0", Offset = "0x5EFD4C0", VA = "0x185EFE6C0")]
		public T? GTEYQAHKKDG(Id32<M> id)
		{
			return (T?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEE10", Offset = "0x5EFDC10", VA = "0x185EFEE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class GVQJRGZOODU<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3923750", Offset = "0x3922550", VA = "0x183923750")]
		public static ReadOnlyIdArray<b, T> OBGKTEPPBAM<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyIdArray<b, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3923710", Offset = "0x3922510", VA = "0x183923710")]
		public static ReadOnlyIdArray<b?, a?> KIQLIGOARIO<a>(ReadOnlyArray<a> readOnlyArray)
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
			[Cpp2IlInjected.Address(RVA = "0x5EFF420", Offset = "0x5EFE220", VA = "0x185EFF420")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		internal ReadOnlyIdSpan([In] ReadOnlySpan<T> readOnlySpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EFF270", Offset = "0x5EFE070", VA = "0x185EFF270", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ZTBZGGNJVZV<f>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x32C2490", Offset = "0x32C1290", VA = "0x1832C2490")]
		public static ReadOnlyIdSpan<f?, d?> IMGPUMSLDPD<d>([In] ReadOnlySpan<d> readOnlySpan)
		{
			return default(ReadOnlyIdSpan<f, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x32C2380", Offset = "0x32C1180", VA = "0x1832C2380")]
		public static ReadOnlyIdSpan<f?, e?> GHZPECVGBCP<e>([In] Span<e> span)
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
