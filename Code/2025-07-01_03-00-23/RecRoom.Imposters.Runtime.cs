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
using RecRoom.DataLayer.Registration;
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
	private readonly struct OOKEGPLAJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LCMCKJDOEIK FGPHKPEBOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string KNEGKBBPKJH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
		public OOKEGPLAJON(LCMCKJDOEIK NGAHJHKOJGK, string OLAMKOHKMJF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NFKNDDGJBLK : IAsyncStateMachine
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
		public OOKEGPLAJON queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8C10", Offset = "0x7FE7210", VA = "0x187FE8C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8FD0", Offset = "0x7FE75D0", VA = "0x187FE8FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider ABCJMLPCDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LMAGCMKNGEA<OOKEGPLAJON, GameObject> NGNLAPDFCBH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LLJDEAGEKFO EGOCDGHOKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LMAGCMKNGEA<OOKEGPLAJON, GameObject> MBKOJDIFFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4A30", Offset = "0x7FE3030", VA = "0x187FE4A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IMNJLNLAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4C70", Offset = "0x7FE3270", VA = "0x187FE4C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B90", Offset = "0x7FE3190", VA = "0x187FE4B90", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4E90", Offset = "0x7FE3490", VA = "0x187FE4E90", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F00", Offset = "0x7FE3500", VA = "0x187FE4F00")]
	[AsyncStateMachine(typeof(NFKNDDGJBLK))]
	private Task<GameObject> PGGHPAIGEEB(OOKEGPLAJON DDMBHGGOFNM, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4CC0", Offset = "0x7FE32C0", VA = "0x187FE4CC0")]
	public Task<GameObject> LoadItemAsync(LCMCKJDOEIK NGAHJHKOJGK, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5020", Offset = "0x7FE3620", VA = "0x187FE5020")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EBGKMNKMJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LCMCKJDOEIK GCEGMILGHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture ENMOEDEGMPB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
		public EBGKMNKMJJE(LCMCKJDOEIK HKGONEEKJKB, Texture OEJKMPDBJDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum FBACJLOCOJF
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
	private class ANPNLEPIIGJ : IDJEJKJJLCA<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IIHGNHAKLJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ANPNLEPIIGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5140", Offset = "0x7FE3740", VA = "0x187FE5140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5930", Offset = "0x7FE3F30", VA = "0x187FE5930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LCMCKJDOEIK HKGONEEKJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LPBABFJGBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig KOELNHGEMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken KMHHNOGHBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D GGNNKEOKIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject CKKCCJLODHG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override EHBLMFNEKIG<Texture2D> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3B20", Offset = "0x7FE2120", VA = "0x187FE3B20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3C70", Offset = "0x7FE2270", VA = "0x187FE3C70")]
		public ANPNLEPIIGJ(LCMCKJDOEIK HKGONEEKJKB, RenderTexture LPBABFJGBBG, ImposterRenderConfig KOELNHGEMBK, CancellationToken KMHHNOGHBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3B80", Offset = "0x7FE2180", VA = "0x187FE3B80")]
		[AsyncStateMachine(typeof(IIHGNHAKLJH))]
		private Task<Texture2D> OPEHIIFBIEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3A70", Offset = "0x7FE2070", VA = "0x187FE3A70", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3AA0", Offset = "0x7FE20A0", VA = "0x187FE3AA0")]
		private static void JEHFEPLIDAL(GameObject CKKCCJLODHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KFGHLNOPGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8390", Offset = "0x7FE6990", VA = "0x187FE8390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
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
	[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private FBACJLOCOJF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CEFLHEHDIBA("size", FBACJLOCOJF.Custom)]
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
	private static int KBGHFAOLBNN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture DDAFAHLBIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NCIJAANJNLH<GameObject> DDEBHJLIDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BKFKILCGELM CMBNAMMEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PCGMGJPANKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MODONOMENDG<Texture2D> IHGHIPMCMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LCMCKJDOEIK GECNOGEFACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture NNODJFACINH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int HPGFPGEMGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6900", Offset = "0x7FE4F00", VA = "0x187FE6900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6950", Offset = "0x7FE4F50", VA = "0x187FE6950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CCADCFIHNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6300", Offset = "0x7FE4900", VA = "0x187FE6300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LCMCKJDOEIK GCEGMILGHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5ED0", Offset = "0x7FE44D0", VA = "0x187FE5ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool ANPBEOIDIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x238B910", Offset = "0x2389F10", VA = "0x18238B910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HGGCFLMPLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6100", Offset = "0x7FE4700", VA = "0x187FE6100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6030", Offset = "0x7FE4630", VA = "0x187FE6030")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FE64E0", Offset = "0x7FE4AE0", VA = "0x187FE64E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6280", Offset = "0x7FE4880", VA = "0x187FE6280")]
	private void JIPBJGAMBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6820", Offset = "0x7FE4E20", VA = "0x187FE6820")]
	public void Set(LCMCKJDOEIK ALDPGCCGGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FE67D0", Offset = "0x7FE4DD0", VA = "0x187FE67D0")]
	public void Set(Texture OEJKMPDBJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE67E0", Offset = "0x7FE4DE0", VA = "0x187FE67E0")]
	public void Set(EBGKMNKMJJE KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE60F0", Offset = "0x7FE46F0", VA = "0x187FE60F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE65E0", Offset = "0x7FE4BE0", VA = "0x187FE65E0")]
	public void SetInternal(LCMCKJDOEIK ALDPGCCGGKI, [Optional] Texture EBCCJACHLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE65D0", Offset = "0x7FE4BD0", VA = "0x187FE65D0")]
	public void SetCustomSize(int LKBKAJOLAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
	public void SetAntiAliasing(int JLGOLMNAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6040", Offset = "0x7FE4640", VA = "0x187FE6040")]
	[AsyncStateMachine(typeof(KFGHLNOPGIM))]
	private void CLGPGKODLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FE61A0", Offset = "0x7FE47A0", VA = "0x187FE61A0")]
	private void FEMHDFLIBGJ(Texture OEJKMPDBJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6880", Offset = "0x7FE4E80", VA = "0x187FE6880")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, CDOPBNLNFEI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float GMBKPNAEDHE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void PrepareImposter(JFJNMHOAOEJ MJNKOFMOBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5E90", Offset = "0x7FE4490", VA = "0x187FE5E90")]
	public void SetReferencePoint(Vector3 GCBLNLANCOF, Quaternion EFCAEMFMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5CA0", Offset = "0x7FE42A0", VA = "0x187FE5CA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5E70", Offset = "0x7FE4470", VA = "0x187FE5E70")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x201D6C0", Offset = "0x201BCC0", VA = "0x18201D6C0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AGHGLHIILPI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static AGHGLHIILPI HBOGHLGBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float GINPMCDEHNC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDDD0", Offset = "0x2BCC3D0", VA = "0x182BCDDD0")]
	public AGHGLHIILPI(float CPHKKJJKECN)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBBA0", Offset = "0x7FEA1A0", VA = "0x187FEBBA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
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
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OBPPGDIEMDB = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int PEFHLAEPNLM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> EOLDMKCDIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HPPNKEKKOPL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6B70", Offset = "0x7FE5170", VA = "0x187FE6B70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6A70", Offset = "0x7FE5070", VA = "0x187FE6A70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6DB0", Offset = "0x7FE53B0", VA = "0x187FE6DB0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LCMCKJDOEIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string EACBBOFKLJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AGHGLHIILPI AGHGLHIILPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HOEAHLBEHMF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> KCKKLEBMCDL(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JAHNLJOHFKI(LCMCKJDOEIK HOPHFOOKMCC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJPJHGKAIFO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGNGNGPFPBI();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GLKHJDIADOP(uint? KMJOIHHFOKF, [Out] MODONOMENDG<Texture2D> LLAINGFBICB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EMEDHGCNNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FE5060", Offset = "0x7FE3660", VA = "0x187FE5060")]
	public static bool ELNELMPHOGN(LCMCKJDOEIK ICBACBAHJBK, LCMCKJDOEIK MMOKCPKKDIL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, CDOPBNLNFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3EA0", Offset = "0x7FE24A0", VA = "0x187FE3EA0", Slot = "4")]
		public void PrepareImposter(JFJNMHOAOEJ MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CDOPBNLNFEI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JFJNMHOAOEJ MJNKOFMOBDK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CLCMELJBKAI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KIIMLJDEHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EGJPPGBIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LLJDEAGEKFO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEEEEFPECCB(params Type[] OEDMOOBGNPD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PHDABBJDHHF(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PHDABBJDHHF<T>(T KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PHDABBJDHHF<T>(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PHDABBJDHHF(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JEODGGHIOFL : IDisposable, LLJDEAGEKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> EFDKBDPPOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> IGOMJFGIMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform APCGCBGEPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> PMEMLOJPDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FJLOBIBMLFN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE75F0", Offset = "0x7FE5BF0", VA = "0x187FE75F0")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	public static void GLAOIPJFGAH(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7F00", Offset = "0x7FE6500", VA = "0x187FE7F00")]
	[UnityEngine.Scripting.Preserve]
	public JEODGGHIOFL([GGNLMCAPMLP(null)] CLCMELJBKAI INOEACHBCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7070", Offset = "0x7FE5670", VA = "0x187FE7070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FE76E0", Offset = "0x7FE5CE0", VA = "0x187FE76E0", Slot = "5")]
	public void LEEEEFPECCB(params Type[] OEDMOOBGNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7C70", Offset = "0x7FE6270", VA = "0x187FE7C70", Slot = "6")]
	public GameObject PHDABBJDHHF(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B6F0", Offset = "0x3B99CF0", VA = "0x183B9B6F0", Slot = "7")]
	public T PHDABBJDHHF<T>(T KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B6C0", Offset = "0x3B99CC0", VA = "0x183B9B6C0", Slot = "8")]
	public T PHDABBJDHHF<T>(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, bool HKHMCOAPIFF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D00", Offset = "0x7FE6300", VA = "0x187FE7D00", Slot = "9")]
	public GameObject PHDABBJDHHF(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B680", Offset = "0x3B99C80", VA = "0x183B9B680", Slot = "10")]
	public T PHDABBJDHHF<T>(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B760", Offset = "0x3B99D60", VA = "0x183B9B760")]
	private T PHDABBJDHHF<T>(GameObject KFAEMGBGGCC, Transform NBIJLPJHNNE, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF, [Out] GameObject GPAAJCJBPKM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B390", Offset = "0x3B99990", VA = "0x183B9B390")]
	private T FPIIHOIKGMI<T>(GameObject KGMBEOBCDCB, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6E40", Offset = "0x7FE5440", VA = "0x187FE6E40")]
	private void AEGGFAKMJOJ(JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7150", Offset = "0x7FE5750", VA = "0x187FE7150")]
	private void FIKJDFFLFMN(JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7B60", Offset = "0x7FE6160", VA = "0x187FE7B60")]
	private void PGPNOPAFOPJ(Component DNCHHBPCLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7380", Offset = "0x7FE5980", VA = "0x187FE7380")]
	private void FIKJDFFLFMN(Component DNCHHBPCLHH, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF, bool OAPNFEHKINJ, [Optional] Type HCPMJLCGIGM, [Optional] Type KOIBKGAOAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7730", Offset = "0x7FE5D30", VA = "0x187FE7730")]
	private void OJIBEDAAKFF(Component DNCHHBPCLHH, JFJNMHOAOEJ MJNKOFMOBDK, bool HKHMCOAPIFF, bool OAPNFEHKINJ, [Optional] Type HCPMJLCGIGM, [Optional] Type KOIBKGAOAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D90", Offset = "0x7FE6390", VA = "0x187FE7D90")]
	private void PIOFBBOEGAI(GameObject KGMBEOBCDCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JFJNMHOAOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> GJEKOKOKHFC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C9C0", Offset = "0x3B9AFC0", VA = "0x183B9C9C0")]
	public JFJNMHOAOEJ BNAKHNGOEHD<T>(T PMMDIAMMAAG)
	{
		return default(JFJNMHOAOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D0F0", Offset = "0x3B9B6F0", VA = "0x183B9D0F0")]
	public T KBGIPADPFGF<T>(T COMAGLLDBOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D200", Offset = "0x3B9B800", VA = "0x183B9D200")]
	public bool MGMGGGDLPBE<T>([Out] T PMMDIAMMAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8340", Offset = "0x7FE6940", VA = "0x187FE8340")]
	public void HHCEOPNNHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NHLCPPNNFAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MPPLIACFDAN;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
	public NHLCPPNNFAE(bool IFLLDENENPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LELKBLAMBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool DDBPONDFDOK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8BD0", Offset = "0x7FE71D0", VA = "0x187FE8BD0")]
	public LELKBLAMBPP(bool KKMEHPFKKKM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, CDOPBNLNFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB8E0", Offset = "0x7FE9EE0", VA = "0x187FEB8E0", Slot = "4")]
		public void PrepareImposter(JFJNMHOAOEJ MJNKOFMOBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds ILCBLDGNBOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5B10", Offset = "0x7FE4110", VA = "0x187FE5B10")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5AD0", Offset = "0x7FE40D0", VA = "0x187FE5AD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5A90", Offset = "0x7FE4090", VA = "0x187FE5A90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE59A0", Offset = "0x7FE3FA0", VA = "0x187FE59A0")]
		private void DCGAINKMNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
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
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7FE8BF0", Offset = "0x7FE71F0", VA = "0x187FE8BF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7FE8BE0", Offset = "0x7FE71E0", VA = "0x187FE8BE0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[CEFLHEHDIBA("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[CEFLHEHDIBA("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE69D0", Offset = "0x7FE4FD0", VA = "0x187FE69D0")]
		public void ADKIMCKLLHA(Vector3 CNCEFCLMGKJ, Quaternion DPFKDGBFOLI, float BNOOJPJFCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6A00", Offset = "0x7FE5000", VA = "0x187FE6A00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class PBDNNCPEJKF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 HKIHCOMBGJI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> DJKLAOBEHPO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> NNILFINKKFE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera PBGHPOLGPED;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> EEILAIGJFID;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> NPIEMKHCKJM;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode GNPNFJAGIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color PLKGEDKDLGD;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color NECJOALHMKN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color GCPEEPKOOFH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap CGKHACAPBGA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool OHAPPOLPKHF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> EKCKIPGEJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAFE0", Offset = "0x7FE95E0", VA = "0x187FEAFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KGBDDNGLAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9120", Offset = "0x7FE7720", VA = "0x187FE9120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GCDDAOANFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB460", Offset = "0x7FE9A60", VA = "0x187FEB460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA970", Offset = "0x7FE8F70", VA = "0x187FEA970")]
	public static void JAGGDPBHPMN(Vector3 LEKBDGHPIFI, Quaternion KFJPAGPLPDK, ImposterRenderConfig EMHDBFDFMNN, bool KJDBHJOLGMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9580", Offset = "0x7FE7B80", VA = "0x187FE9580")]
	private static void FIIIDDHMAFL(Vector3 LEKBDGHPIFI, Quaternion KFJPAGPLPDK, URPLight JBHAHCFDCAK, ImposterRenderConfig.LightConfig FFLOCKLBNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9040", Offset = "0x7FE7640", VA = "0x187FE9040")]
	public static void AFHMMFLBKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB030", Offset = "0x7FE9630", VA = "0x187FEB030")]
	private static void ONOIFGNELAA(int CANGABJLFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA270", Offset = "0x7FE8870", VA = "0x187FEA270")]
	public static void HNNPFBCLBFF(ImposterRenderConfig EMHDBFDFMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAC10", Offset = "0x7FE9210", VA = "0x187FEAC10")]
	public static void JAHGBEMJMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9240", Offset = "0x7FE7840", VA = "0x187FE9240")]
	public static void FHLJNNDDCDA(GameObject DDLNDNHEMLC, RenderTexture LPBABFJGBBG, ImposterRenderConfig EMHDBFDFMNN, AGHGLHIILPI IAPIBBPCOLD, [Optional] Vector3? DAIIPKDEJCI, [Optional] Vector3? GOCFBOHLNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9C10", Offset = "0x7FE8210", VA = "0x187FE9C10")]
	private static void HHJGMDPKGBF(GameObject DDLNDNHEMLC, RenderTexture LPBABFJGBBG, ImposterRenderConfig EMHDBFDFMNN, AGHGLHIILPI IAPIBBPCOLD, Vector3 DAIIPKDEJCI, Vector3 GOCFBOHLNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAD00", Offset = "0x7FE9300", VA = "0x187FEAD00")]
	private static void JNCDBGJAIIB(GameObject DDLNDNHEMLC, Vector3 PBGOLAAIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE98A0", Offset = "0x7FE7EA0", VA = "0x187FE98A0")]
	public static void GLBCKIINKPC(Bounds KCLIOAHGAOO, ImposterRenderConfig EMHDBFDFMNN, [Out] Vector3 MIGIOFFHKNE, [Out] Quaternion NGKJJHOKDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA440", Offset = "0x7FE8A40", VA = "0x187FEA440")]
	private static void ILHPJHDJBDJ(GameObject KFAEMGBGGCC, ImposterRenderConfig EMHDBFDFMNN, AGHGLHIILPI IAPIBBPCOLD, [Out] Vector3 MIGIOFFHKNE, [Out] Quaternion NGKJJHOKDLA, [Out] float PFLLDNJMJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9170", Offset = "0x7FE7770", VA = "0x187FE9170")]
	public static RenderTexture EFBEAPODGFG(int CHNPEPOPPAN, int NFMKPLMDKDE, RenderTextureFormat MCLEKLAABMK = RenderTextureFormat.ARGB32, string NCLIGMFNIHE = "[ImposterRendering]Preview")
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
		public struct CLENINGJMGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public KIAJLCGDOBP GFPMJLAJEOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject PIBIIOKIHBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture CCADCFIHNIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig KPHDMFLJCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AGHGLHIILPI AGHGLHIILPI;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3E30", Offset = "0x7FE2430", VA = "0x187FE3E30")]
			public CLENINGJMGJ(KIAJLCGDOBP ENPLACLNBKG, GameObject CEMJEKEPBHO, RenderTexture LPBABFJGBBG, ImposterRenderConfig KOELNHGEMBK, AGHGLHIILPI IAPIBBPCOLD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static LMAGCMKNGEA<CLENINGJMGJ, RenderTexture> GFDLPKFAGEE;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<CLENINGJMGJ> MOHDPGJEDDP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int FFHPCEIBPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7FE44A0", Offset = "0x7FE2AA0", VA = "0x187FE44A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FE45D0", Offset = "0x7FE2BD0", VA = "0x187FE45D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DDLNDNHEMLC, RenderTexture LPBABFJGBBG, ImposterRenderConfig EMHDBFDFMNN, AGHGLHIILPI IAPIBBPCOLD, CancellationToken KMHHNOGHBLL, bool AHIPMABKDDG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3FF0", Offset = "0x7FE25F0", VA = "0x187FE3FF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4530", Offset = "0x7FE2B30", VA = "0x187FE4530", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4200", Offset = "0x7FE2800", VA = "0x187FE4200")]
		private static Task<RenderTexture> HAHIMINPOIG(CLENINGJMGJ KHBAFAPJFKD, CancellationToken KMHHNOGHBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE49F0", Offset = "0x7FE2FF0", VA = "0x187FE49F0")]
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
