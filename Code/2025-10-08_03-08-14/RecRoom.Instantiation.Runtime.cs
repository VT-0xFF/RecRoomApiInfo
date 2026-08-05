using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class KAVWRHZEEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly Guid IKNMSTUGZBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly string YWNRNADXQZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int HSMZIVAWBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid STARAURMNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CreationInstantiationParameters BYBUVSMWWBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 VQBBPYBXSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Quaternion JZOPJQMDSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Vector3 GLTCDKGXFXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool EUPNKHXTWZB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85DA2C0", Offset = "0x85D90C0", VA = "0x1885DA2C0")]
		public KAVWRHZEEFC(string a, Guid b, int c, Guid d, CreationInstantiationParameters e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85DA210", Offset = "0x85D9010", VA = "0x1885DA210")]
		public NDZRBGPKBQL VAQZVFHNCMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85DA110", Offset = "0x85D8F10", VA = "0x1885DA110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RVABUHEEOUA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85DA510", Offset = "0x85D9310", VA = "0x1885DA510")]
		public static bool KWRIMZAVELU(this RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85DA570", Offset = "0x85D9370", VA = "0x1885DA570")]
		public static object[] WJDRBLBUQFU(this RRNetworkView a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85DA490", Offset = "0x85D9290", VA = "0x1885DA490")]
		public static ViewId JMFFQHMPQTU(this RRNetworkView a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85DA3E0", Offset = "0x85D91E0", VA = "0x1885DA3E0")]
		public static CreationInstantiationParameters DSMQRMMEXJQ(this RRNetworkView a)
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85DA540", Offset = "0x85D9340", VA = "0x1885DA540")]
		public static CreationInstantiationParameters TVKYYBLLWPV(this RRObjectCreationParameters a)
		{
			return default(CreationInstantiationParameters);
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
