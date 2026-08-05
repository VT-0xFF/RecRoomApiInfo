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
	private readonly struct AELCFMONILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IENELHODJHM BOHCHCFLGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ADEJLEBKGFO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
		public AELCFMONILF(IENELHODJHM FDMPLKMJJJA, string MIHAJKBEPGJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HBFPPLGBOLN : IAsyncStateMachine
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
		public AELCFMONILF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x761D1E0", Offset = "0x761C5E0", VA = "0x18761D1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x761D5A0", Offset = "0x761C9A0", VA = "0x18761D5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FELOJKNLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IONONCKAOIB<AELCFMONILF, GameObject> DOEMLLIOIDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IMNHIFEBAKH JJNFNHBPFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IONONCKAOIB<AELCFMONILF, GameObject> HFNEGOMCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x761CF90", Offset = "0x761C390", VA = "0x18761CF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int MJNAPAOANJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x761CB70", Offset = "0x761BF70", VA = "0x18761CB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x761CBC0", Offset = "0x761BFC0", VA = "0x18761CBC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x761D0F0", Offset = "0x761C4F0", VA = "0x18761D0F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x761CCA0", Offset = "0x761C0A0", VA = "0x18761CCA0")]
	[AsyncStateMachine(typeof(HBFPPLGBOLN))]
	private Task<GameObject> JLCKFBPJOLN(AELCFMONILF KMBJPPCBIIM, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x761CDC0", Offset = "0x761C1C0", VA = "0x18761CDC0")]
	public Task<GameObject> LoadItemAsync(IENELHODJHM FDMPLKMJJJA, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x761D160", Offset = "0x761C560", VA = "0x18761D160")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DBKNHBPPJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IENELHODJHM MDFEONEIKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture CDNOOEDFGME;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
		public DBKNHBPPJEI(IENELHODJHM GFBGAJGGCAI, Texture LEFNCCFPOML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KHHCGJGCHID
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
	private class JDPDEBEICEB : FJHDJJOMPAH<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct JIOBNHMLGFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JDPDEBEICEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x761F690", Offset = "0x761EA90", VA = "0x18761F690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x761FE80", Offset = "0x761F280", VA = "0x18761FE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IENELHODJHM GFBGAJGGCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture HABAMJCDGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig ENAANIFDIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MLAPMBKLAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D JKCNOPGAJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject NODILPCIKGK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HHPFDJMLPAL<Texture2D> MCFAFOBMDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x761EB40", Offset = "0x761DF40", VA = "0x18761EB40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BMIMNALOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x761EC90", Offset = "0x761E090", VA = "0x18761EC90")]
		public JDPDEBEICEB(IENELHODJHM GFBGAJGGCAI, RenderTexture HABAMJCDGJA, ImposterRenderConfig ENAANIFDIEI, CancellationToken MLAPMBKLAOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x761EBA0", Offset = "0x761DFA0", VA = "0x18761EBA0")]
		[AsyncStateMachine(typeof(JIOBNHMLGFG))]
		private Task<Texture2D> OOIBHFNOBLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x761EA90", Offset = "0x761DE90", VA = "0x18761EA90", Slot = "10")]
		protected override void BEBNKEGBJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x761EAC0", Offset = "0x761DEC0", VA = "0x18761EAC0")]
		private static void BPJCOBCJOJF(GameObject NODILPCIKGK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JHKOPMDDHBM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x761EE50", Offset = "0x761E250", VA = "0x18761EE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
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
	[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private KHHCGJGCHID size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[OLNOPNKGMIO("size", KHHCGJGCHID.Custom)]
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
	private static int LPCPAIBILHG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture IKPDGIEHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NJHAJBJOLLL<GameObject> PJEOFCOBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NFJKMPPPDKA PJGMIKCPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource GBICCIOOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private JCAOOGBCPCO<Texture2D> OBPDAIFGLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private IENELHODJHM LABFFEABGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MFCFNGILGDN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AAEHDPCGHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x761E560", Offset = "0x761D960", VA = "0x18761E560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x761E5B0", Offset = "0x761D9B0", VA = "0x18761E5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture ALCGEGMLCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x761DCC0", Offset = "0x761D0C0", VA = "0x18761DCC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96A730", Offset = "0x969B30", VA = "0x18096A730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IENELHODJHM MDFEONEIKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9650B0", Offset = "0x9644B0", VA = "0x1809650B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x761DB50", Offset = "0x761CF50", VA = "0x18761DB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool BAPKNLPGCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F84D40", Offset = "0x1F84140", VA = "0x181F84D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DFICMNAAAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x761E000", Offset = "0x761D400", VA = "0x18761E000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x761DB40", Offset = "0x761CF40", VA = "0x18761DB40")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x761E140", Offset = "0x761D540", VA = "0x18761E140")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x761DEA0", Offset = "0x761D2A0", VA = "0x18761DEA0")]
	private void HCLALFFKGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x761E440", Offset = "0x761D840", VA = "0x18761E440")]
	public void Set(IENELHODJHM BBJJPHOJELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x761E430", Offset = "0x761D830", VA = "0x18761E430")]
	public void Set(Texture LEFNCCFPOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x761E450", Offset = "0x761D850", VA = "0x18761E450")]
	public void Set(DBKNHBPPJEI PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x761DCB0", Offset = "0x761D0B0", VA = "0x18761DCB0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x761E240", Offset = "0x761D640", VA = "0x18761E240")]
	public void SetInternal(IENELHODJHM BBJJPHOJELH, [Optional] Texture HCMBKONMJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x761E230", Offset = "0x761D630", VA = "0x18761E230")]
	public void SetCustomSize(int DJIBIKKLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9700A0", Offset = "0x96F4A0", VA = "0x1809700A0")]
	public void SetAntiAliasing(int MGKCKDBJNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x761E090", Offset = "0x761D490", VA = "0x18761E090")]
	[AsyncStateMachine(typeof(JHKOPMDDHBM))]
	private void OFBDMAGHAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x761DF20", Offset = "0x761D320", VA = "0x18761DF20")]
	private void IELGKNMEGHO(Texture LEFNCCFPOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x761E4E0", Offset = "0x761D8E0", VA = "0x18761E4E0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, CIODNICBKML
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float MCLJHAACBMD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void PrepareImposter(KPPJBIANBDM GAPCIOOOOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x761DB00", Offset = "0x761CF00", VA = "0x18761DB00")]
	public void SetReferencePoint(Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x761D910", Offset = "0x761CD10", VA = "0x18761D910")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x761DAE0", Offset = "0x761CEE0", VA = "0x18761DAE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C7B3D0", Offset = "0x1C7A7D0", VA = "0x181C7B3D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EKOCCEHCMHI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static EKOCCEHCMHI NDMIEDMELHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float PMKMMBFABAJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27C3650", Offset = "0x27C2A50", VA = "0x1827C3650")]
	public EKOCCEHCMHI(float POFCEMEIPKA)
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
		[Cpp2IlInjected.Address(RVA = "0x7622A40", Offset = "0x7621E40", VA = "0x187622A40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
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
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int DOEOBIPGMGC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int DGAHEIBMNOC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> CJJJBKDINJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool NHPFCBKFBOP;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x761E7C0", Offset = "0x761DBC0", VA = "0x18761E7C0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x761E6C0", Offset = "0x761DAC0", VA = "0x18761E6C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x761EA00", Offset = "0x761DE00", VA = "0x18761EA00")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IENELHODJHM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NEOGBPKFFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKOCCEHCMHI EKOCCEHCMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PGDAOCODHOO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> PJPHKDMMHAK(CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKIBNJDMILP(IENELHODJHM MNALNBMKJLK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIIHKNJFFOP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFEIMLKOPAN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPNNENIPILC(uint? AEDJBFGBDNK, [Out] JCAOOGBCPCO<Texture2D> GKMGIMBMAIC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OGOENKCCONC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76226B0", Offset = "0x7621AB0", VA = "0x1876226B0")]
	public static bool ONEGFNAOOAG(IENELHODJHM GJFEFABKMFN, IENELHODJHM OKKEBAAANNI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, CIODNICBKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x761C010", Offset = "0x761B410", VA = "0x18761C010", Slot = "4")]
		public void PrepareImposter(KPPJBIANBDM GAPCIOOOOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CIODNICBKML
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KPPJBIANBDM GAPCIOOOOMF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JNGFCLHGHEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KMJDECBNMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> AENJHGOEDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IMNHIFEBAKH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCJBPFEOJPG(params Type[] HFIFCJLIHKJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject LDLLKHOJGKA(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LDLLKHOJGKA<T>(T EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LDLLKHOJGKA<T>(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject LDLLKHOJGKA(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CPBNCIEHBPC : IDisposable, IMNHIFEBAKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> CMBNKHOMCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> ECIDCCGOLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform DKALFBFPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> BIFCAEBPPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> AHALFMFKGMO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x761BAE0", Offset = "0x761AEE0", VA = "0x18761BAE0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	public static void PPNAAKNMPKA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x761BBD0", Offset = "0x761AFD0", VA = "0x18761BBD0")]
	[UnityEngine.Scripting.Preserve]
	public CPBNCIEHBPC([PNFCCJKFMBH(null)] JNGFCLHGHEJ IOMFBCOPKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x761B160", Offset = "0x761A560", VA = "0x18761B160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x761B240", Offset = "0x761A640", VA = "0x18761B240", Slot = "5")]
	public void KCJBPFEOJPG(params Type[] HFIFCJLIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x761B290", Offset = "0x761A690", VA = "0x18761B290", Slot = "6")]
	public GameObject LDLLKHOJGKA(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32972F0", Offset = "0x32966F0", VA = "0x1832972F0", Slot = "7")]
	public T LDLLKHOJGKA<T>(T EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32972A0", Offset = "0x32966A0", VA = "0x1832972A0", Slot = "8")]
	public T LDLLKHOJGKA<T>(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, bool GOCENJIBMJC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x761B320", Offset = "0x761A720", VA = "0x18761B320", Slot = "9")]
	public GameObject LDLLKHOJGKA(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3297240", Offset = "0x3296640", VA = "0x183297240", Slot = "10")]
	public T LDLLKHOJGKA<T>(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3296CC0", Offset = "0x32960C0", VA = "0x183296CC0")]
	private T LDLLKHOJGKA<T>(GameObject EPNPEBHIEBC, Transform HKNGNFLDPKM, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC, [Out] GameObject AGGLHNEIPBI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3296820", Offset = "0x3295C20", VA = "0x183296820")]
	private T AINKEJFOAFB<T>(GameObject IIKFCCENKCC, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x761B3B0", Offset = "0x761A7B0", VA = "0x18761B3B0")]
	private void MCONMHAJJHC(Component LENGNFMPCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x761B4C0", Offset = "0x761A8C0", VA = "0x18761B4C0")]
	private void MFDOBCKGIOL(Component LENGNFMPCHL, KPPJBIANBDM GAPCIOOOOMF, bool GOCENJIBMJC, bool MAMLKBLFPAK, [Optional] Type ECCMGHFDAJM, [Optional] Type HDINJMDDMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x761B970", Offset = "0x761AD70", VA = "0x18761B970")]
	private void MJLKBPCJDFC(GameObject IIKFCCENKCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KPPJBIANBDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> FDEOMNMKFPJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3557C60", Offset = "0x3557060", VA = "0x183557C60")]
	public KPPJBIANBDM FHPKMMCODGE<T>(T DAPOANIDJKG)
	{
		return default(KPPJBIANBDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3557B50", Offset = "0x3556F50", VA = "0x183557B50")]
	public T FCPELJIOJPN<T>(T CIKOELCEFFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3558390", Offset = "0x3557790", VA = "0x183558390")]
	public bool MGNAAKJADEG<T>([Out] T DAPOANIDJKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IEACIIDPEJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MHJLICBFOAB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F60", Offset = "0x27C2360", VA = "0x1827C2F60")]
	public IEACIIDPEJK(bool LAMIKIAKALO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BLENBOOBDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool MFJBCJCGEMO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x761B0E0", Offset = "0x761A4E0", VA = "0x18761B0E0")]
	public BLENBOOBDPK(bool CGHLHFHCHMF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, CIODNICBKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7622790", Offset = "0x7621B90", VA = "0x187622790", Slot = "4")]
		public void PrepareImposter(KPPJBIANBDM GAPCIOOOOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
		public Bounds EHMLCBCDGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x761D780", Offset = "0x761CB80", VA = "0x18761D780")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x761D740", Offset = "0x761CB40", VA = "0x18761D740")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x761D700", Offset = "0x761CB00", VA = "0x18761D700")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x761D610", Offset = "0x761CA10", VA = "0x18761D610")]
		private void BHMDNAAMLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x761FF00", Offset = "0x761F300", VA = "0x18761FF00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x761FEF0", Offset = "0x761F2F0", VA = "0x18761FEF0")]
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
		[OLNOPNKGMIO("frameCameraToImposterBounds", true)]
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
		[OLNOPNKGMIO("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x761E620", Offset = "0x761DA20", VA = "0x18761E620")]
		public void JABPOMDHGID(Vector3 DPHJFNLKJME, Quaternion EMLGKFDPMNE, float CGDCBNMGAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x761E650", Offset = "0x761DA50", VA = "0x18761E650")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MCDGBEANOOO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 MLBCFHJJPNL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> AGLBCKJBHJF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> ODHCHHOFOMP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera KPPFMKEEEOI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> NNAPBMHBPEJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> HIJIAMHMHMO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode OLEJHDAPHMN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color BKFPCFPNMIP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color FIFPCJMHFBI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color ONKNEEKJALN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap KADALJAJOCC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool FCGKCKEOBIO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> EOKFJNPJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7622040", Offset = "0x7621440", VA = "0x187622040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> ILKFCEIIOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7621DC0", Offset = "0x76211C0", VA = "0x187621DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera DFMOECGLHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7621E10", Offset = "0x7621210", VA = "0x187621E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76207A0", Offset = "0x761FBA0", VA = "0x1876207A0")]
	public static void COMODHOJBLC(Vector3 ABBPCEJCCDH, Quaternion IOIDGPGEJBC, ImposterRenderConfig FFMLOBHEBIO, bool KBHLFNDCIIK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7620EA0", Offset = "0x76202A0", VA = "0x187620EA0")]
	private static void GAALDDGKIAP(Vector3 ABBPCEJCCDH, Quaternion IOIDGPGEJBC, URPLight MONACFKCOHM, ImposterRenderConfig.LightConfig NKFNFOPNKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x76217F0", Offset = "0x7620BF0", VA = "0x1876217F0")]
	public static void HGKPFOECBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x76218D0", Offset = "0x7620CD0", VA = "0x1876218D0")]
	private static void IDKPLNNADIB(int FFJIKIJBNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7620A30", Offset = "0x761FE30", VA = "0x187620A30")]
	public static void FGPMMCLGEJF(ImposterRenderConfig FFMLOBHEBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7621CE0", Offset = "0x76210E0", VA = "0x187621CE0")]
	public static void JJCBKPHAAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7622160", Offset = "0x7621560", VA = "0x187622160")]
	public static void PEEBPFCODIL(GameObject NPNFPFHEHNE, RenderTexture HABAMJCDGJA, ImposterRenderConfig FFMLOBHEBIO, EKOCCEHCMHI KPPHBGECGKH, [Optional] Vector3? JHNFPFGDJAP, [Optional] Vector3? ICDPJFGADPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76211C0", Offset = "0x76205C0", VA = "0x1876211C0")]
	private static void GPDJBPAKCMC(GameObject NPNFPFHEHNE, RenderTexture HABAMJCDGJA, ImposterRenderConfig FFMLOBHEBIO, EKOCCEHCMHI KPPHBGECGKH, Vector3 JHNFPFGDJAP, Vector3 ICDPJFGADPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7620BE0", Offset = "0x761FFE0", VA = "0x187620BE0")]
	private static void FKJAFOMADKP(GameObject NPNFPFHEHNE, Vector3 IAHHLAOMNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7620430", Offset = "0x761F830", VA = "0x187620430")]
	public static void CMKJNLDABKA(Bounds MKKOFKFJEJC, ImposterRenderConfig FFMLOBHEBIO, [Out] Vector3 GBADOELIAKG, [Out] Quaternion KDBANIJILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x761FF20", Offset = "0x761F320", VA = "0x18761FF20")]
	private static void BOBGLCNAABP(GameObject EPNPEBHIEBC, ImposterRenderConfig FFMLOBHEBIO, EKOCCEHCMHI KPPHBGECGKH, [Out] Vector3 GBADOELIAKG, [Out] Quaternion KDBANIJILAH, [Out] float BFKIANHBDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7622090", Offset = "0x7621490", VA = "0x187622090")]
	public static RenderTexture PDNDIOADPCE(int LJMOLGKJKNC, int AIELGFIFJDN, RenderTextureFormat MCIFFFCOFIA = RenderTextureFormat.ARGB32, string APOJGOOBNPK = "[ImposterRendering]Preview")
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
		public struct CBFMDOIIIAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public DOJAMHMCGOK KKJIGAHEJLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject ENCJIJEPFCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture ALCGEGMLCHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig LEFNJJAFMHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public EKOCCEHCMHI EKOCCEHCMHI;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x761B0F0", Offset = "0x761A4F0", VA = "0x18761B0F0")]
			public CBFMDOIIIAA(DOJAMHMCGOK OLLJCEKAIOF, GameObject IIABJPHLGKB, RenderTexture HABAMJCDGJA, ImposterRenderConfig ENAANIFDIEI, EKOCCEHCMHI KPPHBGECGKH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static IONONCKAOIB<CBFMDOIIIAA, RenderTexture> OCOGOPDCJCN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<CBFMDOIIIAA> CJGANGNMIKJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MHKIEGJJOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x761C370", Offset = "0x761B770", VA = "0x18761C370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x761C730", Offset = "0x761BB30", VA = "0x18761C730")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NPNFPFHEHNE, RenderTexture HABAMJCDGJA, ImposterRenderConfig FFMLOBHEBIO, EKOCCEHCMHI KPPHBGECGKH, CancellationToken MLAPMBKLAOF, bool GPAJNOEOHPK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x761C160", Offset = "0x761B560", VA = "0x18761C160", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x761C6A0", Offset = "0x761BAA0", VA = "0x18761C6A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x761C400", Offset = "0x761B800", VA = "0x18761C400")]
		private static Task<RenderTexture> OELEIJJPOLG(CBFMDOIIIAA IEKOLAHLDDO, CancellationToken MLAPMBKLAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x761CB30", Offset = "0x761BF30", VA = "0x18761CB30")]
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
