using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INCBEOGADKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6080", Offset = "0x6FC4680", VA = "0x186FC6080")]
	public static RenderTexture CMJJFEFCKCA(int GDCGAPDOJMJ, int ALIBBMDECIC, int AJKFADODKIF, Camera FHJCDPIIOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6010", Offset = "0x6FC4610", VA = "0x186FC6010")]
	public static void BJDFLKNNBDN(RenderTexture CHMJKNOLECA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IJAEIAJMMAO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DLPIMBGBNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IJAEIAJMMAO DCDDOFOIHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NOIBFODPDCM
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7900", Offset = "0x6FC5F00", VA = "0x186FC7900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FC78F0", Offset = "0x6FC5EF0", VA = "0x186FC78F0")]
		public Resolution(uint HEICJNINGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
		public Resolution(uint HEICJNINGBE, uint DNLDNFFNIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7800", Offset = "0x6FC5E00", VA = "0x186FC7800")]
		public static Resolution GKDMFBNGFFM(Resolution[] IGLCGHPCAIJ, Resolution GLOBDPDHKIG, int IMELDNBNHBG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DONOLPFBDPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Resolution PMEAOANANEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Resolution? LCONLLMJCHP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint HEICJNINGBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5B90", Offset = "0x6FC4190", VA = "0x186FC5B90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DNLDNFFNIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5F20", Offset = "0x6FC4520", VA = "0x186FC5F20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EILCGNCOHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5D40", Offset = "0x6FC4340", VA = "0x186FC5D40")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x188F7F0", Offset = "0x188DDF0", VA = "0x18188F7F0")]
		public DONOLPFBDPA(Resolution PMEAOANANEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5BA0", Offset = "0x6FC41A0", VA = "0x186FC5BA0")]
		private static Resolution HMBMENIDNPN(Resolution LCONLLMJCHP, IJAEIAJMMAO NPHGJCNHEFF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NLJBMLNEGCK
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution PBGHMLHFGMG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution MCFIBPOMBAG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LIMNBOGCDMG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DJFJPJIPOAD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution NMGFNHENONL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NHPJPEOIEPA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static readonly Resolution[] JIKFHPDCNMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class DNPMMOCPGHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JLBNAONIIKF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NFLCHDBBHDD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution CEACKPPJELP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution PIPGBKFKFOI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution JMFCFCKEGBD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static readonly Resolution[] JIKFHPDCNMA;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FC57D0", Offset = "0x6FC3DD0", VA = "0x186FC57D0")]
		public static Resolution GACCELALEIN(uint GDCGAPDOJMJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Resolution IKPGPMNBKHI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FC75A0", Offset = "0x6FC5BA0", VA = "0x186FC75A0")]
	public static bool IONPGCLEMIM(uint LMELAHGMFPH)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[Flags]
		public enum FENIFLMJCEK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class HBEDJCGKLBO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private string ECMAPGHKHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Texture2D MAJKJAIFFLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public FENIFLMJCEK IFPNCNHICML;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5F80", Offset = "0x6FC4580", VA = "0x186FC5F80")]
			public HBEDJCGKLBO(string ECMAPGHKHFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2F834C0", Offset = "0x2F81AC0", VA = "0x182F834C0")]
			public HBEDJCGKLBO(string ECMAPGHKHFB, Texture2D BENNOHAPBLC, FENIFLMJCEK LHOOPIGGIJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5F40", Offset = "0x6FC4540", VA = "0x186FC5F40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HPAIIAHEIFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FENIFLMJCEK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public HPAIIAHEIFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5FD0", Offset = "0x6FC45D0", VA = "0x186FC5FD0")]
			internal void CBKPKOIFGFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MNJKEOJBIJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public MNJKEOJBIJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FC62C0", Offset = "0x6FC48C0", VA = "0x186FC62C0")]
			internal byte[] MBDJGOIHNPD(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MBPGLGNNOFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public MBPGLGNNOFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FC6230", Offset = "0x6FC4830", VA = "0x186FC6230")]
			internal void APOCJLHKDKK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private MFBKDKPGMNP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HBEDJCGKLBO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MFBKDKPGMNP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MFBKDKPGMNP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HBEDJCGKLBO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7280", Offset = "0x6FC5880", VA = "0x186FC7280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FC71D0", Offset = "0x6FC57D0", VA = "0x186FC71D0")]
		public ManagedTexture(string ECMAPGHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7110", Offset = "0x6FC5710", VA = "0x186FC7110")]
		public ManagedTexture(string ECMAPGHKHFB, bool DBKJFJPJIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FC65C0", Offset = "0x6FC4BC0", VA = "0x186FC65C0")]
		public void CCFIAHLAKCJ(RenderTexture CHMJKNOLECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FC70E0", Offset = "0x6FC56E0", VA = "0x186FC70E0")]
		public MFBKDKPGMNP<byte[]> PFGLLJGEBCM(bool IHNJMBAFKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC62E0", Offset = "0x6FC48E0", VA = "0x186FC62E0")]
		public MFBKDKPGMNP<Texture2D> BHLFCIIACEO(FENIFLMJCEK LHOOPIGGIJE, bool CFEDEJMONMN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E20", Offset = "0x6FC5420", VA = "0x186FC6E20")]
		public MFBKDKPGMNP<byte[]> MFJENNNPMLL(bool CFEDEJMONMN = false, int NIDOBBODJLL = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC66B0", Offset = "0x6FC4CB0", VA = "0x186FC66B0")]
		public MFBKDKPGMNP<byte[]> FOGCGEPCLOO(bool CFEDEJMONMN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6870", Offset = "0x6FC4E70", VA = "0x186FC6870")]
		private static MFBKDKPGMNP<Texture2D> JNFABEFGNJL(string ECMAPGHKHFB, RenderTexture CHMJKNOLECA, ref Texture2D IPGINEKBHCB, bool CFEDEJMONMN, FENIFLMJCEK LHAFHECGFNP = FENIFLMJCEK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7020", Offset = "0x6FC5620", VA = "0x186FC7020")]
		public void MFOBPBLNJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC66A0", Offset = "0x6FC4CA0", VA = "0x186FC66A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FC65F0", Offset = "0x6FC4BF0", VA = "0x186FC65F0")]
		[CompilerGenerated]
		private MFBKDKPGMNP<byte[]> DIKFBKOGJAP(Texture2D DCDFJFIGDKH)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC57B0", Offset = "0x6FC3DB0", VA = "0x186FC57B0")]
		public CubeMapGenerator()
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
