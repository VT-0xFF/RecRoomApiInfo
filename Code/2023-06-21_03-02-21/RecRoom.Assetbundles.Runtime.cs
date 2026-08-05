using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ONINECGKBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class LNGANCFECBC<T> : HJNKAAJMIJK<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x35ED170", Offset = "0x35EC370", VA = "0x1835ED170")]
		public LNGANCFECBC(AsyncOperationHandle<T> MJPPPMHFGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCB4130", Offset = "0xCB3330", VA = "0x180CB4130", Slot = "11")]
		protected override T LAFCGEJNDII(T OAJEJILMOEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x42A0670", Offset = "0x429F870", VA = "0x1842A0670", Slot = "10")]
		protected sealed override void DFFAFFJMOHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class KMAPFPLEPDJ<T> : HJNKAAJMIJK<GameObject, T> where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x35ED170", Offset = "0x35EC370", VA = "0x1835ED170")]
		public KMAPFPLEPDJ(AsyncOperationHandle<GameObject> MJPPPMHFGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27877F0", Offset = "0x27869F0", VA = "0x1827877F0", Slot = "11")]
		protected override T LAFCGEJNDII(GameObject OAJEJILMOEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35ED0E0", Offset = "0x35EC2E0", VA = "0x1835ED0E0", Slot = "10")]
		protected sealed override void DFFAFFJMOHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private abstract class HJNKAAJMIJK<TSource, TTransformed> : EGGJLDCBMLG<Task<TSource>, TTransformed> where TSource : UnityEngine.Object where TTransformed : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TSource> KBMLFBOAOAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TSource MLEJIKFBGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8EE410", Offset = "0x8ED610", VA = "0x1808EE410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x983E40", Offset = "0x983040", VA = "0x180983E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x43444F0", Offset = "0x43436F0", VA = "0x1843444F0")]
		protected HJNKAAJMIJK(AsyncOperationHandle<TSource> MJPPPMHFGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4344480", Offset = "0x4343680", VA = "0x184344480", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43443F0", Offset = "0x43435F0", VA = "0x1843443F0", Slot = "9")]
		protected override TTransformed JEHHDBBMLMF(Task<TSource> PFJAIBNPAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract TTransformed LAFCGEJNDII(TSource OAJEJILMOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4930", Offset = "0x2EA3B30", VA = "0x182EA4930")]
	public static bool LLOENPFIKPD<T>(AssetReference MBMKGFHCGCL, Func<GHFDPPJAELF<T>> MJOJCPDBJDC, out GHFDPPJAELF<T> FLBOAMOFEPB) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4800", Offset = "0x2EA3A00", VA = "0x182EA4800")]
	public static GHFDPPJAELF<T> JNKPNIEENAH<T>([NotNull] AssetReference AGOMIPAHPDH) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2EA46E0", Offset = "0x2EA38E0", VA = "0x182EA46E0")]
	public static GHFDPPJAELF<T> CPHGFJDPFOC<T>([NotNull] AssetReference AGOMIPAHPDH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void MHOIJDOMBDM(AssetReference AGOMIPAHPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NMOINKHPPJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CIGJCLLHLAB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DKBJJLGCHNA<T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public CIGJCLLHLAB request;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public DKBJJLGCHNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x375CB90", Offset = "0x375BD90", VA = "0x18375CB90")]
			internal void KFHBPBEMIEA(T o)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private AEAAPGKBHMO AMMPGAFDPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private object COKMICNPMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int ANONGMMCMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private UnityEngine.Object JGKBAKIBKIN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int IIBLOBOBDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UnityEngine.Object CPOJALCNDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x33FFF90", Offset = "0x33FF190", VA = "0x1833FFF90")]
		public static CIGJCLLHLAB DMEJLJMHBPG<T>(AssetReference MBMKGFHCGCL) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x33FFFD0", Offset = "0x33FF1D0", VA = "0x1833FFFD0")]
		private static CIGJCLLHLAB LNKOKDBGFEJ<T>(AssetReference MBMKGFHCGCL, GHFDPPJAELF<T> OLGDEBBJKKK) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		private CIGJCLLHLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70F8770", Offset = "0x70F7970", VA = "0x1870F8770")]
		public void FDGJMOCNEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70F86A0", Offset = "0x70F78A0", VA = "0x1870F86A0")]
		public void DJOCHGMHMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70F86B0", Offset = "0x70F78B0", VA = "0x1870F86B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IMCLNOAHJDH<T> : GHFDPPJAELF<T>, AEAAPGKBHMO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public Action INJDLLFGGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool MIGKAMNMNKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GHFDPPJAELF<T> GMABKJOMDIC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Task KCBMFLPLCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x19D5A50", Offset = "0x19D4C50", VA = "0x1819D5A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private OOPPNGPPPLE LBPPKDMGKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1CCDC40", Offset = "0x1CCCE40", VA = "0x181CCDC40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NHJDNADPIAN<T> GJKBIGEEPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x275C240", Offset = "0x275B440", VA = "0x18275C240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Task<T> CMLFGHHIHFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x275C2A0", Offset = "0x275B4A0", VA = "0x18275C2A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x275C350", Offset = "0x275B550", VA = "0x18275C350")]
		public IMCLNOAHJDH(GHFDPPJAELF<T> GMABKJOMDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x275C1D0", Offset = "0x275B3D0", VA = "0x18275C1D0", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GLLLNLLKMGO<T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CIGJCLLHLAB cachedResourceRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NMOINKHPPJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public object runtimeKey;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public GLLLNLLKMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x41B6180", Offset = "0x41B5380", VA = "0x1841B6180")]
		internal void HKICJCFPFPG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KODDBGBLBCG<UnityEngine.Object> KCGBGLJBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GFBBJOEKNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<object, CIGJCLLHLAB> LAAAPJMMLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LinkedList<object> OGOPAFMLFIO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70F8B80", Offset = "0x70F7D80", VA = "0x1870F8B80")]
	public NMOINKHPPJB(int GFBBJOEKNMP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FEE1E0", Offset = "0x2FED3E0", VA = "0x182FEE1E0")]
	public GHFDPPJAELF<T> CPHGFJDPFOC<T>([NotNull] AssetReference AGOMIPAHPDH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FEE240", Offset = "0x2FED440", VA = "0x182FEE240")]
	private IMCLNOAHJDH<T> KFFLNNNHLJF<T>(AssetReference MBMKGFHCGCL, GHFDPPJAELF<T> FLBOAMOFEPB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDF70", Offset = "0x2FED170", VA = "0x182FEDF70")]
	private IMCLNOAHJDH<T> BNDMMINAMGJ<T>(AssetReference MBMKGFHCGCL, GHFDPPJAELF<T> FLBOAMOFEPB, Func<AssetReference, CIGJCLLHLAB> GJMJPJCLPKF) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70F8910", Offset = "0x70F7B10", VA = "0x1870F8910")]
	private void JPNBBJKIAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70F8A30", Offset = "0x70F7C30", VA = "0x1870F8A30")]
	private void NBEDLFCMHJK(CIGJCLLHLAB JFILJIAPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70F8780", Offset = "0x70F7980", VA = "0x1870F8780", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace Cpp2IlInjected;

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
