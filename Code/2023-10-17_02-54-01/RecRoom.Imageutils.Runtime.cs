using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1C40", Offset = "0x5CE0440", VA = "0x185CE1C40")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IPGNMEHNBBB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PNHKMMNDFPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IPGNMEHNBBB LJCKLHMBCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OEDIFEMLIJH
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3A60", Offset = "0x5CE2260", VA = "0x185CE3A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A50", Offset = "0x5CE2250", VA = "0x185CE3A50")]
		public Resolution(uint IILAPOMEGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
		public Resolution(uint IILAPOMEGLM, uint BNBBAPGFCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3960", Offset = "0x5CE2160", VA = "0x185CE3960")]
		public static Resolution IMHAEKCMPEM(Resolution[] KFCJCCKINNH, Resolution BFIMHGHDLBF, int ODDOCJPPEHB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MKACDCHDDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution BMOGINKABNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? EONEPHEMPFD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint IILAPOMEGLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5CE25E0", Offset = "0x5CE0DE0", VA = "0x185CE25E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint BNBBAPGFCCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2440", Offset = "0x5CE0C40", VA = "0x185CE2440")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HNMDEGNOKBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2100", Offset = "0x5CE0900", VA = "0x185CE2100")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1805D10", Offset = "0x1804510", VA = "0x181805D10")]
		public MKACDCHDDIE(Resolution BMOGINKABNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2460", Offset = "0x5CE0C60", VA = "0x185CE2460")]
		private static Resolution MCJEHCHICLN(Resolution EONEPHEMPFD, IPGNMEHNBBB HKIIEMKBEKM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BCHOCJCDCCA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution AFLGFKPIMAF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KKPFPDPGOGP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OOCHMEIDOPA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution JLPBGKKPDAJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LPAJKGPCCHE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BOMKFKFBHJC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] JCAJADBKLFI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EGIMLCNFLLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HBCOFLHAHCO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution AGLEBGHKADM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CAJDKPEOFKI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution APIFODGLHBD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution MIIEHJHMBLJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] JCAJADBKLFI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE1CF0", Offset = "0x5CE04F0", VA = "0x185CE1CF0")]
		public static Resolution HANOILGPLDP(uint DCJFLHGCAJC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution OKDKCKGBJCH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3730", Offset = "0x5CE1F30", VA = "0x185CE3730")]
	public static bool IGPGOHOCFIK(uint CCAGICJEEAE)
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
		public enum NKLNMPHGFCG : byte
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

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class DJLIJCJPMOI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string HNHMJGCODBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D MFLELPAKFAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NKLNMPHGFCG EFPOCFENDMC;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1CA0", Offset = "0x5CE04A0", VA = "0x185CE1CA0")]
			public DJLIJCJPMOI(string HNHMJGCODBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3533F00", Offset = "0x3532700", VA = "0x183533F00")]
			public DJLIJCJPMOI(string HNHMJGCODBA, Texture2D IKALEMLLIEF, NKLNMPHGFCG FKGLGLHFOOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1C60", Offset = "0x5CE0460", VA = "0x185CE1C60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KGOJPHHJOCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NKLNMPHGFCG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public KGOJPHHJOCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CE20C0", Offset = "0x5CE08C0", VA = "0x185CE20C0")]
			internal void MEMGDDIJEHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BJMOMIKHJNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public BJMOMIKHJNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CE1C20", Offset = "0x5CE0420", VA = "0x185CE1C20")]
			internal byte[] PJCHLGNNEIA(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JBLEFENJFJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JBLEFENJFJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2040", Offset = "0x5CE0840", VA = "0x185CE2040")]
			internal void JNHPPJOKOBA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private NLPPPLCCBHA<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DJLIJCJPMOI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private NLPPPLCCBHA<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NLPPPLCCBHA<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DJLIJCJPMOI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3680", Offset = "0x5CE1E80", VA = "0x185CE3680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE35B0", Offset = "0x5CE1DB0", VA = "0x185CE35B0")]
		public ManagedTexture(string HNHMJGCODBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3610", Offset = "0x5CE1E10", VA = "0x185CE3610")]
		public ManagedTexture(string HNHMJGCODBA, bool AOEMIEEONNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2DC0", Offset = "0x5CE15C0", VA = "0x185CE2DC0")]
		public void KILAHIOOJMH(RenderTexture EAPHMKPOEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2DA0", Offset = "0x5CE15A0", VA = "0x185CE2DA0")]
		public NLPPPLCCBHA<byte[]> HMNHEOGHLEA(bool LODKELIKCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2800", Offset = "0x5CE1000", VA = "0x185CE2800")]
		public NLPPPLCCBHA<Texture2D> ELJLAMIENIN(NKLNMPHGFCG FKGLGLHFOOD, bool HIEFHHPJOLG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2AF0", Offset = "0x5CE12F0", VA = "0x185CE2AF0")]
		public NLPPPLCCBHA<byte[]> EPKHOKFLKJH(bool HIEFHHPJOLG = false, int PKFOIBBCNDC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2E00", Offset = "0x5CE1600", VA = "0x185CE2E00")]
		public NLPPPLCCBHA<byte[]> NKFIAAGFLFJ(bool HIEFHHPJOLG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3060", Offset = "0x5CE1860", VA = "0x185CE3060")]
		private static NLPPPLCCBHA<Texture2D> PBCOKHFCOGL(string HNHMJGCODBA, RenderTexture EAPHMKPOEJP, Texture2D CMCKJADAPGI, bool HIEFHHPJOLG, NKLNMPHGFCG ABHHIBGIBJE = NKLNMPHGFCG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2CE0", Offset = "0x5CE14E0", VA = "0x185CE2CE0")]
		public void HMIDKBKOGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE27F0", Offset = "0x5CE0FF0", VA = "0x185CE27F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2FC0", Offset = "0x5CE17C0", VA = "0x185CE2FC0")]
		[CompilerGenerated]
		private NLPPPLCCBHA<byte[]> OMFOKBCKALC(Texture2D KDPIDFIHMKL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MOMMMFEJMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CE25F0", Offset = "0x5CE0DF0", VA = "0x185CE25F0")]
	public static RenderTexture NNDAKILPMCL(int DCJFLHGCAJC, int ICNNOLEOCCJ, int IGMBNCEJALG, Camera CBEFLKJMLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2790", Offset = "0x5CE0F90", VA = "0x185CE2790")]
	public static void PNPKEPNPIIC(RenderTexture EAPHMKPOEJP)
	{
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
