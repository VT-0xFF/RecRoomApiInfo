using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct FFPLAJMHONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DKFNLOJEGLG PCMFPOEBGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BJPOHEIDEFA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
		public FFPLAJMHONC(DKFNLOJEGLG DBCJEMNLPNE, string DLJMCMIEOLA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MECPJLJEKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FFPLAJMHONC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61DA340", Offset = "0x61D9740", VA = "0x1861DA340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61DA6E0", Offset = "0x61D9AE0", VA = "0x1861DA6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FIPOEODAMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LONIALJHEDA<FFPLAJMHONC, GameObject> LCLAEMKLJJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MCDLMJNJKMB LIBJNJCFBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LONIALJHEDA<FFPLAJMHONC, GameObject> FKMOJDGAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61D7790", Offset = "0x61D6B90", VA = "0x1861D7790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AAHKDANEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61D78F0", Offset = "0x61D6CF0", VA = "0x1861D78F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61D76D0", Offset = "0x61D6AD0", VA = "0x1861D76D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61D7C40", Offset = "0x61D7040", VA = "0x1861D7C40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61D7B20", Offset = "0x61D6F20", VA = "0x1861D7B20")]
	[AsyncStateMachine(typeof(MECPJLJEKKJ))]
	private Task<GameObject> NPKGKMLBHOK(FFPLAJMHONC DDBIJCCBJFH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61D7940", Offset = "0x61D6D40", VA = "0x1861D7940")]
	public Task<GameObject> LoadItemAsync(DKFNLOJEGLG DBCJEMNLPNE, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61D7CB0", Offset = "0x61D70B0", VA = "0x1861D7CB0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EONHBMDCMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DKFNLOJEGLG AGMOPHPLLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture MJABFPFGPNF;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
		public EONHBMDCMOP(DKFNLOJEGLG GEEPDOABGBK, Texture PDOEEEKAPND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum DEKGPFPGFFM
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class AJMPPAOFKDM : GBCLKIFENIG<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FANMAJKDPIL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AJMPPAOFKDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61D7DE0", Offset = "0x61D71E0", VA = "0x1861D7DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61D85F0", Offset = "0x61D79F0", VA = "0x1861D85F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly DKFNLOJEGLG GEEPDOABGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture NDOGOBKLBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MMELANALNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken KNKAEBKAEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject KOCLIMJONFP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JNFFOANFOAP<Texture> CHDAIPGOHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61D5B50", Offset = "0x61D4F50", VA = "0x1861D5B50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> AKPBMMIEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61D5BB0", Offset = "0x61D4FB0", VA = "0x1861D5BB0")]
		public AJMPPAOFKDM(DKFNLOJEGLG GEEPDOABGBK, RenderTexture NDOGOBKLBIH, ImposterRenderConfig MMELANALNDD, CancellationToken KNKAEBKAEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61D59D0", Offset = "0x61D4DD0", VA = "0x1861D59D0")]
		[AsyncStateMachine(typeof(FANMAJKDPIL))]
		private Task<Texture> BBALPAHBOKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61D5B40", Offset = "0x61D4F40", VA = "0x1861D5B40", Slot = "10")]
		protected override void IPAFBDEHFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61D5AC0", Offset = "0x61D4EC0", VA = "0x1861D5AC0")]
		private static void IMBJHIHJLCC(GameObject KOCLIMJONFP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JKONNDAMPJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61D9B50", Offset = "0x61D8F50", VA = "0x1861D9B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private DEKGPFPGFFM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[AEDBOPBHPPO("size", DEKGPFPGFFM.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int LAHDPHEIMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture AKPFNDBNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JMMLJMMPKAA<GameObject> EDFFAJABCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PNIFBLNEOAP JLFHABBAEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MCEEHGKCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private COOEPIMPOKM<Texture> OLDLOKCAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private DKFNLOJEGLG DEKBFIKOLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture KGGFCLGNGMM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int NGGBEHMJKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61D9620", Offset = "0x61D8A20", VA = "0x1861D9620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61D9670", Offset = "0x61D8A70", VA = "0x1861D9670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture LAGGPGONIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61D8EE0", Offset = "0x61D82E0", VA = "0x1861D8EE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A70", Offset = "0x7BFE70", VA = "0x1807C0A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DKFNLOJEGLG AGMOPHPLLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61D9090", Offset = "0x61D8490", VA = "0x1861D9090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CGPKAINAOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52C4DD0", Offset = "0x52C41D0", VA = "0x1852C4DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IMHHEMDNPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61D8CA0", Offset = "0x61D80A0", VA = "0x1861D8CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61D8C10", Offset = "0x61D8010", VA = "0x1861D8C10")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61D91F0", Offset = "0x61D85F0", VA = "0x1861D91F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61D8C20", Offset = "0x61D8020", VA = "0x1861D8C20")]
	private void BGMJCOPIJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61D9540", Offset = "0x61D8940", VA = "0x1861D9540")]
	public void Set(DKFNLOJEGLG OPAPLMPGNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61D94F0", Offset = "0x61D88F0", VA = "0x1861D94F0")]
	public void Set(Texture PDOEEEKAPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61D9500", Offset = "0x61D8900", VA = "0x1861D9500")]
	public void Set(EONHBMDCMOP PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61D8D40", Offset = "0x61D8140", VA = "0x1861D8D40")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61D92F0", Offset = "0x61D86F0", VA = "0x1861D92F0")]
	public void SetInternal(DKFNLOJEGLG OPAPLMPGNPP, [Optional] Texture HAHKGGCCJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61D92E0", Offset = "0x61D86E0", VA = "0x1861D92E0")]
	public void SetCustomSize(int BKMOIGFGLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A90", Offset = "0x7BFE90", VA = "0x1807C0A90")]
	public void SetAntiAliasing(int DLFFCPDOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61D8E30", Offset = "0x61D8230", VA = "0x1861D8E30")]
	[AsyncStateMachine(typeof(JKONNDAMPJA))]
	private void HLDNJEBONHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61D8D50", Offset = "0x61D8150", VA = "0x1861D8D50")]
	private void EIMCNPGGFLB(Texture PDOEEEKAPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61D95A0", Offset = "0x61D89A0", VA = "0x1861D95A0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HCFOPLGHBLA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NIHNKDKFNDJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void PrepareImposter(LENGNCKFEMO PJAECDPFFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61D8BD0", Offset = "0x61D7FD0", VA = "0x1861D8BD0")]
	public void SetReferencePoint(Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61D89D0", Offset = "0x61D7DD0", VA = "0x1861D89D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61D8BB0", Offset = "0x61D7FB0", VA = "0x1861D8BB0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14785A0", Offset = "0x14779A0", VA = "0x1814785A0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKOJBFNEFHH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DKOJBFNEFHH NGFHCFMEJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float MDHBDBKGGMK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DC20", Offset = "0x1F5D020", VA = "0x181F5DC20")]
	public DKOJBFNEFHH(float CMHPKLACAIB)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int ALBBKMLLMHK = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CKPFCEGNBEN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> BMDGEOMHJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool FOFHHAEJHOL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61D9880", Offset = "0x61D8C80", VA = "0x1861D9880")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61D9780", Offset = "0x61D8B80", VA = "0x1861D9780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61D9AC0", Offset = "0x61D8EC0", VA = "0x1861D9AC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DKFNLOJEGLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BKFNOEBGDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DKOJBFNEFHH DKOJBFNEFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HPJDFBOBNOK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NKPBEJPKLDE(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GJIOCCOEGLC(DKFNLOJEGLG MGDPHHCBMMP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCPMCHKPIIJ();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CPEDKGILOIP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BGNAHOCJDDM([Out] COOEPIMPOKM<Texture> CAMJGDOMBJL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EMBNICLLJCN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61D7CF0", Offset = "0x61D70F0", VA = "0x1861D7CF0")]
	public static bool IHEFONGFBHD(DKFNLOJEGLG HCODONHMPNM, DKFNLOJEGLG LICGLMFOAGK)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, HCFOPLGHBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61D6C40", Offset = "0x61D6040", VA = "0x1861D6C40", Slot = "4")]
		public void PrepareImposter(LENGNCKFEMO PJAECDPFFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCFOPLGHBLA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LENGNCKFEMO PJAECDPFFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BJNCEDBHAEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> PPFKKDDHEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> PGAACLJJMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MCDLMJNJKMB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHOMKCHIIJK(params Type[] LHBKDAFFEBF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GONKOMJLLMH(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T GONKOMJLLMH<T>(T DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T GONKOMJLLMH<T>(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject GONKOMJLLMH(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CDLPPDJOBPI : IDisposable, MCDLMJNJKMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> IGGNMGDKHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> NFEIAJBPCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform LEBFBADJDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> OJMIFDMENDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ILMCBACCNDE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61D6590", Offset = "0x61D5990", VA = "0x1861D6590")]
	[AMCIKKJLCIB(HENHDGEOMOC.None)]
	public static void IEDLFPKPNAO(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61D6800", Offset = "0x61D5C00", VA = "0x1861D6800")]
	[Preserve]
	public CDLPPDJOBPI([AKGMOFMFNCG(null)] BJNCEDBHAEN GDJAECBENIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61D6340", Offset = "0x61D5740", VA = "0x1861D6340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61D6420", Offset = "0x61D5820", VA = "0x1861D6420", Slot = "5")]
	public void EHOMKCHIIJK(params Type[] LHBKDAFFEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61D6470", Offset = "0x61D5870", VA = "0x1861D6470", Slot = "6")]
	public GameObject GONKOMJLLMH(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26162F0", Offset = "0x26156F0", VA = "0x1826162F0", Slot = "7")]
	public T GONKOMJLLMH<T>(T DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26162C0", Offset = "0x26156C0", VA = "0x1826162C0", Slot = "8")]
	public T GONKOMJLLMH<T>(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, bool KBICNAAMNMB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61D6500", Offset = "0x61D5900", VA = "0x1861D6500", Slot = "9")]
	public GameObject GONKOMJLLMH(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2615D10", Offset = "0x2615110", VA = "0x182615D10", Slot = "10")]
	public T GONKOMJLLMH<T>(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2615D50", Offset = "0x2615150", VA = "0x182615D50")]
	private T GONKOMJLLMH<T>(GameObject DFNIHHFOHGC, Transform NCGFJMKBOIN, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB, [Out] GameObject NAPNNGDJBJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2615870", Offset = "0x2614C70", VA = "0x182615870")]
	private T EHLDINDMJKF<T>(GameObject LMKHHJAKBGC, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61D5D50", Offset = "0x61D5150", VA = "0x1861D5D50")]
	private void CDENNEPANDI(Component MGFEBOILECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61D5E60", Offset = "0x61D5260", VA = "0x1861D5E60")]
	private void CJFFAPHPFII(Component MGFEBOILECI, LENGNCKFEMO PJAECDPFFJF, bool KBICNAAMNMB, bool IECHAMEDCIH, [Optional] Type GCMCKOCOPAI, [Optional] Type AKMMNCCOJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61D6690", Offset = "0x61D5A90", VA = "0x1861D6690")]
	private void MNHODJFFJFA(GameObject LMKHHJAKBGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LENGNCKFEMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> DFEDODOKLOD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2886E00", Offset = "0x2886200", VA = "0x182886E00")]
	public LENGNCKFEMO NINGCLMMDDO<T>(T KALDLKPHOGF)
	{
		return default(LENGNCKFEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2886CF0", Offset = "0x28860F0", VA = "0x182886CF0")]
	public T EBLDKANKNCA<T>(T DADBDDPBLHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2887530", Offset = "0x2886930", VA = "0x182887530")]
	public bool OPHEKCAINKH<T>([Out] T KALDLKPHOGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LGODFDEAFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool JJNKFMFPKND;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCB3550", Offset = "0xCB2950", VA = "0x180CB3550")]
	public LGODFDEAFJB(bool GBIOBPKMHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NLNIGIKCKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool FHLGPOKONNF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61DCC80", Offset = "0x61DC080", VA = "0x1861DCC80")]
	public NLNIGIKCKOJ(bool INGGCOKGFJO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, HCFOPLGHBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61DCC90", Offset = "0x61DC090", VA = "0x1861DCC90", Slot = "4")]
		public void PrepareImposter(LENGNCKFEMO PJAECDPFFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds JBJDAGMFALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x61D8840", Offset = "0x61D7C40", VA = "0x1861D8840")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61D8800", Offset = "0x61D7C00", VA = "0x1861D8800")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x61D87C0", Offset = "0x61D7BC0", VA = "0x1861D87C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61D86D0", Offset = "0x61D7AD0", VA = "0x1861D86D0")]
		private void DIIPKPDNNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x61DA320", Offset = "0x61D9720", VA = "0x1861DA320")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x61DA310", Offset = "0x61D9710", VA = "0x1861DA310")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x61D96F0", Offset = "0x61D8AF0", VA = "0x1861D96F0")]
		public void FLMLOAEDHCO(Vector3 IKLDDGCGNFP, Quaternion DCHOHBHCBPM, float HLMLKNDGHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x61D9720", Offset = "0x61D8B20", VA = "0x1861D9720")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MGLEIEFIDLG
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Vector3 APFFMJNLNPB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly Vector3 GGGILIHHODF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> DGKNFGFFDKH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> ABJAOHNPMIE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera FJKCNIPMNJI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> OGLDIGGDMPE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> LGMMHFLPIAD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode GMLKNCCJGIH;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color BACBMGEKLOE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color IIHCFHMFGPN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color GGLLEEGNPOJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap MHONKHGFIJB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool IMFNMPDHBFA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> BALAPNMFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61DAB30", Offset = "0x61D9F30", VA = "0x1861DAB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> BPJNGEFKHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61DBC70", Offset = "0x61DB070", VA = "0x1861DBC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LNILEJFNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x61DAE20", Offset = "0x61DA220", VA = "0x1861DAE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61DAB80", Offset = "0x61D9F80", VA = "0x1861DAB80")]
	public static void DGFCMJGDHLE(Vector3 FOEPPLKLMMI, Quaternion AODLBFKELIN, ImposterRenderConfig PJFPGACDMCH, bool FMCPOKODBIO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61DA800", Offset = "0x61D9C00", VA = "0x1861DA800")]
	private static void BDEHCCEBIBM(Vector3 FOEPPLKLMMI, Quaternion AODLBFKELIN, URPLight KENADIKLIOH, ImposterRenderConfig.LightConfig AGECDCOJLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61DB320", Offset = "0x61DA720", VA = "0x1861DB320")]
	public static void GJMCFCBLAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61DC5F0", Offset = "0x61DB9F0", VA = "0x1861DC5F0")]
	private static void PNPLENIKMBL(int HJGKBIEOKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDB0", Offset = "0x61DB1B0", VA = "0x1861DBDB0")]
	public static void PCHLKENCOAO(ImposterRenderConfig PJFPGACDMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61DBCC0", Offset = "0x61DB0C0", VA = "0x1861DBCC0")]
	public static void OOIOCMKKJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61DB400", Offset = "0x61DA800", VA = "0x1861DB400")]
	public static void KLEHBMGNNBD(GameObject IGDKDFMHODF, RenderTexture NDOGOBKLBIH, ImposterRenderConfig PJFPGACDMCH, DKOJBFNEFHH HNOGKNBINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61DB5D0", Offset = "0x61DA9D0", VA = "0x1861DB5D0")]
	private static void LHDBIHCLGJG(GameObject IGDKDFMHODF, RenderTexture NDOGOBKLBIH, ImposterRenderConfig PJFPGACDMCH, DKOJBFNEFHH HNOGKNBINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61DB070", Offset = "0x61DA470", VA = "0x1861DB070")]
	private static void FHJFJAOOFDE(GameObject IGDKDFMHODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61DBF80", Offset = "0x61DB380", VA = "0x1861DBF80")]
	private static void PDJKOFNEJHD(GameObject DFNIHHFOHGC, ImposterRenderConfig PJFPGACDMCH, DKOJBFNEFHH HNOGKNBINDL, [Out] Vector3 DDMDNHJFJFN, [Out] Quaternion OLLDHGMNIGD, [Out] float BCLCAPJKOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61DA750", Offset = "0x61D9B50", VA = "0x1861DA750")]
	public static RenderTexture AMKCEOIFFNP(int HFCLAOHGMLH, int IIHLNELMGED, RenderTextureFormat OFLCCFMHOME = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct GDPHKLJGCNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public IBOPGHHDJFG KNOEPLNBAHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject EDMMJCLBMAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture LAGGPGONIGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig LPAPOKBCJDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public DKOJBFNEFHH DKOJBFNEFHH;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x61D8660", Offset = "0x61D7A60", VA = "0x1861D8660")]
			public GDPHKLJGCNP(IBOPGHHDJFG DEBIBDMFCGM, GameObject EJMHFLJHGOM, RenderTexture NDOGOBKLBIH, ImposterRenderConfig MMELANALNDD, DKOJBFNEFHH HNOGKNBINDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static LONIALJHEDA<GDPHKLJGCNP, RenderTexture> OKEMCMHCBGB;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<GDPHKLJGCNP> EGFAKCLNOLA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int FNPOLHIJKBN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x61D7160", Offset = "0x61D6560", VA = "0x1861D7160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61D7270", Offset = "0x61D6670", VA = "0x1861D7270")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IGDKDFMHODF, RenderTexture NDOGOBKLBIH, ImposterRenderConfig PJFPGACDMCH, DKOJBFNEFHH HNOGKNBINDL, CancellationToken KNKAEBKAEBM, bool ILPEKBNJJID = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61D6DD0", Offset = "0x61D61D0", VA = "0x1861D6DD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61D71D0", Offset = "0x61D65D0", VA = "0x1861D71D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61D6FC0", Offset = "0x61D63C0", VA = "0x1861D6FC0")]
		private static Task<RenderTexture> BKIENLOIHOJ(GDPHKLJGCNP KELIMKKPOIG, CancellationToken KNKAEBKAEBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61D7690", Offset = "0x61D6A90", VA = "0x1861D7690")]
		public DeferredImposterRenderer()
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
