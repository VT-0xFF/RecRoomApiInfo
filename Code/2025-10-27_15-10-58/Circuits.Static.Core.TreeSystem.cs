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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B999A0", Offset = "0x2B989A0", VA = "0x182B999A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0", Slot = "4")]
			get
			{
				return default(Id32<TMNode>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object UQAIKHVHSEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5DDFBB0", Offset = "0x5DDEBB0", VA = "0x185DDFBB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFCB0", Offset = "0x5DDECB0", VA = "0x185DDFCB0")]
		internal PathToRootEnumerator(Id32<TMNode> start, [In] SOAField<TMNode, Id32<TMNode>> parents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF980", Offset = "0x5DDE980", VA = "0x185DDF980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFBA0", Offset = "0x5DDEBA0", VA = "0x185DDFBA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93960", VA = "0x182B94960")]
		internal TreeSys([In] SOAId32<TMNode> ids, [In] SOAField<TMNode, Id32<TMNode>> parents, [In] SOAField<TMNode, UnsafeList<Id32<TMNode>>> children)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64796A0", Offset = "0x64786A0", VA = "0x1864796A0")]
		public static TreeSys<TMNode> New()
		{
			return default(TreeSys<TMNode>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XNRPHNUHANY
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F55140", Offset = "0x3F54140", VA = "0x183F55140")]
		public static YAWZZLJABYO LDGVYQLXUAF<TMNode>([In] this TreeSys<TMNode> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F55C30", Offset = "0x3F54C30", VA = "0x183F55C30")]
		internal static FSWHCJKZRJA RPRZJLCSNBE<TMNode>([In] this UnsafeList<Id32<TMNode>> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F54010", Offset = "0x3F53010", VA = "0x183F54010")]
		internal static UnsafeList<Id32<TMNode>> BHCAUYKAULZ<TMNode>(this FSWHCJKZRJA a) where TMNode : notnull
		{
			return default(UnsafeList<Id32<TMNode>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3F54500", Offset = "0x3F53500", VA = "0x183F54500")]
		public static void Destroy<TMNode>(this TreeSys<TMNode> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F54270", Offset = "0x3F53270", VA = "0x183F54270")]
		public static bool BIIELMEIFZL<a>([In] this TreeSys<a> self, Id32<a> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F55A20", Offset = "0x3F54A20", VA = "0x183F55A20")]
		public static int PKHOSRJZGHM<b>([In] this TreeSys<b> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F55930", Offset = "0x3F54930", VA = "0x183F55930")]
		public static Id32<c?> NDITOWIAQLS<c>(this TreeSys<c> self)
		{
			return default(Id32<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F55750", Offset = "0x3F54750", VA = "0x183F55750")]
		public static Id32<d?> MXMSFLYMGZW<d>(this TreeSys<d> self, Id32<d> parent)
		{
			return default(Id32<d>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F56050", Offset = "0x3F55050", VA = "0x183F56050")]
		public static void Release<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F555B0", Offset = "0x3F545B0", VA = "0x183F555B0")]
		public static bool MTVNYVEZJRR<e>([In] this TreeSys<e> self, Id32<e> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3F54730", Offset = "0x3F53730", VA = "0x183F54730")]
		public static Id32<f?> FZEMZXTSYBB<f>([In] this TreeSys<f> self, Id32<f> id)
		{
			return default(Id32<f>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F54A30", Offset = "0x3F53A30", VA = "0x183F54A30")]
		public static Id32<TMNode?>? GetParentOrNull<TMNode>([In] this TreeSys<TMNode> self, Id32<TMNode> id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F56460", Offset = "0x3F55460", VA = "0x183F56460")]
		public static void Reparent<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id, Id32<TMNode> newParentId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F56640", Offset = "0x3F55640", VA = "0x183F56640")]
		public static ConstEnumerable<Id32<j?>, UnsafeList<Id32<j?>>.Enumerator> UMOMOCLMMHP<j>([In] this TreeSys<j> self, Id32<j> id)
		{
			return default(ConstEnumerable<Id32<j>, UnsafeList<Id32<j>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static SOAId32<k?> RISWWVFOJID<k>([In] this TreeSys<k> self)
		{
			return default(SOAId32<k>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0F20", Offset = "0x3EEFF20", VA = "0x183EF0F20")]
		public static SOAId32<TMNode?>.Enumerator GetEnumerator<TMNode>([In] this TreeSys<TMNode> self)
		{
			return default(SOAId32<TMNode>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF12F0", Offset = "0x3EF02F0", VA = "0x183EF12F0")]
		public static CopyEnumerable<Id32<l?>, SOAId32<l?>.Enumerator> UQADMXZJIWJ<l>([In] this TreeSys<l> self)
		{
			return default(CopyEnumerable<Id32<l>, SOAId32<l>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F54C00", Offset = "0x3F53C00", VA = "0x183F54C00")]
		public static bool KIBOBNORODG<m>([In] this TreeSys<m> self, Id32<m> node, Id32<m> possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F54860", Offset = "0x3F53860", VA = "0x183F54860")]
		public static CopyEnumerable<Id32<n?>, PathToRootEnumerator<n?>> GAKRMYYJALX<n>([In] this TreeSys<n> self, Id32<n> node)
		{
			return default(CopyEnumerable<Id32<n>, PathToRootEnumerator<n>>);
		}
	}
}
namespace Circuits.Static.Core.TreeSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class UAIQFBUEXNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7D40", Offset = "0x3EE6D40", VA = "0x183EE7D40")]
		public static TreeSys<TMNode> FESOWVBASTG<TMNode>(this YAWZZLJABYO a) where TMNode : notnull
		{
			return default(TreeSys<TMNode>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99A20", Offset = "0x2B98A20", VA = "0x182B99A20")]
		public static void Release(this YAWZZLJABYO self, int id)
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
