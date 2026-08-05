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
public static class DGKIDGJIKPB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class LDNAOGGIGOM<T> : CEKHLMGJGCN<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBD80", Offset = "0x2CDAD80", VA = "0x182CDBD80")]
		public LDNAOGGIGOM(AsyncOperationHandle<T> AHGFGCDINOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1371C00", Offset = "0x1370C00", VA = "0x181371C00", Slot = "11")]
		protected override T EACBJALIBBC(T LGLLGNMKJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2E65DC0", Offset = "0x2E64DC0", VA = "0x182E65DC0", Slot = "10")]
		protected sealed override void OFEJGFAAEPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class CBCICKIFIIB<T> : CEKHLMGJGCN<GameObject, T> where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBD80", Offset = "0x2CDAD80", VA = "0x182CDBD80")]
		public CBCICKIFIIB(AsyncOperationHandle<GameObject> AHGFGCDINOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1A517E0", Offset = "0x1A507E0", VA = "0x181A517E0", Slot = "11")]
		protected override T EACBJALIBBC(GameObject LGLLGNMKJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBCF0", Offset = "0x2CDACF0", VA = "0x182CDBCF0", Slot = "10")]
		protected sealed override void OFEJGFAAEPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private abstract class CEKHLMGJGCN<TSource, TTransformed> : AJCOCAEBOKO<Task<TSource>, TTransformed> where TSource : UnityEngine.Object where TTransformed : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TSource> OODHANMHMFJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TSource JKAHOLBDKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9476E0", Offset = "0x9466E0", VA = "0x1809476E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2171B40", Offset = "0x2170B40", VA = "0x182171B40")]
		protected CEKHLMGJGCN(AsyncOperationHandle<TSource> AHGFGCDINOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2171AD0", Offset = "0x2170AD0", VA = "0x182171AD0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2171A40", Offset = "0x2170A40", VA = "0x182171A40", Slot = "9")]
		protected override TTransformed AFIFJMEKNKD(Task<TSource> KAJOBONJCPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract TTransformed EACBJALIBBC(TSource LGLLGNMKJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x221ED90", Offset = "0x221DD90", VA = "0x18221ED90")]
	public static bool BIAHBNKMACB<T>(AssetReference OOIJCHBPIOP, Func<ODFNIKOPOEL<T>> KKANALMNLEO, out ODFNIKOPOEL<T> MBHKFCBBMMP) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x221EE30", Offset = "0x221DE30", VA = "0x18221EE30")]
	public static ODFNIKOPOEL<T> HEHPLJJHGLC<T>([NotNull] AssetReference KAAFFPFFGHB) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x221EF60", Offset = "0x221DF60", VA = "0x18221EF60")]
	public static ODFNIKOPOEL<T> PFLOJKIJEEI<T>([NotNull] AssetReference KAAFFPFFGHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	private static void FKMKGHMDCOA(AssetReference KAAFFPFFGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OPMGLDNIPCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LDMFGBHHMJL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ENOFKANEIOL<T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public LDMFGBHHMJL request;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public ENOFKANEIOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1355EC0", Offset = "0x1354EC0", VA = "0x181355EC0")]
			internal void MIPPPEHGIIJ(T o)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private DCEOCCGJAAG IFJDIAEMNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private object LLJICDKHBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int OELFOMMICNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private UnityEngine.Object KEPNPGBIJPM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int HDEBDCLACNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UnityEngine.Object EDAENNCILHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3324E30", Offset = "0x3323E30", VA = "0x183324E30")]
		public static LDMFGBHHMJL CBLDMMKKNOA<T>(AssetReference OOIJCHBPIOP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3324E70", Offset = "0x3323E70", VA = "0x183324E70")]
		private static LDMFGBHHMJL JJHFIEKLCPF<T>(AssetReference OOIJCHBPIOP, ODFNIKOPOEL<T> KOAEJODCCAA) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		private LDMFGBHHMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72C8210", Offset = "0x72C7210", VA = "0x1872C8210")]
		public void OEBKHFIKLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72C8220", Offset = "0x72C7220", VA = "0x1872C8220")]
		public void POOOJKBMGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72C8150", Offset = "0x72C7150", VA = "0x1872C8150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PCEGEHKGEBA<T> : ODFNIKOPOEL<T>, DCEOCCGJAAG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public Action FEBJBLLPEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool LOOPOECADGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ODFNIKOPOEL<T> JDNAMFAEIIP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Task DPCLBFLPILA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD87EA0", Offset = "0xD86EA0", VA = "0x180D87EA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FHJJKILLDME GLFCFAOKBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9BBA30", Offset = "0x9BAA30", VA = "0x1809BBA30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LJAJHHFEMAM<T> EKPABIIJDMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x32D9910", Offset = "0x32D8910", VA = "0x1832D9910", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Task<T> LDKKGLGFCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x32D99E0", Offset = "0x32D89E0", VA = "0x1832D99E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x32D9A90", Offset = "0x32D8A90", VA = "0x1832D9A90")]
		public PCEGEHKGEBA(ODFNIKOPOEL<T> JDNAMFAEIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x32D9970", Offset = "0x32D8970", VA = "0x1832D9970", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NHKJCBGIALD<T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public LDMFGBHHMJL cachedResourceRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OPMGLDNIPCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public object runtimeKey;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public NHKJCBGIALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2CB75F0", Offset = "0x2CB65F0", VA = "0x182CB75F0")]
		internal void PHMGLHIOALM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OIDLICKKMBF<UnityEngine.Object> GKFFAEGDBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GNKIHMGLNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool LOOPOECADGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<object, LDMFGBHHMJL> ONGAKFIIJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LinkedList<object> BDJKHOAKPPD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72C8630", Offset = "0x72C7630", VA = "0x1872C8630")]
	public OPMGLDNIPCN(int GNKIHMGLNPJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2933970", Offset = "0x2932970", VA = "0x182933970")]
	public ODFNIKOPOEL<T> PFLOJKIJEEI<T>([NotNull] AssetReference KAAFFPFFGHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2933640", Offset = "0x2932640", VA = "0x182933640")]
	private PCEGEHKGEBA<T> FBOKCJKKJAM<T>(AssetReference OOIJCHBPIOP, ODFNIKOPOEL<T> MBHKFCBBMMP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2933700", Offset = "0x2932700", VA = "0x182933700")]
	private PCEGEHKGEBA<T> MEEKBIGDKGL<T>(AssetReference OOIJCHBPIOP, ODFNIKOPOEL<T> MBHKFCBBMMP, Func<AssetReference, LDMFGBHHMJL> MKLGLFJLBJK) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72C83C0", Offset = "0x72C73C0", VA = "0x1872C83C0")]
	private void FDNOFIHNGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72C84E0", Offset = "0x72C74E0", VA = "0x1872C84E0")]
	private void MNDHHANGGGL(LDMFGBHHMJL NJAMEFJLMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72C8230", Offset = "0x72C7230", VA = "0x1872C8230", Slot = "4")]
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
