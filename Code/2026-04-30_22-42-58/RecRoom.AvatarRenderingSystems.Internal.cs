using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x95AABF0", Offset = "0x95A9FF0", VA = "0x1895AABF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BJNCVPLTHRL : YKZECVVSWVA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private XWADKYQSKQZ ESQHCJLISGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NLWRQQIDVOA WUBGBKHOAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IRecRoomQualityConfigProvider KDNBTBXBIFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool HTFHHBQGGED;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x95AA7E0", Offset = "0x95A9BE0", VA = "0x1895AA7E0")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void ENAKDGREWFX(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23B1400", Offset = "0x23B0800", VA = "0x1823B1400")]
		[UnityEngine.Scripting.Preserve]
		public BJNCVPLTHRL([Inject(null)] NLWRQQIDVOA recNetAccounts, [Inject(null)] XWADKYQSKQZ imageCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x95AAA40", Offset = "0x95A9E40", VA = "0x1895AAA40")]
		private void OORTEQSUVLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x95AAAD0", Offset = "0x95A9ED0", VA = "0x1895AAAD0", Slot = "4")]
		public void YWRIAOUNHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x95AA270", Offset = "0x95A9670", VA = "0x1895AA270", Slot = "5")]
		public JKLEBMPSNGQ<Texture2D> BHFDLGKKNZI(XHZYJHKTYEA a, [Optional] XHOALOPXSNA b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x95AA8D0", Offset = "0x95A9CD0", VA = "0x1895AA8D0")]
		private uint EQIYHVRIPIC(XHZYJHKTYEA a, XHOALOPXSNA b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface YKZECVVSWVA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YWRIAOUNHBH();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JKLEBMPSNGQ<Texture2D> BHFDLGKKNZI(XHZYJHKTYEA a, [Optional] XHOALOPXSNA b);
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
