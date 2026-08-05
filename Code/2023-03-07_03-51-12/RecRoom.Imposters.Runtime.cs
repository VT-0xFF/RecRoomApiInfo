using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct OMOMNBOPJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KLCNDKEGFMD DOLAINBBPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BPMBBFLJLGH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAABA10", Offset = "0xAAAE10", VA = "0x180AABA10")]
		public OMOMNBOPJMN(KLCNDKEGFMD OOABPPLEILB, string BAMLFEGHNBO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DJAPMJDLCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public OMOMNBOPJMN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6480620", Offset = "0x647FA20", VA = "0x186480620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6480960", Offset = "0x647FD60", VA = "0x186480960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OCLKLMAOEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::MEHADPLHIMF<OMOMNBOPJMN, GameObject> FIOABJIKNIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MENADOELGDO IIOFOGFAFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::MEHADPLHIMF<OMOMNBOPJMN, GameObject> IIKDIPLGCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64813D0", Offset = "0x64807D0", VA = "0x1864813D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CGHJNIFPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64818C0", Offset = "0x6480CC0", VA = "0x1864818C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6481320", Offset = "0x6480720", VA = "0x186481320", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6481850", Offset = "0x6480C50", VA = "0x186481850", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6481700", Offset = "0x6480B00", VA = "0x186481700")]
	[AsyncStateMachine(typeof(DJAPMJDLCCF))]
	private Task<GameObject> ONPPGPDOIAJ(OMOMNBOPJMN IAKPCLLAONO, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6481530", Offset = "0x6480930", VA = "0x186481530")]
	public Task<GameObject> LoadItemAsync(KLCNDKEGFMD OOABPPLEILB, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6481910", Offset = "0x6480D10", VA = "0x186481910")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NAPNPCFOOIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KLCNDKEGFMD HCIHELKPCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture PHNICCCMGMF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
		public NAPNPCFOOIC(KLCNDKEGFMD BJICHNKJHGN, Texture GDDBNPDKFAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NEHMJBIDACP
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class OHNDNGOFNGM : global::EBFIFOIIIII<Texture>, HKEMFAHKOKG, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct APJDAPNJFND : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public OHNDNGOFNGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x647ED90", Offset = "0x647E190", VA = "0x18647ED90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x647F490", Offset = "0x647E890", VA = "0x18647F490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KLCNDKEGFMD BJICHNKJHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture CIBOIPOKABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig PJMOGACFBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken MJMCKAGGCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject LDGNDPMKIHP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NDNJBANLHJC DJFKGCPCPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6484A70", Offset = "0x6483E70", VA = "0x186484A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::HPHDJAFFHCN<Texture> EOONOHAMHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6484BA0", Offset = "0x6483FA0", VA = "0x186484BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task KMHBONKADGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> HOHDFHNOKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6484BF0", Offset = "0x6483FF0", VA = "0x186484BF0")]
		public OHNDNGOFNGM(KLCNDKEGFMD BJICHNKJHGN, RenderTexture CIBOIPOKABF, ImposterRenderConfig PJMOGACFBNB, CancellationToken MJMCKAGGCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6484A80", Offset = "0x6483E80", VA = "0x186484A80")]
		[AsyncStateMachine(typeof(APJDAPNJFND))]
		private Task<Texture> OICHBPGIAPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6484A60", Offset = "0x6483E60", VA = "0x186484A60", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x64849D0", Offset = "0x6483DD0", VA = "0x1864849D0")]
		private static void ALGCJLDKHKH(GameObject LDGNDPMKIHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AHHMKMEJDBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x647E520", Offset = "0x647D920", VA = "0x18647E520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x886DE0", Offset = "0x8861E0", VA = "0x180886DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[IDDCODEHLBF(HLAHMBHIFJM.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NEHMJBIDACP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EGBFEMHJPLI("size", 0)]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture FLMIKFCLAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::LEPCGNJFAKI<GameObject> GIMOKKMHBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private COANNBMMJHK ECGJJDOABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource NFMAFINMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::EBFIFOIIIII<Texture> OHOMMECOMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KLCNDKEGFMD ICKDDKGGAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture NPOEDODCGMK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture NJBIAHCLBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6483F40", Offset = "0x6483340", VA = "0x186483F40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x782E50", Offset = "0x782250", VA = "0x180782E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private KLCNDKEGFMD HCIHELKPCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x845B40", Offset = "0x844F40", VA = "0x180845B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6483D60", Offset = "0x6483160", VA = "0x186483D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PILBAIOEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xEE3B40", Offset = "0xEE2F40", VA = "0x180EE3B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int JGNFJDMDCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6483C60", Offset = "0x6483060", VA = "0x186483C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6483D40", Offset = "0x6483140", VA = "0x186483D40")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64841A0", Offset = "0x64835A0", VA = "0x1864841A0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6483EB0", Offset = "0x64832B0", VA = "0x186483EB0")]
	private void KPJHNAFMJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64844C0", Offset = "0x64838C0", VA = "0x1864844C0")]
	public void Set(KLCNDKEGFMD POABGMIPINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64844D0", Offset = "0x64838D0", VA = "0x1864844D0")]
	public void Set(Texture GDDBNPDKFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64844E0", Offset = "0x64838E0", VA = "0x1864844E0")]
	public void Set(NAPNPCFOOIC FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6483D50", Offset = "0x6483150", VA = "0x186483D50")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64842A0", Offset = "0x64836A0", VA = "0x1864842A0")]
	public void SetInternal(KLCNDKEGFMD POABGMIPINN, [Optional] Texture NFMJKINDNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6484290", Offset = "0x6483690", VA = "0x186484290")]
	public void SetCustomSize(int EGJNLCMNLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9A5810", Offset = "0x9A4C10", VA = "0x1809A5810")]
	public void SetAntiAliasing(int LPCOGJDALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6483C70", Offset = "0x6483070", VA = "0x186483C70")]
	[AsyncStateMachine(typeof(AHHMKMEJDBH))]
	private void APPHLMBKKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64840B0", Offset = "0x64834B0", VA = "0x1864840B0")]
	private void LJDGECLCOBO(Texture GDDBNPDKFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6484520", Offset = "0x6483920", VA = "0x186484520")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HLHOGJDIJEK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float BDMEKKIIEBK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public void PrepareImposter(EONJBMAEGJB PEEIAPNNFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6483C20", Offset = "0x6483020", VA = "0x186483C20")]
	public void SetReferencePoint(Vector3 NIAHCGPKDEH, Quaternion KJCIGGBJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6483A90", Offset = "0x6482E90", VA = "0x186483A90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6483BF0", Offset = "0x6482FF0", VA = "0x186483BF0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x16768D0", Offset = "0x1675CD0", VA = "0x1816768D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DLPAFODIIBP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DLPAFODIIBP HDNCIKAOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float FPNODKNPNHH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F90", Offset = "0x7C6390", VA = "0x1807C6F90")]
	public DLPAFODIIBP(float BACLIAMCFDB)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[IDDCODEHLBF(HLAHMBHIFJM.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int FGIMCFBAOMM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int AGHPMNLMJAD = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> HIICKBDNLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool CDMCDICOCMO;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64846D0", Offset = "0x6483AD0", VA = "0x1864846D0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64845E0", Offset = "0x64839E0", VA = "0x1864845E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6484910", Offset = "0x6483D10", VA = "0x186484910")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KLCNDKEGFMD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JPHHDDILBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DLPAFODIIBP DLPAFODIIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EDMPANFMFGF;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> KFKOJJKCIKA(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDDGLACACKL(KLCNDKEGFMD FJLHJLAMLMA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDGIMHJJFNN();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEJKEECPLOP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AENJFBPJIOF(out global::EBFIFOIIIII<Texture> BDPNDEHDHGD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ANKFDOKKCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x647ECB0", Offset = "0x647E0B0", VA = "0x18647ECB0")]
	public static bool DLEENODHKLJ(KLCNDKEGFMD OLEDPDELNBG, KLCNDKEGFMD BLOLHNICDBG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, HLHOGJDIJEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x64804C0", Offset = "0x647F8C0", VA = "0x1864804C0", Slot = "4")]
		public void PrepareImposter(EONJBMAEGJB PEEIAPNNFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HLHOGJDIJEK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EONJBMAEGJB PEEIAPNNFMK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PINNBIGCGLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HAGELKFCPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> HBPGEILOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MENADOELGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIINOANCJNH(params Type[] AOALHLGMLAI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHPOEIOLNBD(params Type[] AOALHLGMLAI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject DONHALPPKNF(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DONHALPPKNF<T>(T CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T DONHALPPKNF<T>(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DONHALPPKNF(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DONHALPPKNF<T>(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T DONHALPPKNF<T>(T CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BDJNHCGNFOD : IDisposable, MENADOELGDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> DJHECMKIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> EINNNBCIOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform KGAAKEDDHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> AMNLBNDKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GEALBCKFHGD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x647FF80", Offset = "0x647F380", VA = "0x18647FF80")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	public static void NBKPOCLHNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6480080", Offset = "0x647F480", VA = "0x186480080")]
	[Preserve]
	public BDJNHCGNFOD([ANGFGGDOPHE(null)] PINNBIGCGLF INCHHMAACMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x647F600", Offset = "0x647EA00", VA = "0x18647F600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x647FF30", Offset = "0x647F330", VA = "0x18647FF30", Slot = "5")]
	public void MIINOANCJNH(params Type[] AOALHLGMLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x647FC50", Offset = "0x647F050", VA = "0x18647FC50", Slot = "6")]
	public void GHPOEIOLNBD(params Type[] AOALHLGMLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x647F570", Offset = "0x647E970", VA = "0x18647F570", Slot = "7")]
	public GameObject DONHALPPKNF(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32959D0", Offset = "0x3294DD0", VA = "0x1832959D0", Slot = "8")]
	public T DONHALPPKNF<T>(T CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3295A40", Offset = "0x3294E40", VA = "0x183295A40", Slot = "9")]
	public T DONHALPPKNF<T>(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, bool NJNEGGAJPDI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x647F4E0", Offset = "0x647E8E0", VA = "0x18647F4E0", Slot = "10")]
	public GameObject DONHALPPKNF(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3295A70", Offset = "0x3294E70", VA = "0x183295A70", Slot = "11")]
	public T DONHALPPKNF<T>(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3295FF0", Offset = "0x32953F0", VA = "0x183295FF0", Slot = "12")]
	public T DONHALPPKNF<T>(T CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3295AC0", Offset = "0x3294EC0", VA = "0x183295AC0")]
	private T DONHALPPKNF<T>(GameObject CCDPGFIPGOA, Transform CNDFBGEJOLI, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI, out GameObject AODJHBANBOG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3296080", Offset = "0x3295480", VA = "0x183296080")]
	private T LFAPMOCDOIH<T>(GameObject CEPEJEHMODM, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x647FE00", Offset = "0x647F200", VA = "0x18647FE00")]
	private void KKNEJLMCCGK(Component LFAAOBNJLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x647F700", Offset = "0x647EB00", VA = "0x18647F700")]
	private void ENJCCNBGJKK(Component LFAAOBNJLDK, EONJBMAEGJB PEEIAPNNFMK, bool NJNEGGAJPDI, bool FHLHGKHKBAA, [Optional] Type NKHGACDBEPH, [Optional] Type LKAHNHFFDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x647FCA0", Offset = "0x647F0A0", VA = "0x18647FCA0")]
	private void HGCCHNALOGO(GameObject CEPEJEHMODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EONJBMAEGJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> CGDDJENCNCB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F28FC0", Offset = "0x2F283C0", VA = "0x182F28FC0")]
	public EONJBMAEGJB CODPHMBGNGD<T>(T MKABJKLMICD)
	{
		return default(EONJBMAEGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F29E90", Offset = "0x2F29290", VA = "0x182F29E90")]
	public T PEBNPJONHNJ<T>(T IEMLIFLCGLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F296F0", Offset = "0x2F28AF0", VA = "0x182F296F0")]
	public bool KNEMJPBHGAN<T>(out T MKABJKLMICD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AEBDEIAAEBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool GLMIODMNCFC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x9F1FF0", Offset = "0x9F13F0", VA = "0x1809F1FF0")]
	public AEBDEIAAEBN(bool NCLOIAILGMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MIGLGBJNOKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool HFBHIDHCFOD;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64849C0", Offset = "0x6483DC0", VA = "0x1864849C0")]
	public MIGLGBJNOKF(bool CCCMDBJOEHA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, HLHOGJDIJEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6484E00", Offset = "0x6484200", VA = "0x186484E00", Slot = "4")]
		public void PrepareImposter(EONJBMAEGJB PEEIAPNNFMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x64849A0", Offset = "0x6483DA0", VA = "0x1864849A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6484990", Offset = "0x6483D90", VA = "0x186484990")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64845A0", Offset = "0x64839A0", VA = "0x1864845A0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IEPNEABICBJ
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> JDMDICOBPJL;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 LFJENABDFPJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 ICCCEMBMKCG;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera GFIBBGLCBGB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string OCOBHMCEJLL = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const NHGJDFGOGFM ODHHLPPDJJA = NHGJDFGOGFM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> OODAOMJPLGP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode BDMDPBBCFFP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color BIJJALAPAOP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color GNAEKCNFGPE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MNHNAGFDDIE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap IONAJLCGMCG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool GCLDEAENCED;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera CHIHCJMDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6483590", Offset = "0x6482990", VA = "0x186483590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6481B50", Offset = "0x6480F50", VA = "0x186481B50")]
	public static void AECOBFPAANM(Vector3 CCHHAHFAOIA, Quaternion GMOFEHELCPH, ImposterRenderConfig PLIEEHKGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64821A0", Offset = "0x64815A0", VA = "0x1864821A0")]
	private static void CAJAOFBKEKD(Vector3 CCHHAHFAOIA, Quaternion GMOFEHELCPH, URPLight HNMPLNJGLPK, ImposterRenderConfig.LightConfig HBOMANOHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64826F0", Offset = "0x6481AF0", VA = "0x1864826F0")]
	public static void GBMOMDNMPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6482CE0", Offset = "0x64820E0", VA = "0x186482CE0")]
	private static void JEPBDBMKBKE(int IGDEMJOJEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x64837C0", Offset = "0x6482BC0", VA = "0x1864837C0")]
	public static void ODPFAOIMELL(ImposterRenderConfig PLIEEHKGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6481DD0", Offset = "0x64811D0", VA = "0x186481DD0")]
	public static void AKFPNPPOHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6481980", Offset = "0x6480D80", VA = "0x186481980")]
	public static void ABNICGPBOII(GameObject KCCCAJBNGJN, RenderTexture CIBOIPOKABF, ImposterRenderConfig PLIEEHKGOHI, DLPAFODIIBP MPKJPFIEJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64827E0", Offset = "0x6481BE0", VA = "0x1864827E0")]
	private static void IKAHJJPIGFL(GameObject KCCCAJBNGJN, RenderTexture CIBOIPOKABF, ImposterRenderConfig PLIEEHKGOHI, DLPAFODIIBP MPKJPFIEJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x64832E0", Offset = "0x64826E0", VA = "0x1864832E0")]
	private static void MCGJFEKOJJG(GameObject KCCCAJBNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64824B0", Offset = "0x64818B0", VA = "0x1864824B0")]
	public static void CGDEHBIIPDJ(List<Renderer> AOFANHABBEP, List<Material> OPIAMIFOKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6481ED0", Offset = "0x64812D0", VA = "0x186481ED0")]
	public static void BCCKKPJJJHE(GameObject CCDPGFIPGOA, Vector3 IPJAOKKPBLO, Vector3 DJPBECIMLOB, float NHOBPAKPFCF, DLPAFODIIBP MPKJPFIEJIL, out Vector3 NNAAFFDBLDP, out Quaternion IGNENIAPACK, out float CKNAIODCACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6482650", Offset = "0x6481A50", VA = "0x186482650")]
	public static RenderTexture EKOIKFDGMIN(int HIPFHAFHMOD, int BNPPIEMPHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64830B0", Offset = "0x64824B0", VA = "0x1864830B0")]
	public static void JHOLNFOHION()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct PFJPJEONCOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public HAAHJPGNIMD ADBBMJICNMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject GOHBJMPGHNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture NJBIAHCLBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig HJLECCHGACM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public DLPAFODIIBP DLPAFODIIBP;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6484D90", Offset = "0x6484190", VA = "0x186484D90")]
			public PFJPJEONCOB(HAAHJPGNIMD IHAHGKJEDDP, GameObject NDILDKJPKKF, RenderTexture CIBOIPOKABF, ImposterRenderConfig PJMOGACFBNB, DLPAFODIIBP MPKJPFIEJIL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::MEHADPLHIMF<PFJPJEONCOB, RenderTexture> AMLIEPMCAMH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<PFJPJEONCOB> LIAMEEONBKL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HCNPLLPPJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6480DB0", Offset = "0x64801B0", VA = "0x186480DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6480EC0", Offset = "0x64802C0", VA = "0x186480EC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KCCCAJBNGJN, RenderTexture CIBOIPOKABF, ImposterRenderConfig PLIEEHKGOHI, DLPAFODIIBP MPKJPFIEJIL, CancellationToken MJMCKAGGCOI, bool OOFHGANDMDG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64809F0", Offset = "0x647FDF0", VA = "0x1864809F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6480E20", Offset = "0x6480220", VA = "0x186480E20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6480BE0", Offset = "0x647FFE0", VA = "0x186480BE0")]
		private static Task<RenderTexture> MKMIJLKGIPO(PFJPJEONCOB NJFGFMADFAK, CancellationToken MJMCKAGGCOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64812B0", Offset = "0x64806B0", VA = "0x1864812B0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x647E240", Offset = "0x647D640", VA = "0x18647E240")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x647DEF0", Offset = "0x647D2F0", VA = "0x18647DEF0")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
