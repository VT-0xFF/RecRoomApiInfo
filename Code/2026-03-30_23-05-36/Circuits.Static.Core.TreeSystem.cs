using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Core.TreeSystem.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2959710", Offset = "0x2958510", VA = "0x182959710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TreeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PathToRootEnumerator<TMNode> : IEnumerator<Id32<TMNode>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Id32<TMNode> _start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly SOAField<TMNode, Id32<TMNode>> _parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Id32<TMNode> _current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _started;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<TMNode> Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260", Slot = "4")]
			get
			{
				return default(Id32<TMNode>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object UUTAULZFDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5C8BC50", Offset = "0x5C8AA50", VA = "0x185C8BC50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BCC0", Offset = "0x5C8AAC0", VA = "0x185C8BCC0")]
		internal PathToRootEnumerator(Id32<TMNode> start, [In] SOAField<TMNode, Id32<TMNode>> parents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B990", Offset = "0x5C8A790", VA = "0x185C8B990", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C8BCB0", Offset = "0x5C8AAB0", VA = "0x185C8BCB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct TreeSys<TMNode>
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal static readonly Id32<TMNode> _noParentId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal SOAId32<TMNode> _ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal SOAField<TMNode, Id32<TMNode>> _parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal SOAField<TMNode, UnsafeList<Id32<TMNode>>> _children;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2956530", Offset = "0x2955330", VA = "0x182956530")]
		internal TreeSys([In] SOAId32<TMNode> ids, [In] SOAField<TMNode, Id32<TMNode>> parents, [In] SOAField<TMNode, UnsafeList<Id32<TMNode>>> children)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6327D20", Offset = "0x6326B20", VA = "0x186327D20")]
		public static TreeSys<TMNode> New()
		{
			return default(TreeSys<TMNode>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XIRYMBLNDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B810", Offset = "0x3C9A610", VA = "0x183C9B810")]
		public static QHDUUGFFUPL ZLPVCWRAQLQ<TMNode>([In] this TreeSys<TMNode> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C99C60", Offset = "0x3C98A60", VA = "0x183C99C60")]
		internal static MGTUPKPRHKD IPGPRGRFHSN<TMNode>([In] this UnsafeList<Id32<TMNode>> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A160", Offset = "0x3C98F60", VA = "0x183C9A160")]
		internal static UnsafeList<Id32<TMNode>> MCCEFYQCCWE<TMNode>(this MGTUPKPRHKD a) where TMNode : notnull
		{
			return default(UnsafeList<Id32<TMNode>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C994D0", Offset = "0x3C982D0", VA = "0x183C994D0")]
		public static void Destroy<TMNode>(this TreeSys<TMNode> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A5B0", Offset = "0x3C993B0", VA = "0x183C9A5B0")]
		public static bool OVIYGFEMXGQ<a>([In] this TreeSys<a> self, Id32<a> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C99680", Offset = "0x3C98480", VA = "0x183C99680")]
		public static int FGROZFJNYWX<b>([In] this TreeSys<b> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A4C0", Offset = "0x3C992C0", VA = "0x183C9A4C0")]
		public static Id32<c?> OBGVUZKKGJT<c>(this TreeSys<c> self)
		{
			return default(Id32<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C999B0", Offset = "0x3C987B0", VA = "0x183C999B0")]
		public static Id32<d?> IBPLEGYETUF<d>(this TreeSys<d> self, Id32<d> parent)
		{
			return default(Id32<d>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A850", Offset = "0x3C99650", VA = "0x183C9A850")]
		public static void Release<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AEA0", Offset = "0x3C99CA0", VA = "0x183C9AEA0")]
		public static bool SBOVGFLTFVC<e>([In] this TreeSys<e> self, Id32<e> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C99EB0", Offset = "0x3C98CB0", VA = "0x183C99EB0")]
		public static Id32<f?> LEBYICOYHAA<f>([In] this TreeSys<f> self, Id32<f> id)
		{
			return default(Id32<f>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C997E0", Offset = "0x3C985E0", VA = "0x183C997E0")]
		public static Id32<TMNode?>? GetParentOrNull<TMNode>([In] this TreeSys<TMNode> self, Id32<TMNode> id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AC60", Offset = "0x3C99A60", VA = "0x183C9AC60")]
		public static void Reparent<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id, Id32<TMNode> newParentId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B390", Offset = "0x3C9A190", VA = "0x183C9B390")]
		public static ConstEnumerable<Id32<j?>, UnsafeList<Id32<j?>>.Enumerator> VMSOUMYZCHS<j>([In] this TreeSys<j> self, Id32<j> id)
		{
			return default(ConstEnumerable<Id32<j>, UnsafeList<Id32<j>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650")]
		public static SOAId32<k?> QSBSQJNLDNY<k>([In] this TreeSys<k> self)
		{
			return default(SOAId32<k>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35147F0", Offset = "0x35135F0", VA = "0x1835147F0")]
		public static SOAId32<TMNode?>.Enumerator GetEnumerator<TMNode>([In] this TreeSys<TMNode> self)
		{
			return default(SOAId32<TMNode>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3514C10", Offset = "0x3513A10", VA = "0x183514C10")]
		public static CopyEnumerable<Id32<l?>, SOAId32<l?>.Enumerator> SMGAATHTNYC<l>([In] this TreeSys<l> self)
		{
			return default(CopyEnumerable<Id32<l>, SOAId32<l>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B040", Offset = "0x3C99E40", VA = "0x183C9B040")]
		public static bool TZYDTZMEYIZ<m>([In] this TreeSys<m> self, Id32<m> node, Id32<m> possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B260", Offset = "0x3C9A060", VA = "0x183C9B260")]
		public static CopyEnumerable<Id32<n?>, PathToRootEnumerator<n?>> UKXDVCLPYNA<n>([In] this TreeSys<n> self, Id32<n> node)
		{
			return default(CopyEnumerable<Id32<n>, PathToRootEnumerator<n>>);
		}
	}
}
namespace Circuits.Static.Core.TreeSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class QYUTKTAGKQY
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A11BD0", Offset = "0x3A109D0", VA = "0x183A11BD0")]
		public static TreeSys<TMNode> LNQLBTCFZPN<TMNode>(this QHDUUGFFUPL a) where TMNode : notnull
		{
			return default(TreeSys<TMNode>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2959790", Offset = "0x2958590", VA = "0x182959790")]
		public static void Release(this QHDUUGFFUPL self, int id)
		{
		}
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
