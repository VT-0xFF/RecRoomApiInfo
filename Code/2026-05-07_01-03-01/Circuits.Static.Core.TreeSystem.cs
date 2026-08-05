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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9A1E0", Offset = "0x2B98BE0", VA = "0x182B9A1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "4")]
			get
			{
				return default(Id32<TMNode>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object KXFWSOWDLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x745EBB0", Offset = "0x745D5B0", VA = "0x18745EBB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x745ECC0", Offset = "0x745D6C0", VA = "0x18745ECC0")]
		internal PathToRootEnumerator(Id32<TMNode> start, [In] SOAField<TMNode, Id32<TMNode>> parents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x745E9A0", Offset = "0x745D3A0", VA = "0x18745E9A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x745ECB0", Offset = "0x745D6B0", VA = "0x18745ECB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B97030", Offset = "0x2B95A30", VA = "0x182B97030")]
		internal TreeSys([In] SOAId32<TMNode> ids, [In] SOAField<TMNode, Id32<TMNode>> parents, [In] SOAField<TMNode, UnsafeList<Id32<TMNode>>> children)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C960", Offset = "0x7C7B360", VA = "0x187C7C960")]
		public static TreeSys<TMNode> New()
		{
			return default(TreeSys<TMNode>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VURAXDEWJAR
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x40C35A0", Offset = "0x40C1FA0", VA = "0x1840C35A0")]
		public static QAIYWXYBASJ XQIXCNAGDPI<TMNode>([In] this TreeSys<TMNode> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40C2570", Offset = "0x40C0F70", VA = "0x1840C2570")]
		internal static KMEVAKECCAP PWHJCVJJMER<TMNode>([In] this UnsafeList<Id32<TMNode>> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x40C14C0", Offset = "0x40BFEC0", VA = "0x1840C14C0")]
		internal static UnsafeList<Id32<TMNode>> DYCZPQMACPW<TMNode>(this KMEVAKECCAP a) where TMNode : notnull
		{
			return default(UnsafeList<Id32<TMNode>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x40C1960", Offset = "0x40C0360", VA = "0x1840C1960")]
		public static void Destroy<TMNode>(this TreeSys<TMNode> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x40C3080", Offset = "0x40C1A80", VA = "0x1840C3080")]
		public static bool UBSLHYICGPG<a>([In] this TreeSys<a> self, Id32<a> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x40C1030", Offset = "0x40BFA30", VA = "0x1840C1030")]
		public static int APBHXPELCRV<b>([In] this TreeSys<b> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x40C1170", Offset = "0x40BFB70", VA = "0x1840C1170")]
		public static Id32<c?> CXQSWZJTCPT<c>(this TreeSys<c> self)
		{
			return default(Id32<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x40C22C0", Offset = "0x40C0CC0", VA = "0x1840C22C0")]
		public static Id32<d?> NJYWONXAEKB<d>(this TreeSys<d> self, Id32<d> parent)
		{
			return default(Id32<d>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40C2B20", Offset = "0x40C1520", VA = "0x1840C2B20")]
		public static void Release<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40C2820", Offset = "0x40C1220", VA = "0x1840C2820")]
		public static bool QXSCYEDOSSQ<e>([In] this TreeSys<e> self, Id32<e> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x40C3150", Offset = "0x40C1B50", VA = "0x1840C3150")]
		public static Id32<f?> VJFUNKCPWDC<f>([In] this TreeSys<f> self, Id32<f> id)
		{
			return default(Id32<f>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x40C1C30", Offset = "0x40C0630", VA = "0x1840C1C30")]
		public static Id32<TMNode?>? GetParentOrNull<TMNode>([In] this TreeSys<TMNode> self, Id32<TMNode> id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x40C2F20", Offset = "0x40C1920", VA = "0x1840C2F20")]
		public static void Reparent<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id, Id32<TMNode> newParentId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x40C2150", Offset = "0x40C0B50", VA = "0x1840C2150")]
		public static ConstEnumerable<Id32<j?>, UnsafeList<Id32<j?>>.Enumerator> NGPCAQIIQDW<j>([In] this TreeSys<j> self, Id32<j> id)
		{
			return default(ConstEnumerable<Id32<j>, UnsafeList<Id32<j>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		public static SOAId32<k?> TGEMVSMXZAO<k>([In] this TreeSys<k> self)
		{
			return default(SOAId32<k>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE100", Offset = "0x3AECB00", VA = "0x183AEE100")]
		public static SOAId32<TMNode?>.Enumerator GetEnumerator<TMNode>([In] this TreeSys<TMNode> self)
		{
			return default(SOAId32<TMNode>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE170", Offset = "0x3AECB70", VA = "0x183AEE170")]
		public static CopyEnumerable<Id32<l?>, SOAId32<l?>.Enumerator> XJDVMKKPGQS<l>([In] this TreeSys<l> self)
		{
			return default(CopyEnumerable<Id32<l>, SOAId32<l>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40C1E00", Offset = "0x40C0800", VA = "0x1840C1E00")]
		public static bool KCSKCRGMMBD<m>([In] this TreeSys<m> self, Id32<m> node, Id32<m> possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x40C2020", Offset = "0x40C0A20", VA = "0x1840C2020")]
		public static CopyEnumerable<Id32<n?>, PathToRootEnumerator<n?>> KXHAYPBZMEW<n>([In] this TreeSys<n> self, Id32<n> node)
		{
			return default(CopyEnumerable<Id32<n>, PathToRootEnumerator<n>>);
		}
	}
}
namespace Circuits.Static.Core.TreeSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class FMZGQDVNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9E00", Offset = "0x3AC8800", VA = "0x183AC9E00")]
		public static TreeSys<TMNode> BNRJUVCRJLB<TMNode>(this QAIYWXYBASJ a) where TMNode : notnull
		{
			return default(TreeSys<TMNode>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99FF0", Offset = "0x2B989F0", VA = "0x182B99FF0")]
		public static void Release(this QAIYWXYBASJ self, int id)
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
