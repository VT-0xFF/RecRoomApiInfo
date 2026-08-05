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
public static class EJMOMPDAKEF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class HEKNECGFPBL<T> : IHDCFNCKHBJ<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21A8BE0", Offset = "0x21A73E0", VA = "0x1821A8BE0")]
		public HEKNECGFPBL(AsyncOperationHandle<T> AIDOIEKEDOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE48CA0", Offset = "0xE474A0", VA = "0x180E48CA0", Slot = "9")]
		protected override T DACILPDDEHM(T FPCAMIAKLBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x299FE10", Offset = "0x299E610", VA = "0x18299FE10", Slot = "8")]
		protected sealed override void HPMGNPEIDAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class PFHJNHICDJN<T> : IHDCFNCKHBJ<GameObject, T> where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21A8BE0", Offset = "0x21A73E0", VA = "0x1821A8BE0")]
		public PFHJNHICDJN(AsyncOperationHandle<GameObject> AIDOIEKEDOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1959970", Offset = "0x1958170", VA = "0x181959970", Slot = "9")]
		protected override T DACILPDDEHM(GameObject FPCAMIAKLBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21A8B50", Offset = "0x21A7350", VA = "0x1821A8B50", Slot = "8")]
		protected sealed override void HPMGNPEIDAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private abstract class IHDCFNCKHBJ<TSource, TTransformed> : OEIGIGEMCKG<Task<TSource>, TTransformed> where TSource : UnityEngine.Object where TTransformed : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TSource> PKFOFALPHNL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TSource HPMBFDJEBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2499F00", Offset = "0x2498700", VA = "0x182499F00")]
		protected IHDCFNCKHBJ(AsyncOperationHandle<TSource> AIDOIEKEDOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2499E90", Offset = "0x2498690", VA = "0x182499E90", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2499E00", Offset = "0x2498600", VA = "0x182499E00", Slot = "7")]
		protected override TTransformed FIGJPPLBEPE(Task<TSource> CBJLFGKEGEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract TTransformed DACILPDDEHM(TSource FPCAMIAKLBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEC70", Offset = "0x2AFD470", VA = "0x182AFEC70")]
	public static bool BIDIDIDNIMH<T>(AssetReference FKNDPBGMCOF, Func<NMAKHDNAMLE<T>> HIIOOEJBPCK, out NMAKHDNAMLE<T> JBDENDKBPFI) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2AFED10", Offset = "0x2AFD510", VA = "0x182AFED10")]
	public static NMAKHDNAMLE<T> MBMGJAFHNKF<T>([NotNull] AssetReference EFJDILDKMKB) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEE40", Offset = "0x2AFD640", VA = "0x182AFEE40")]
	public static NMAKHDNAMLE<T> OCDHAOMIICD<T>([NotNull] AssetReference EFJDILDKMKB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void LFGFAFNBECC(AssetReference EFJDILDKMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AOLIFDHHMEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CJKLDAPLHNE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HPIKHDCAFEM<T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public CJKLDAPLHNE request;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public HPIKHDCAFEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3A383F0", Offset = "0x3A36BF0", VA = "0x183A383F0")]
			internal void ENLGFDGLAJD(T o)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private MLNMOGMEOOE KFLNPJICKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private object JKFNEGNBBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int GNEKFELFMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private UnityEngine.Object KEMBFOBHGND;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int PHNLDEFIGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UnityEngine.Object NMCGJOCHLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x295EC30", Offset = "0x295D430", VA = "0x18295EC30")]
		public static CJKLDAPLHNE PPEKGOPLONO<T>(AssetReference FKNDPBGMCOF) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x295E9B0", Offset = "0x295D1B0", VA = "0x18295E9B0")]
		private static CJKLDAPLHNE JLLIDCMBHLI<T>(AssetReference FKNDPBGMCOF, NMAKHDNAMLE<T> DJLDIFFONHE) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		private CJKLDAPLHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F290A0", Offset = "0x6F278A0", VA = "0x186F290A0")]
		public void OADCANBCOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F28FD0", Offset = "0x6F277D0", VA = "0x186F28FD0")]
		public void ADEMKHFNABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F28FE0", Offset = "0x6F277E0", VA = "0x186F28FE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GAEOJKBEOMG<T> : NMAKHDNAMLE<T>, MLNMOGMEOOE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public Action ABNKMBDHJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PMADFOMNIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NMAKHDNAMLE<T> DFECDINGAKH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public JJMNNLLBAJO<T> HHILEEBKNEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2E75480", Offset = "0x2E73C80", VA = "0x182E75480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Task<T> BHHOIJLGAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2E754E0", Offset = "0x2E73CE0", VA = "0x182E754E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2E75590", Offset = "0x2E73D90", VA = "0x182E75590")]
		public GAEOJKBEOMG(NMAKHDNAMLE<T> DFECDINGAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E75410", Offset = "0x2E73C10", VA = "0x182E75410", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HDDGLHLJFGM<T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CJKLDAPLHNE cachedResourceRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AOLIFDHHMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public object runtimeKey;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public HDDGLHLJFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39622D0", Offset = "0x3960AD0", VA = "0x1839622D0")]
		internal void LJALKGJBBJL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BPPINFIIDCE<UnityEngine.Object> JBGJFPFNFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int OCDJEOBNPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<object, CJKLDAPLHNE> ELDIMOGJHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LinkedList<object> LHFPIEGECNF;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F28EB0", Offset = "0x6F276B0", VA = "0x186F28EB0")]
	public AOLIFDHHMEB(int OCDJEOBNPGA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4810", Offset = "0x1DF3010", VA = "0x181DF4810")]
	public NMAKHDNAMLE<T> OCDHAOMIICD<T>([NotNull] AssetReference EFJDILDKMKB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4750", Offset = "0x1DF2F50", VA = "0x181DF4750")]
	private GAEOJKBEOMG<T> FMFEOLIFAII<T>(AssetReference FKNDPBGMCOF, NMAKHDNAMLE<T> JBDENDKBPFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4870", Offset = "0x1DF3070", VA = "0x181DF4870")]
	private GAEOJKBEOMG<T> PLJCIFDDMMJ<T>(AssetReference FKNDPBGMCOF, NMAKHDNAMLE<T> JBDENDKBPFI, Func<AssetReference, CJKLDAPLHNE> FMIJCFDFHAN) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F28D90", Offset = "0x6F27590", VA = "0x186F28D90")]
	private void IAJBOOECLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F28AB0", Offset = "0x6F272B0", VA = "0x186F28AB0")]
	private void CKBDIILAGCP(CJKLDAPLHNE AJNIDCPPJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F28C00", Offset = "0x6F27400", VA = "0x186F28C00", Slot = "4")]
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
