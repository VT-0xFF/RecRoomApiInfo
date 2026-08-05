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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7FE35A0", Offset = "0x7FE1BA0", VA = "0x187FE35A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FE01D0", Offset = "0x7FDE7D0", VA = "0x187FE01D0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OLLNOGJDHKC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3930", Offset = "0x7FE1F30", VA = "0x187FE3930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3920", Offset = "0x7FE1F20", VA = "0x187FE3920")]
		public Resolution(uint POMHCCBBBGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
		public Resolution(uint POMHCCBBBGD, uint JKKMGDMGNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3830", Offset = "0x7FE1E30", VA = "0x187FE3830")]
		public static Resolution JFDEJBBFDPB(Resolution[] PANLLLBJFBB, Resolution EKJILEDGLGP, int JIPEFAFNCIF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DFMPBMNJDPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution LBKJAFHFEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? DCEPMGHPDPK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint POMHCCBBBGD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE0370", Offset = "0x7FDE970", VA = "0x187FE0370")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution BGMIEJGDIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE0380", Offset = "0x7FDE980", VA = "0x187FE0380")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEA80B0", Offset = "0xEA66B0", VA = "0x180EA80B0")]
		public DFMPBMNJDPA(Resolution LBKJAFHFEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE01F0", Offset = "0x7FDE7F0", VA = "0x187FE01F0")]
		private static Resolution CHLIKMAHEBH(Resolution DCEPMGHPDPK, HJEJJGGLLGM FHOIKCOCDLE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BPMLCIKMFDK
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution IIGMAJCPHCH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution AGEHDGJKMDA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution FOFKEAPBOLI;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution OAIABJNLEBO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution KFJPFONLMIM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution ADJDAGPPPJP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] OABEBNOBDEB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class GOHNDKPMDLH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PNOPBEGPMDC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FCLJBAAKDDL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution MNFGDCHEOGL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution OFCIBIJHGHP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KKBHDAKDMJL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] OABEBNOBDEB;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1800", Offset = "0x7FDFE00", VA = "0x187FE1800")]
		public static Resolution CFIFBAKABBA(uint CHNPEPOPPAN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution BBCOLPABEMM;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JBMMANAKICD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FE25B0", Offset = "0x7FE0BB0", VA = "0x187FE25B0")]
	public static bool MCHKCAJFPCM(byte[] ACJFHCNBBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2310", Offset = "0x7FE0910", VA = "0x187FE2310")]
	public static bool CMNJAAOIPHC(byte[] ACJFHCNBBBO, [Out] int CHNPEPOPPAN, [Out] int NFMKPLMDKDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2520", Offset = "0x7FE0B20", VA = "0x187FE2520")]
	private static int HODFBAOOCAO(byte[] ACJFHCNBBBO, int IGHNHCKLCCN, [Out] ushort DMBEBGDDNKE)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[Flags]
		public enum KHLHCKMJLFB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class IAOPAHFKFLA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string IEDAJGLJHNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D ENMOEDEGMPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KHLHCKMJLFB ACENPOFJIKB;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7FE22C0", Offset = "0x7FE08C0", VA = "0x187FE22C0")]
			public IAOPAHFKFLA(string IEDAJGLJHNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1B5BAA0", Offset = "0x1B5A0A0", VA = "0x181B5BAA0")]
			public IAOPAHFKFLA(string IEDAJGLJHNI, Texture2D OEJKMPDBJDN, KHLHCKMJLFB FKPPCJMEFMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2280", Offset = "0x7FE0880", VA = "0x187FE2280", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EBJPDEOPFIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KHLHCKMJLFB textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public EBJPDEOPFIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7FE0DE0", Offset = "0x7FDF3E0", VA = "0x187FE0DE0")]
			internal void NHHHBOACCLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GKKFKALLOBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public GKKFKALLOBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7FE17C0", Offset = "0x7FDFDC0", VA = "0x187FE17C0")]
			internal MLBELIOHFNF JJPKNONMDJF(Texture2D t2d)
			{
				return default(MLBELIOHFNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EALLECFIMBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public EALLECFIMBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE0D60", Offset = "0x7FDF360", VA = "0x187FE0D60")]
			internal void KOGJLPMBCEM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EHBLMFNEKIG<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IAOPAHFKFLA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EHBLMFNEKIG<MLBELIOHFNF> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EHBLMFNEKIG<MLBELIOHFNF> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private IAOPAHFKFLA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE34F0", Offset = "0x7FE1AF0", VA = "0x187FE34F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3420", Offset = "0x7FE1A20", VA = "0x187FE3420")]
		public ManagedTexture(string IEDAJGLJHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3480", Offset = "0x7FE1A80", VA = "0x187FE3480")]
		public ManagedTexture(string IEDAJGLJHNI, bool ENNEMEJOCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2BA0", Offset = "0x7FE11A0", VA = "0x187FE2BA0")]
		public void MJEADFDKAPI(RenderTexture LPBABFJGBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3130", Offset = "0x7FE1730", VA = "0x187FE3130")]
		public EHBLMFNEKIG<Texture2D> PGFELGPEHLH(KHLHCKMJLFB FKPPCJMEFMH, bool DAMBEMLKCJA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2700", Offset = "0x7FE0D00", VA = "0x187FE2700")]
		public EHBLMFNEKIG<MLBELIOHFNF> HPHHACJNEFP(bool DAMBEMLKCJA = false, int DCMFHHOLMOG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE28A0", Offset = "0x7FE0EA0", VA = "0x187FE28A0")]
		public EHBLMFNEKIG<MLBELIOHFNF> KDOPNKCOAIF(bool DAMBEMLKCJA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2BE0", Offset = "0x7FE11E0", VA = "0x187FE2BE0")]
		private static EHBLMFNEKIG<Texture2D> NIFJBNOMIPJ(string IEDAJGLJHNI, RenderTexture LPBABFJGBBG, Texture2D CINIKPLKDBP, bool DAMBEMLKCJA, KHLHCKMJLFB GAGIPKOCKPI = KHLHCKMJLFB.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FE25F0", Offset = "0x7FE0BF0", VA = "0x187FE25F0")]
		public void DPMDAGPPACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2690", Offset = "0x7FE0C90", VA = "0x187FE2690", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FE26A0", Offset = "0x7FE0CA0", VA = "0x187FE26A0")]
		[CompilerGenerated]
		private EHBLMFNEKIG<byte[]> GLAKPOKCJFM(Texture2D HEGLGMFHFEH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ECIAONHEDON
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct EIPABNMNBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FE11A0", Offset = "0x7FDF7A0", VA = "0x187FE11A0")]
		public unsafe static extern void GLGHHOLOOLG(void* JAIONEOEFKH, void* PFPDPIHOEAL, bool PFBNCGLLHCK, bool BOGPJMKPMMJ, bool GHBGMNGPFJH, [Out] int CHNPEPOPPAN, [Out] int NFMKPLMDKDE, [Out] bool EPLDGALMMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class AKBHDPGFPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AKBHDPGFPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFE10", Offset = "0x7FDE410", VA = "0x187FDFE10")]
		internal void JNANDEHPDJP(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FBBKDODPDCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1530", Offset = "0x7FDFB30", VA = "0x187FE1530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1750", Offset = "0x7FDFD50", VA = "0x187FE1750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PHMKFFFNGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PHMKFFFNGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE37F0", Offset = "0x7FE1DF0", VA = "0x187FE37F0")]
		internal void DAIPEFOLNGI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HDHHJPBHAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PHMKFFFNGLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1B50", Offset = "0x7FE0150", VA = "0x187FE1B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2210", Offset = "0x7FE0810", VA = "0x187FE2210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool HCGKAMJIIDL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	public static bool NBGHKNDDLFM(byte[] BPJACFMMOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0EC0", Offset = "0x7FDF4C0", VA = "0x187FE0EC0")]
	[AsyncStateMachine(typeof(FBBKDODPDCH))]
	public static Task<Texture2D> HBIEMPNJNHA(byte[] BPJACFMMOEN, bool MEKONFCBOCN = false, bool BBIEFHOMADH = false, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1000", Offset = "0x7FDF600", VA = "0x187FE1000")]
	[AsyncStateMachine(typeof(HDHHJPBHAPP))]
	private static Task<Texture2D> JIHLGIBOKCD(int CHNPEPOPPAN, int NFMKPLMDKDE, bool EFKPMOHDKGP, bool MEKONFCBOCN, bool BBIEFHOMADH, Action<NativeArray<byte>> CKEHDKEKKMF, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0E20", Offset = "0x7FDF420", VA = "0x187FE0E20")]
	private static TextureFormat BPGOFIIKCMG(bool EFKPMOHDKGP)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum HFPKGOMHPOK
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class DPOLMEKOGHI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE08E0", Offset = "0x7FDEEE0", VA = "0x187FE08E0")]
	public static bool FHLECHALFAG(byte[] ACJFHCNBBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0920", Offset = "0x7FDEF20", VA = "0x187FE0920")]
	public static void NILGDAKPAIP(byte[] ACJFHCNBBBO, [Out] int CHNPEPOPPAN, [Out] int NFMKPLMDKDE, [Out] HFPKGOMHPOK MCLEKLAABMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0C30", Offset = "0x7FDF230", VA = "0x187FE0C30")]
	private static uint PNDOHADDPCL(byte[] ACJFHCNBBBO, int BKJCDJJKAFA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FE06E0", Offset = "0x7FDECE0", VA = "0x187FE06E0")]
	private static ulong BDKBNOGIHIB(byte[] ACJFHCNBBBO, int BKJCDJJKAFA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EKHNAHHBEPO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1300", Offset = "0x7FDF900", VA = "0x187FE1300")]
	public static RenderTexture OBJJMPKKJJL(int CHNPEPOPPAN, int NFMKPLMDKDE, int DLAADELKPMC, Camera CHOCCMBOAGC, RenderTextureMemoryless OJOJBAFLEAK = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FE12A0", Offset = "0x7FDF8A0", VA = "0x187FE12A0")]
	public static void AJCOPKHHJBF(RenderTexture LPBABFJGBBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class HBEPHCOBDGG<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct BLOHGKOIIJF : IEquatable<BLOHGKOIIJF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId FEDGODJBMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly CLGPFJIEJGB ICAIAJLHNCI;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1983E90", Offset = "0x1982490", VA = "0x181983E90")]
		public BLOHGKOIIJF(TImageId BLIBAMJKLIA, CLGPFJIEJGB KOGPHCFCJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x620FC30", Offset = "0x620E230", VA = "0x18620FC30", Slot = "4")]
		public bool Equals(HBEPHCOBDGG<TImageId>.BLOHGKOIIJF HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x620FAB0", Offset = "0x620E0B0", VA = "0x18620FAB0", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x620FDB0", Offset = "0x620E3B0", VA = "0x18620FDB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x620FE70", Offset = "0x620E470", VA = "0x18620FE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KLAOCBNILKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PGDJPLOBHJM<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KLAOCBNILKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x52D98A0", Offset = "0x52D7EA0", VA = "0x1852D98A0")]
		internal void MKHBFOFCBFL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct MAONICGBHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public BLOHGKOIIJF cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HBEPHCOBDGG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private CLGPFJIEJGB <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x55F88A0", Offset = "0x55F6EA0", VA = "0x1855F88A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x55F9650", Offset = "0x55F7C50", VA = "0x1855F9650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NMEJONGEMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CLGPFJIEJGB textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HBEPHCOBDGG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x569F5B0", Offset = "0x569DBB0", VA = "0x18569F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x569FD10", Offset = "0x569E310", VA = "0x18569FD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct ADMJGNIJAPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4E64C40", Offset = "0x4E63240", VA = "0x184E64C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4E64E80", Offset = "0x4E63480", VA = "0x184E64E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DJNMEKFFNFC = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim DBKNPCAMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? DFGMOONDALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, CLGPFJIEJGB, CancellationToken, Task<Texture2D>>? ECCCNNEBIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? HGBHCKBCCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DBPOMMLFDMH<BLOHGKOIIJF, Texture2D> AGFIPAOOPJG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6890", Offset = "0x4DD4E90", VA = "0x184DD6890")]
	public HBEPHCOBDGG(Func<TImageId, CancellationToken, Task<byte[]>> GFMDEJOACPD, [Optional] Func<TImageId, string>? HFAAEGFNNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4DD68C0", Offset = "0x4DD4EC0", VA = "0x184DD68C0")]
	public HBEPHCOBDGG(Func<TImageId, CLGPFJIEJGB, CancellationToken, Task<Texture2D>> NOFHAMJFINE, [Optional] Func<TImageId, string>? HFAAEGFNNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6700", Offset = "0x4DD4D00", VA = "0x184DD6700")]
	private HBEPHCOBDGG(Func<TImageId, CancellationToken, Task<byte[]>>? GFMDEJOACPD, Func<TImageId, CLGPFJIEJGB, CancellationToken, Task<Texture2D>>? NOFHAMJFINE, Func<TImageId, string>? HFAAEGFNNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5770", Offset = "0x4DD3D70", VA = "0x184DD5770")]
	public MODONOMENDG<Texture2D> EFGLLEDOIBC(TImageId MEDFCBAEFBL, CLGPFJIEJGB LOHFEBCFFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5E20", Offset = "0x4DD4420", VA = "0x184DD5E20")]
	public void HOFEHCFMDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4DD56D0", Offset = "0x4DD3CD0", VA = "0x184DD56D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5B70", Offset = "0x4DD4170", VA = "0x184DD5B70")]
	[AsyncStateMachine(typeof(HBEPHCOBDGG<>.MAONICGBHFD))]
	private Task<Texture2D> HIPKDGDOPMB(BLOHGKOIIJF BIPFMGFLODL, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6040", Offset = "0x4DD4640", VA = "0x184DD6040")]
	[AsyncStateMachine(typeof(HBEPHCOBDGG<>.NMEJONGEMMI))]
	private Task<Texture2D> KJOJIAECMJF(byte[] BPJACFMMOEN, CLGPFJIEJGB LOHFEBCFFIK, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6030", Offset = "0x4DD4630", VA = "0x184DD6030")]
	private void KCAEAGICKAO(Texture2D OEJKMPDBJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DD56C0", Offset = "0x4DD3CC0", VA = "0x184DD56C0")]
	private bool CGLJHMAKOHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6300", Offset = "0x4DD4900", VA = "0x184DD6300")]
	private bool PLMPHBGDAOG(byte[] BPJACFMMOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5F40", Offset = "0x4DD4540", VA = "0x184DD5F40")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HBEPHCOBDGG<>.ADMJGNIJAPB))]
	internal static Task IBOGFDIJPGL(IDisposable LFGDEAHDNLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum CLGPFJIEJGB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
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
