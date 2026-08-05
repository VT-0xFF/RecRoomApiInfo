using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x69EE1C0", Offset = "0x69ECDC0", VA = "0x1869EE1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69EB280", Offset = "0x69E9E80", VA = "0x1869EB280")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JBHDDBHABOG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHDBGLLKJNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JBHDDBHABOG DJJICMOEDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFOGFNIEEAO(VertexAttributeFormat HCFPFEPBAJC, int IJLOEMJNHEB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMLONFLMGGH
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69EEAB0", Offset = "0x69ED6B0", VA = "0x1869EEAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69EEAA0", Offset = "0x69ED6A0", VA = "0x1869EEAA0")]
		public Resolution(uint KIGIELEFAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
		public Resolution(uint KIGIELEFAKI, uint DKINGMIONNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69EE9B0", Offset = "0x69ED5B0", VA = "0x1869EE9B0")]
		public static Resolution DPGHPNGDBLH(Resolution[] GAANPFIMDCL, Resolution LONNNHFLMJA, int FKJEOENODBK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DABGCBCCOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution KCEOIDOGEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? OAKGKCAPPEI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint KIGIELEFAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x69EB750", Offset = "0x69EA350", VA = "0x1869EB750")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution NMKOGDOHHML
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69EB420", Offset = "0x69EA020", VA = "0x1869EB420")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1C696E0", Offset = "0x1C682E0", VA = "0x181C696E0")]
		public DABGCBCCOGM(Resolution KCEOIDOGEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69EB2A0", Offset = "0x69E9EA0", VA = "0x1869EB2A0")]
		private static Resolution APABANMMFJP(Resolution OAKGKCAPPEI, JBHDDBHABOG ACPKAPBBBIA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class MIBLFDAHFMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OOINFFFLDOD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OAACDGEDLII;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JNEGJJNLMMH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JOJOKOKFPPF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution FOEOOGNJHFL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KJFJEDJKGIF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] IABBMFOMAIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class NACFEMAFICG
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution ALOOFMICHKI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution EACMLILIACK;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution INDCMPBAKLC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution MEHCBIPCDJG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution PPHHBCGDFFK;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] IABBMFOMAIE;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69EDC20", Offset = "0x69EC820", VA = "0x1869EDC20")]
		public static Resolution HFEOCFDEPLI(uint KPOPMJPAOEJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution LILJGPLNBHF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class ELIAPDGHNNH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69EBB00", Offset = "0x69EA700", VA = "0x1869EBB00")]
	public static bool NFHKBLKJBCB(byte[] JGFKFMMOAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69EB8F0", Offset = "0x69EA4F0", VA = "0x1869EB8F0")]
	public static bool INDIEBOMHEP(byte[] JGFKFMMOAJO, [Out] int KPOPMJPAOEJ, [Out] int DMHGGENLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69EB860", Offset = "0x69EA460", VA = "0x1869EB860")]
	private static int IJLGEIIDDBH(byte[] JGFKFMMOAJO, int IPBPNCHALEF, [Out] ushort GDEJPIHOHDJ)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		public enum KPCNGGJAFIG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class KDLACPHMCBL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LONKACOOPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D BCLPPNAMJPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KPCNGGJAFIG JIMCJCOKFIJ;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69EC9D0", Offset = "0x69EB5D0", VA = "0x1869EC9D0")]
			public KDLACPHMCBL(string LONKACOOPGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2450", Offset = "0x3DE1050", VA = "0x183DE2450")]
			public KDLACPHMCBL(string LONKACOOPGJ, Texture2D CCJNIFOFHAO, KPCNGGJAFIG AHOJGACOHAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69EC990", Offset = "0x69EB590", VA = "0x1869EC990", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ONHPNCEBPCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KPCNGGJAFIG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ONHPNCEBPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69EE970", Offset = "0x69ED570", VA = "0x1869EE970")]
			internal void PGFOPBFFMHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KDPNHLLCDNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public KDPNHLLCDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69ECA20", Offset = "0x69EB620", VA = "0x1869ECA20")]
			internal IEHBAPAGMED CNJLIKPLLAC(Texture2D t2d)
			{
				return default(IEHBAPAGMED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NDBDKHLHLIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public NDBDKHLHLIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69EDF70", Offset = "0x69ECB70", VA = "0x1869EDF70")]
			internal void JJADJHGAALG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private AMIFHJEHCND<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KDLACPHMCBL _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private AMIFHJEHCND<IEHBAPAGMED> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private AMIFHJEHCND<IEHBAPAGMED> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E10", Offset = "0x8B6A10", VA = "0x1808B7E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private KDLACPHMCBL memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69EDB70", Offset = "0x69EC770", VA = "0x1869EDB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69EDAA0", Offset = "0x69EC6A0", VA = "0x1869EDAA0")]
		public ManagedTexture(string LONKACOOPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69EDB00", Offset = "0x69EC700", VA = "0x1869EDB00")]
		public ManagedTexture(string LONKACOOPGJ, bool KCGIOELOPKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69ED080", Offset = "0x69EBC80", VA = "0x1869ED080")]
		public void GKMKFDDFCOI(RenderTexture LJFIIEDOBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69ECCE0", Offset = "0x69EB8E0", VA = "0x1869ECCE0")]
		public AMIFHJEHCND<Texture2D> DJOBKPBHNEK(KPCNGGJAFIG AHOJGACOHAI, bool IGIHACJKKIL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69ED3C0", Offset = "0x69EBFC0", VA = "0x1869ED3C0")]
		public AMIFHJEHCND<IEHBAPAGMED> PAFANLIBLIP(bool IGIHACJKKIL = false, int OOCJFCPNAOK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69ED0C0", Offset = "0x69EBCC0", VA = "0x1869ED0C0")]
		public AMIFHJEHCND<IEHBAPAGMED> IJALFNGFNOC(bool IGIHACJKKIL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69ED550", Offset = "0x69EC150", VA = "0x1869ED550")]
		private static AMIFHJEHCND<Texture2D> PBLMEKFIPEO(string LONKACOOPGJ, RenderTexture LJFIIEDOBMH, Texture2D OHIMFNIADOL, bool IGIHACJKKIL, KPCNGGJAFIG EOHCNHAIPNF = KPCNGGJAFIG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69ECFE0", Offset = "0x69EBBE0", VA = "0x1869ECFE0")]
		public void FDEPFDJNLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69ECFD0", Offset = "0x69EBBD0", VA = "0x1869ECFD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69ECC80", Offset = "0x69EB880", VA = "0x1869ECC80")]
		[CompilerGenerated]
		private AMIFHJEHCND<byte[]> AOODNEHIEFH(Texture2D MLHDABOALJF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JLBENPMIEAN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DKCKLAHJIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69EB760", Offset = "0x69EA360", VA = "0x1869EB760")]
		public unsafe static extern void OBALPFOCKPN(void* IABOAMLFNLM, void* EGMKHAEDBDP, bool EAJNNPLJGEP, bool GFCDKIGMDDB, bool MGOAGKJPBFI, [Out] int KPOPMJPAOEJ, [Out] int DMHGGENLNJL, [Out] bool LBHLGKFLFPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FNCLJOCABEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FNCLJOCABEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69EBDD0", Offset = "0x69EA9D0", VA = "0x1869EBDD0")]
		internal void FLBENKMHKEF(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CGEDGCHOPMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x69EAFF0", Offset = "0x69E9BF0", VA = "0x1869EAFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69EB210", Offset = "0x69E9E10", VA = "0x1869EB210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FNEGOAIMBIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FNEGOAIMBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69EBF70", Offset = "0x69EAB70", VA = "0x1869EBF70")]
		internal void FKFEMIMJAMA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct OBOOMMOKJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private FNEGOAIMBIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x69EE240", Offset = "0x69ECE40", VA = "0x1869EE240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69EE900", Offset = "0x69ED500", VA = "0x1869EE900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool JOJNJEJNNJI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	public static bool CIEKKAAPANO(byte[] ECHIOLJDEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69EC6C0", Offset = "0x69EB2C0", VA = "0x1869EC6C0")]
	[AsyncStateMachine(typeof(CGEDGCHOPMN))]
	public static Task<Texture2D> CPJCJEPIMKC(byte[] ECHIOLJDEEC, bool IIIDECKOIIO = false, bool EMEAAIPBEHJ = false, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69EC800", Offset = "0x69EB400", VA = "0x1869EC800")]
	[AsyncStateMachine(typeof(OBOOMMOKJEH))]
	private static Task<Texture2D> JCKIIIFGAFE(int KPOPMJPAOEJ, int DMHGGENLNJL, bool GMFBPJPMBHM, bool IIIDECKOIIO, bool EMEAAIPBEHJ, Action<NativeArray<byte>> PGOMCBFFGHB, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69EC620", Offset = "0x69EB220", VA = "0x1869EC620")]
	private static TextureFormat BNCGILACEFD(bool GMFBPJPMBHM)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum FFBLNPDOCMJ
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal static class JIIMFBOMIBD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69EC1B0", Offset = "0x69EADB0", VA = "0x1869EC1B0")]
	public static bool BEHCLPEKECH(byte[] JGFKFMMOAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69EC320", Offset = "0x69EAF20", VA = "0x1869EC320")]
	public static void NFFEFGFPFBA(byte[] JGFKFMMOAJO, [Out] int KPOPMJPAOEJ, [Out] int DMHGGENLNJL, [Out] FFBLNPDOCMJ HCFPFEPBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69EC1F0", Offset = "0x69EADF0", VA = "0x1869EC1F0")]
	private static uint GBFOFEKFOOD(byte[] JGFKFMMOAJO, int CNNPCLMHBKN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69EBFB0", Offset = "0x69EABB0", VA = "0x1869EBFB0")]
	private static ulong AJPAAJPDFFN(byte[] JGFKFMMOAJO, int CNNPCLMHBKN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FCHMGBMBJFK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69EBBA0", Offset = "0x69EA7A0", VA = "0x1869EBBA0")]
	public static RenderTexture OHOBMPNGLPF(int KPOPMJPAOEJ, int DMHGGENLNJL, int HBEJCDEEPGH, Camera BCNHCNDKBNI, RenderTextureMemoryless DEDCOCNIGHN = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69EBB40", Offset = "0x69EA740", VA = "0x1869EBB40")]
	public static void HLKCEKBEBPP(RenderTexture LJFIIEDOBMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OMKANKPBDHG<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct JLDHOEAFOOL : IEquatable<JLDHOEAFOOL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId BAMNELMKAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly DLFCBHJFGGP FLINKPMLHIO;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3DB44E0", Offset = "0x3DB30E0", VA = "0x183DB44E0")]
		public JLDHOEAFOOL(TImageId NCMHANGAILD, DLFCBHJFGGP OECOPIEIIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40CC0B0", Offset = "0x40CACB0", VA = "0x1840CC0B0", Slot = "4")]
		public bool Equals(OMKANKPBDHG<TImageId>.JLDHOEAFOOL HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40CC1E0", Offset = "0x40CADE0", VA = "0x1840CC1E0", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x40CC4F0", Offset = "0x40CB0F0", VA = "0x1840CC4F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x40CC780", Offset = "0x40CB380", VA = "0x1840CC780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class INCJKBDPIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ELKLJFKIONH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public INCJKBDPIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6040", Offset = "0x3EB4C40", VA = "0x183EB6040")]
		internal void OBOHAEPFFEC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LNJKMMNPFKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JLDHOEAFOOL cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public OMKANKPBDHG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DLFCBHJFGGP <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x428E2F0", Offset = "0x428CEF0", VA = "0x18428E2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x428EA50", Offset = "0x428D650", VA = "0x18428EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DINGHHFONGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DLFCBHJFGGP textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OMKANKPBDHG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x58B0B30", Offset = "0x58AF730", VA = "0x1858B0B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x58B19E0", Offset = "0x58B05E0", VA = "0x1858B19E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct GEIEGLJCPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F830", Offset = "0x3D2E430", VA = "0x183D2F830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FBF0", Offset = "0x3D2E7F0", VA = "0x183D2FBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int KKHAKEHNDAE = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim BOJLAOFBIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? KNGGEIOEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, DLFCBHJFGGP, CancellationToken, Task<Texture2D>>? MLGLLOENFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? DOHCHMMKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GGPGNIIIDFD<JLDHOEAFOOL, Texture2D> NMCMOLFFEGK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x46C1E70", Offset = "0x46C0A70", VA = "0x1846C1E70")]
	public OMKANKPBDHG(Func<TImageId, CancellationToken, Task<byte[]>> AGCBIOIOCGO, [Optional] Func<TImageId, string>? CIHKKHMKDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46C1E20", Offset = "0x46C0A20", VA = "0x1846C1E20")]
	public OMKANKPBDHG(Func<TImageId, DLFCBHJFGGP, CancellationToken, Task<Texture2D>> NMPHKCGEFAB, [Optional] Func<TImageId, string>? CIHKKHMKDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46C1EC0", Offset = "0x46C0AC0", VA = "0x1846C1EC0")]
	private OMKANKPBDHG(Func<TImageId, CancellationToken, Task<byte[]>>? AGCBIOIOCGO, Func<TImageId, DLFCBHJFGGP, CancellationToken, Task<Texture2D>>? NMPHKCGEFAB, Func<TImageId, string>? CIHKKHMKDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46C17F0", Offset = "0x46C03F0", VA = "0x1846C17F0")]
	public MOKKMPAFINF<Texture2D> GGAOPBDBMHA(TImageId HAJNKGHKMCI, DLFCBHJFGGP NDMKJJEFEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46C1BE0", Offset = "0x46C07E0", VA = "0x1846C1BE0")]
	public void MOPLAKGEBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46C0FA0", Offset = "0x46BFBA0", VA = "0x1846C0FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46C1460", Offset = "0x46C0060", VA = "0x1846C1460")]
	[AsyncStateMachine(typeof(OMKANKPBDHG<>.LNJKMMNPFKN))]
	private Task<Texture2D> FFLINFHBFMM(JLDHOEAFOOL GJHKHOAMOEF, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46C1050", Offset = "0x46BFC50", VA = "0x1846C1050")]
	[AsyncStateMachine(typeof(OMKANKPBDHG<>.DINGHHFONGM))]
	private Task<Texture2D> EIOAGCOJBPA(byte[] ECHIOLJDEEC, DLFCBHJFGGP NDMKJJEFEBH, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46C1C50", Offset = "0x46C0850", VA = "0x1846C1C50")]
	private void PBHKFAHHPBI(Texture2D CCJNIFOFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46C1C40", Offset = "0x46C0840", VA = "0x1846C1C40")]
	private bool NCKFOFJOICP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46C0EF0", Offset = "0x46BFAF0", VA = "0x1846C0EF0")]
	private bool BFDFGMEJPOD(byte[] ECHIOLJDEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46C1A00", Offset = "0x46C0600", VA = "0x1846C1A00")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OMKANKPBDHG<>.GEIEGLJCPNM))]
	internal static Task KGFNLGCENIN(IDisposable NPGEPPAFJDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum DLFCBHJFGGP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CompressTexture = 4
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
