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
using RecRoom.DataLayer.Attributes;
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
	private readonly struct HHHKGLGBEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FBDOGGJMLJJ EGGKLABLHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MBOLGOCFBNP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
		public HHHKGLGBEGA(FBDOGGJMLJJ LCBKFIOCBIM, string BLHNADIJFBC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BOEDCKCIKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public HHHKGLGBEGA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8350", Offset = "0x6BB6D50", VA = "0x186BB8350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8710", Offset = "0x6BB7110", VA = "0x186BB8710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FLGCJFNNCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MLLDFGMFKPE<HHHKGLGBEGA, GameObject> HMDJPLELMBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JOFMLDIAPLB GPLLDPGEIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MLLDFGMFKPE<HHHKGLGBEGA, GameObject> HCGPBJLFBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BB93C0", Offset = "0x6BB7DC0", VA = "0x186BB93C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ANAPEOPCOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9520", Offset = "0x6BB7F20", VA = "0x186BB9520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BB92E0", Offset = "0x6BB7CE0", VA = "0x186BB92E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9860", Offset = "0x6BB8260", VA = "0x186BB9860", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9570", Offset = "0x6BB7F70", VA = "0x186BB9570")]
	[AsyncStateMachine(typeof(BOEDCKCIKGJ))]
	private Task<GameObject> LFOECKKEAJE(HHHKGLGBEGA HOEIIBAFOKI, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9690", Offset = "0x6BB8090", VA = "0x186BB9690")]
	public Task<GameObject> LoadItemAsync(FBDOGGJMLJJ LCBKFIOCBIM, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BB98D0", Offset = "0x6BB82D0", VA = "0x186BB98D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EIMCDFGJOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FBDOGGJMLJJ ENELCLPJGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HJOKAOLFFKP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
		public EIMCDFGJOHE(FBDOGGJMLJJ DBJLAKHGLNO, Texture CGILPHBKMOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HAGKMMJCNKG
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
	private class KDFPFEFCKKG : DMDKAPLFOGD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BFCMFDMJKIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public KDFPFEFCKKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB7AD0", Offset = "0x6BB64D0", VA = "0x186BB7AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB82D0", Offset = "0x6BB6CD0", VA = "0x186BB82D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FBDOGGJMLJJ DBJLAKHGLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture POAEEBPJHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig HLCIEFKEOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken LOIOCMLGMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject PMNCNAHMINM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HABLMKCEIGL<Texture> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6BBD4B0", Offset = "0x6BBBEB0", VA = "0x186BBD4B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD510", Offset = "0x6BBBF10", VA = "0x186BBD510")]
		public KDFPFEFCKKG(FBDOGGJMLJJ DBJLAKHGLNO, RenderTexture POAEEBPJHMD, ImposterRenderConfig HLCIEFKEOMC, CancellationToken LOIOCMLGMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD330", Offset = "0x6BBBD30", VA = "0x186BBD330")]
		[AsyncStateMachine(typeof(BFCMFDMJKIB))]
		private Task<Texture> BEBDMIGDCDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD4A0", Offset = "0x6BBBEA0", VA = "0x186BBD4A0", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD420", Offset = "0x6BBBE20", VA = "0x186BBD420")]
		private static void CBHIBBDCAKK(GameObject PMNCNAHMINM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LFCPJNKLINE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6BBD6D0", Offset = "0x6BBC0D0", VA = "0x186BBD6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private HAGKMMJCNKG size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[CKLIEFGDNGH("size", HAGKMMJCNKG.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
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
	private static int GNFGBKIIKDH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OFDFGOGJCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AHLOFICNPND<GameObject> ECEGKLNCLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private CJIKIHCHPEJ OEIKCNIIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OJIENHCHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NNLLBGLJADF<Texture> HIEKLEDECKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private FBDOGGJMLJJ LNJMMNGOMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HFBLBJAKEIH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int OPOBCFABGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCE10", Offset = "0x6BBB810", VA = "0x186BBCE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCE60", Offset = "0x6BBB860", VA = "0x186BBCE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MALLGHCPLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC6C0", Offset = "0x6BBB0C0", VA = "0x186BBC6C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8890B0", Offset = "0x887AB0", VA = "0x1808890B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FBDOGGJMLJJ ENELCLPJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88B270", Offset = "0x889C70", VA = "0x18088B270")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC470", Offset = "0x6BBAE70", VA = "0x186BBC470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PIIGGMDLJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x18F1AA0", Offset = "0x18F04A0", VA = "0x1818F1AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NIANFBLNGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC8A0", Offset = "0x6BBB2A0", VA = "0x186BBC8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC460", Offset = "0x6BBAE60", VA = "0x186BBC460")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC9E0", Offset = "0x6BBB3E0", VA = "0x186BBC9E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC3E0", Offset = "0x6BBADE0", VA = "0x186BBC3E0")]
	private void ADBHCBBBCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCCE0", Offset = "0x6BBB6E0", VA = "0x186BBCCE0")]
	public void Set(FBDOGGJMLJJ DDINEPEAKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCD30", Offset = "0x6BBB730", VA = "0x186BBCD30")]
	public void Set(Texture CGILPHBKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCCF0", Offset = "0x6BBB6F0", VA = "0x186BBCCF0")]
	public void Set(EIMCDFGJOHE IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC6B0", Offset = "0x6BBB0B0", VA = "0x186BBC6B0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCAE0", Offset = "0x6BBB4E0", VA = "0x186BBCAE0")]
	public void SetInternal(FBDOGGJMLJJ DDINEPEAKME, [Optional] Texture LBPLKHHPONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCAD0", Offset = "0x6BBB4D0", VA = "0x186BBCAD0")]
	public void SetCustomSize(int FLDKNLEGPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8890A0", Offset = "0x887AA0", VA = "0x1808890A0")]
	public void SetAntiAliasing(int DLDLOEHAAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC930", Offset = "0x6BBB330", VA = "0x186BBC930")]
	[AsyncStateMachine(typeof(LFCPJNKLINE))]
	private void IJGNKGGEJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC5D0", Offset = "0x6BBAFD0", VA = "0x186BBC5D0")]
	private void COCBDGKBDNO(Texture CGILPHBKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCD90", Offset = "0x6BBB790", VA = "0x186BBCD90")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, AEEBIDPALBN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float MJHJOCEFOFI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC3A0", Offset = "0x6BBADA0", VA = "0x186BBC3A0")]
	public void SetReferencePoint(Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC1B0", Offset = "0x6BBABB0", VA = "0x186BBC1B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC380", Offset = "0x6BBAD80", VA = "0x186BBC380")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1835AD0", Offset = "0x18344D0", VA = "0x181835AD0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IHGOMPODFME
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static IHGOMPODFME HMNBGJJJMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float BLCIPEAIAJE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2300D50", Offset = "0x22FF750", VA = "0x182300D50")]
	public IHGOMPODFME(float HCDFAJIGEBD)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE310", Offset = "0x6BBCD10", VA = "0x186BBE310", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int AAPHGBFKIDJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OJAAACLOMFF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> AFAIANDMPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KMFOCGLMJDM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD060", Offset = "0x6BBBA60", VA = "0x186BBD060")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCF60", Offset = "0x6BBB960", VA = "0x186BBCF60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD2A0", Offset = "0x6BBBCA0", VA = "0x186BBD2A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FBDOGGJMLJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string ALJKDEOJLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IHGOMPODFME IHGOMPODFME
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NOFOCPPCOCH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AACEIAIELII(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IFDNPFPFGAJ(FBDOGGJMLJJ CGCLEIBHLHF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPINAIACHOJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKGINHMIPAA();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDBHGHMNCPM([Out] NNLLBGLJADF<Texture> PLGMABHBIFK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LILEOEPHGDF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDED0", Offset = "0x6BBC8D0", VA = "0x186BBDED0")]
	public static bool MPDBPEBOEFI(FBDOGGJMLJJ CFMPLMDJEEJ, FBDOGGJMLJJ MCCFKOOMLJI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, AEEBIDPALBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8780", Offset = "0x6BB7180", VA = "0x186BB8780", Slot = "4")]
		public void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AEEBIDPALBN
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HBMIIEGLPAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MIBDDLENIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LPJMONFPELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JOFMLDIAPLB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFIOIEBBMFC(params Type[] CILEIBIPIEM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PHKIGOMJNNO(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PHKIGOMJNNO<T>(T IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PHKIGOMJNNO<T>(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PHKIGOMJNNO(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AJCKOGHHMJA : IDisposable, JOFMLDIAPLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DKCLGPGEOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MIPDCDIJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform AGMBLCLDHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> IMOJCMAEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BPOICPGFEPE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7470", Offset = "0x6BB5E70", VA = "0x186BB7470")]
	[MDINNNLEANF.FIHKBCJDGBK]
	public static void NBLEEGPPBCG(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7690", Offset = "0x6BB6090", VA = "0x186BB7690")]
	[UnityEngine.Scripting.Preserve]
	public AJCKOGHHMJA([LKKACOOMNBP(null)] HBMIIEGLPAO IBFAJHIGKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6D70", Offset = "0x6BB5770", VA = "0x186BB6D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6D20", Offset = "0x6BB5720", VA = "0x186BB6D20", Slot = "5")]
	public void CFIOIEBBMFC(params Type[] CILEIBIPIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7570", Offset = "0x6BB5F70", VA = "0x186BB7570", Slot = "6")]
	public GameObject PHKIGOMJNNO(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3443EB0", Offset = "0x34428B0", VA = "0x183443EB0", Slot = "7")]
	public T PHKIGOMJNNO<T>(T IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34444C0", Offset = "0x3442EC0", VA = "0x1834444C0", Slot = "8")]
	public T PHKIGOMJNNO<T>(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, bool DEBDMJGPIBA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7600", Offset = "0x6BB6000", VA = "0x186BB7600", Slot = "9")]
	public GameObject PHKIGOMJNNO(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3444510", Offset = "0x3442F10", VA = "0x183444510", Slot = "10")]
	public T PHKIGOMJNNO<T>(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3443F40", Offset = "0x3442940", VA = "0x183443F40")]
	private T PHKIGOMJNNO<T>(GameObject IGOFBEPEIGI, Transform KMAENCDMJDN, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA, [Out] GameObject DNGCFPBJJGE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3443A10", Offset = "0x3442410", VA = "0x183443A10")]
	private T JCCJLBEOGJD<T>(GameObject BICFCMICGIH, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6C10", Offset = "0x6BB5610", VA = "0x186BB6C10")]
	private void AKDDICFMAOL(Component ANHGADCFANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6FC0", Offset = "0x6BB59C0", VA = "0x186BB6FC0")]
	private void MEIFNCGJBOM(Component ANHGADCFANN, GNNJABNPOOC LFOFLLOHBIA, bool DEBDMJGPIBA, bool GEOKJPEIJPA, [Optional] Type MPEAEDFBPPL, [Optional] Type JCLKKNJDPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6E50", Offset = "0x6BB5850", VA = "0x186BB6E50")]
	private void LOKAFMGHMFM(GameObject BICFCMICGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GNNJABNPOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> IEOFDIGPEMN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D71F10", Offset = "0x2D70910", VA = "0x182D71F10")]
	public GNNJABNPOOC ODIPBPJKHHK<T>(T LICJENAEAAH)
	{
		return default(GNNJABNPOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D71E00", Offset = "0x2D70800", VA = "0x182D71E00")]
	public T GJMIFHLLDMF<T>(T FABNMHPKJIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D72640", Offset = "0x2D71040", VA = "0x182D72640")]
	public bool OIOKEJAEGIB<T>([Out] T LICJENAEAAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JKHBNJGJNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool AMFCODMEHAJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	public JKHBNJGJNFC(bool IMELBPNPDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BGMHPCFMCLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LNAKNALODFL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8340", Offset = "0x6BB6D40", VA = "0x186BB8340")]
	public BGMHPCFMCLH(bool FGHMOMJEOLL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, AEEBIDPALBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE060", Offset = "0x6BBCA60", VA = "0x186BBE060", Slot = "4")]
		public void PrepareImposter(GNNJABNPOOC LFOFLLOHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds BPJPDEJKLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6BBC020", Offset = "0x6BBAA20", VA = "0x186BBC020")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBFE0", Offset = "0x6BBA9E0", VA = "0x186BBBFE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBFA0", Offset = "0x6BBA9A0", VA = "0x186BBBFA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BBBEB0", Offset = "0x6BBA8B0", VA = "0x186BBBEB0")]
		private void JMLIEIPLPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
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
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6BBDFD0", Offset = "0x6BBC9D0", VA = "0x186BBDFD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6BBDFC0", Offset = "0x6BBC9C0", VA = "0x186BBDFC0")]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCED0", Offset = "0x6BBB8D0", VA = "0x186BBCED0")]
		public void EMAHBEOOBKK(Vector3 NIBPCMOAJKJ, Quaternion CNMCHHEAEGL, float KFJGECKGIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBCF00", Offset = "0x6BBB900", VA = "0x186BBCF00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HBBAMGFBIGL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 HEFDEABPPEO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> BCEFNCOMPFI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> KPBMIOOENLC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera BMOKGHFDBLN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> NMHDOBOIELD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> MGGFFIODKKF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode IKHNOFDPAIB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color NHJPCPAEJCF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color EPHBJLDNPGB;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color NNEILDMHNEL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap PBLGJAAEHMD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool CNNHDJKIODJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> BIEFEEMALJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9BA0", Offset = "0x6BB85A0", VA = "0x186BB9BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> LMJHDKBOPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9BF0", Offset = "0x6BB85F0", VA = "0x186BB9BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera FDOCEGJMFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA9A0", Offset = "0x6BB93A0", VA = "0x186BBA9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9910", Offset = "0x6BB8310", VA = "0x186BB9910")]
	public static void ANDCPOJPNBF(Vector3 KINKPPPOJKE, Quaternion KHPPIOBBJCK, ImposterRenderConfig PNAEAKLFDON, bool AJMOMIGOMBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA680", Offset = "0x6BB9080", VA = "0x186BBA680")]
	private static void HKBMDEPPIIP(Vector3 KINKPPPOJKE, Quaternion KHPPIOBBJCK, URPLight ELALPHIGHHH, ImposterRenderConfig.LightConfig PKIDNPJLHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB7E0", Offset = "0x6BBA1E0", VA = "0x186BBB7E0")]
	public static void NPCEFOCENKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BBABD0", Offset = "0x6BB95D0", VA = "0x186BBABD0")]
	private static void LJLFBKEPLJO(int AGNJGKONNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB630", Offset = "0x6BBA030", VA = "0x186BBB630")]
	public static void NBFIAMBKPDB(ImposterRenderConfig PNAEAKLFDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBB80", Offset = "0x6BBA580", VA = "0x186BBBB80")]
	public static void PODMPCKLFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA270", Offset = "0x6BB8C70", VA = "0x186BBA270")]
	public static void GLILAIFEOBK(GameObject KNDODEPHBAO, RenderTexture POAEEBPJHMD, ImposterRenderConfig PNAEAKLFDON, IHGOMPODFME HJBGOHGLIBF, [Optional] Vector3? PFBHCBGCDKE, [Optional] Vector3? NMAGNNIAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9C40", Offset = "0x6BB8640", VA = "0x186BB9C40")]
	private static void FBMIKCBFKHM(GameObject KNDODEPHBAO, RenderTexture POAEEBPJHMD, ImposterRenderConfig PNAEAKLFDON, IHGOMPODFME HJBGOHGLIBF, Vector3 PFBHCBGCDKE, Vector3 NMAGNNIAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB8C0", Offset = "0x6BBA2C0", VA = "0x186BBB8C0")]
	private static void OCNICNIIIHF(GameObject KNDODEPHBAO, Vector3 PAMOJFEDGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAFE0", Offset = "0x6BB99E0", VA = "0x186BBAFE0")]
	private static void LPCGGIIMHOE(GameObject IGOFBEPEIGI, ImposterRenderConfig PNAEAKLFDON, IHGOMPODFME HJBGOHGLIBF, [Out] Vector3 AKBKBHDKBLP, [Out] Quaternion IFLCMENLOEA, [Out] float BKDJJKEALPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA5B0", Offset = "0x6BB8FB0", VA = "0x186BBA5B0")]
	public static RenderTexture GPFECGCMNEN(int GLAECBJDJFJ, int GBFKBKLFFAE, RenderTextureFormat EPLBBPBANLK = RenderTextureFormat.ARGB32, string IACDFNPFEPC = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct OHCDEKHGMLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public BAEJNDBEMHP IJKDKIJHGNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject DOPBENBLHCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture MALLGHCPLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig MOPCAOOGJNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public IHGOMPODFME IHGOMPODFME;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6BBDFF0", Offset = "0x6BBC9F0", VA = "0x186BBDFF0")]
			public OHCDEKHGMLL(BAEJNDBEMHP GFIAALDPPDM, GameObject DKBOFJHFNIP, RenderTexture POAEEBPJHMD, ImposterRenderConfig HLCIEFKEOMC, IHGOMPODFME HJBGOHGLIBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static MLLDFGMFKPE<OHCDEKHGMLL, RenderTexture> NDALCJIFLBP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<OHCDEKHGMLL> CCACAHIHFMH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PAFFKHFNBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BB8D80", Offset = "0x6BB7780", VA = "0x186BB8D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8EA0", Offset = "0x6BB78A0", VA = "0x186BB8EA0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KNDODEPHBAO, RenderTexture POAEEBPJHMD, ImposterRenderConfig PNAEAKLFDON, IHGOMPODFME HJBGOHGLIBF, CancellationToken LOIOCMLGMKH, bool MEHCLADMJLG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BB88D0", Offset = "0x6BB72D0", VA = "0x186BB88D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8E10", Offset = "0x6BB7810", VA = "0x186BB8E10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8AE0", Offset = "0x6BB74E0", VA = "0x186BB8AE0")]
		private static Task<RenderTexture> CFFBAFKAJKD(OHCDEKHGMLL JAEJPFDCKKO, CancellationToken LOIOCMLGMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BB92A0", Offset = "0x6BB7CA0", VA = "0x186BB92A0")]
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
