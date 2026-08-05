using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72F24B0", Offset = "0x72F10B0", VA = "0x1872F24B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HOCJIFAHMID : EALFGPNCLJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private GBMHBOKJODI BEMKJALDOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IFAADHHANFK DCELFOGNDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IRecRoomQualityConfigProvider EAFJBNLIPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72F1BB0", Offset = "0x72F07B0", VA = "0x1872F1BB0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void CBAOONECEAG(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD8DDF0", Offset = "0xD8C9F0", VA = "0x180D8DDF0")]
	[UnityEngine.Scripting.Preserve]
	public HOCJIFAHMID([GJMNBPKNJPO(null)] IFAADHHANFK OEMFEOIFPFO, [GJMNBPKNJPO(null)] GBMHBOKJODI NPEDANBMOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x72F1B20", Offset = "0x72F0720", VA = "0x1872F1B20")]
	private void AIBMGPDBOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72F1CB0", Offset = "0x72F08B0", VA = "0x1872F1CB0", Slot = "4")]
	public void IJIHLHNLKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72F1EA0", Offset = "0x72F0AA0", VA = "0x1872F1EA0", Slot = "5")]
	public OBLFPJIHAJD<Texture2D> PKKKNMBEDBH(HNDMBLALFIB CEPNPJNCMON, [Optional] MIIODELFBFL KNNHCEBFGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72F1D30", Offset = "0x72F0930", VA = "0x1872F1D30")]
	private uint NPDLCEAFKHA(HNDMBLALFIB CEPNPJNCMON, MIIODELFBFL KNNHCEBFGKJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EALFGPNCLJK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJIHLHNLKND();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBLFPJIHAJD<Texture2D> PKKKNMBEDBH(HNDMBLALFIB CEPNPJNCMON, [Optional] MIIODELFBFL KNNHCEBFGKJ);
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
