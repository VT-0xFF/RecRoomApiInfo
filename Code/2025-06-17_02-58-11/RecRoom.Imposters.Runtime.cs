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
	private readonly struct IBNOAIPHKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NJPGBKPAHEG OJEEEGJFJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string PLIMLAHDBOC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public IBNOAIPHKIP(NJPGBKPAHEG ABFFMDJBJCN, string AHDGJCPPJHB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MLKHJFAIHFL : IAsyncStateMachine
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
		public IBNOAIPHKIP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D87E30", Offset = "0x7D86830", VA = "0x187D87E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D881F0", Offset = "0x7D86BF0", VA = "0x187D881F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GIGCALKOKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EFONCAEBAHP<IBNOAIPHKIP, GameObject> BAHMJGNIKAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AKMHIICMEPA BFACBMNAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EFONCAEBAHP<IBNOAIPHKIP, GameObject> HBFJBLAHKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D856B0", Offset = "0x7D840B0", VA = "0x187D856B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int JKFKHCLFJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D85810", Offset = "0x7D84210", VA = "0x187D85810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D855D0", Offset = "0x7D83FD0", VA = "0x187D855D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D85B50", Offset = "0x7D84550", VA = "0x187D85B50", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D85860", Offset = "0x7D84260", VA = "0x187D85860")]
	[AsyncStateMachine(typeof(MLKHJFAIHFL))]
	private Task<GameObject> HKPJCOBFDHD(IBNOAIPHKIP EHDGIHLMGGD, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D85980", Offset = "0x7D84380", VA = "0x187D85980")]
	public Task<GameObject> LoadItemAsync(NJPGBKPAHEG ABFFMDJBJCN, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D85BC0", Offset = "0x7D845C0", VA = "0x187D85BC0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OLNBLGBBGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NJPGBKPAHEG HJAKKKJAMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture NBMLOLOJJLO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
		public OLNBLGBBGCM(NJPGBKPAHEG IDPNLACAAAI, Texture AELHKEIFLFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum FEEDGPGEJDA
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
	private class LHPOJLJICKN : NNJGPMOALGH<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct OBIMGBMOMHO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LHPOJLJICKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7D89760", Offset = "0x7D88160", VA = "0x187D89760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D89F50", Offset = "0x7D88950", VA = "0x187D89F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NJPGBKPAHEG IDPNLACAAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture JPOAMACLDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig AKLNFIBNIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken JKPNCAGHEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D HDFOCONPKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject MHCFGKFPCLC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MPBOGDMHBIL<Texture2D> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7D87B20", Offset = "0x7D86520", VA = "0x187D87B20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D87C00", Offset = "0x7D86600", VA = "0x187D87C00")]
		public LHPOJLJICKN(NJPGBKPAHEG IDPNLACAAAI, RenderTexture JPOAMACLDGB, ImposterRenderConfig AKLNFIBNIOE, CancellationToken JKPNCAGHEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D87A00", Offset = "0x7D86400", VA = "0x187D87A00")]
		[AsyncStateMachine(typeof(OBIMGBMOMHO))]
		private Task<Texture2D> AACIJIKAHOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D87AF0", Offset = "0x7D864F0", VA = "0x187D87AF0", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D87B80", Offset = "0x7D86580", VA = "0x187D87B80")]
		private static void MCMLBGKLIFG(GameObject MHCFGKFPCLC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ENLMJCHAINI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7D85C50", Offset = "0x7D84650", VA = "0x187D85C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
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
	[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private FEEDGPGEJDA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[IMEGOPBCDNJ("size", FEEDGPGEJDA.Custom)]
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
	private static int MMEGBDLMNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture KFJFHENOBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PAMIIJOJGPE<GameObject> JFPCIKAELNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LIJLGGILNGM NCOHBEIPIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource IFHBDAKCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ODDHNIEMFCD<Texture2D> EAHDHMNPECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NJPGBKPAHEG PLBJBGJCKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EGHAEJDNFJJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LCMKFKLPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D874C0", Offset = "0x7D85EC0", VA = "0x187D874C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D87510", Offset = "0x7D85F10", VA = "0x187D87510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KBIOKLOJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D86DE0", Offset = "0x7D857E0", VA = "0x187D86DE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NJPGBKPAHEG HJAKKKJAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D86BC0", Offset = "0x7D855C0", VA = "0x187D86BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LHPBANKHKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2318720", Offset = "0x2317120", VA = "0x182318720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GMHDDFMGFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D86B30", Offset = "0x7D85530", VA = "0x187D86B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D86B20", Offset = "0x7D85520", VA = "0x187D86B20")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D86FC0", Offset = "0x7D859C0", VA = "0x187D86FC0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D86AA0", Offset = "0x7D854A0", VA = "0x187D86AA0")]
	private void AHJHDDFIDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D873E0", Offset = "0x7D85DE0", VA = "0x187D873E0")]
	public void Set(NJPGBKPAHEG GFHNKIIHDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D873D0", Offset = "0x7D85DD0", VA = "0x187D873D0")]
	public void Set(Texture AELHKEIFLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D87390", Offset = "0x7D85D90", VA = "0x187D87390")]
	public void Set(OLNBLGBBGCM PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D86D20", Offset = "0x7D85720", VA = "0x187D86D20")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D871A0", Offset = "0x7D85BA0", VA = "0x187D871A0")]
	public void SetInternal(NJPGBKPAHEG GFHNKIIHDHO, [Optional] Texture PPDKGOLNHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D87190", Offset = "0x7D85B90", VA = "0x187D87190")]
	public void SetCustomSize(int GLFBPMBJDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A550", Offset = "0xA08F50", VA = "0x180A0A550")]
	public void SetAntiAliasing(int AHMCOJFAAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D86D30", Offset = "0x7D85730", VA = "0x187D86D30")]
	[AsyncStateMachine(typeof(ENLMJCHAINI))]
	private void HONNGNBGOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D870B0", Offset = "0x7D85AB0", VA = "0x187D870B0")]
	private void PFJKKMAKOBI(Texture AELHKEIFLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D87440", Offset = "0x7D85E40", VA = "0x187D87440")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ILMDGIPFKJH
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float JFAJCADMMHF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void PrepareImposter(EKGGCGBHLBO JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D86A60", Offset = "0x7D85460", VA = "0x187D86A60")]
	public void SetReferencePoint(Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D86870", Offset = "0x7D85270", VA = "0x187D86870")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D86A40", Offset = "0x7D85440", VA = "0x187D86A40")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BE80", Offset = "0x1F9A880", VA = "0x181F9BE80")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MDHDFONBEAG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static MDHDFONBEAG NMNCCINPNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float EKBCALELHKA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DA80", Offset = "0x2B1C480", VA = "0x182B1DA80")]
	public MDHDFONBEAG(float PMFDMIGOEDB)
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
		[Cpp2IlInjected.Address(RVA = "0x7D8A270", Offset = "0x7D88C70", VA = "0x187D8A270", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
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
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CEPENDPAGPC = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int LHCNLNIGBNL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> CIFBGBOGBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool GNILILPOFOB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D87720", Offset = "0x7D86120", VA = "0x187D87720")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D87620", Offset = "0x7D86020", VA = "0x187D87620")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D87970", Offset = "0x7D86370", VA = "0x187D87970")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NJPGBKPAHEG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KOGBBPOOCKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MDHDFONBEAG MDHDFONBEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AFOGAIBDBBN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OGEDDBGGJCF(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EEGBLAMLJLC(NJPGBKPAHEG NDNHELJMDCG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIJCKHAKOIF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EPLPAMGPADB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CICNKHNIKAP(uint? AJCNAOFGEAE, [Out] ODDHNIEMFCD<Texture2D> POPPJLMJAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GOCIBAICONI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D86490", Offset = "0x7D84E90", VA = "0x187D86490")]
	public static bool NMNMDPINKPN(NJPGBKPAHEG FCIAAIKOPJG, NJPGBKPAHEG JAMACNHLDGL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, ILMDGIPFKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D84A00", Offset = "0x7D83400", VA = "0x187D84A00", Slot = "4")]
		public void PrepareImposter(EKGGCGBHLBO JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ILMDGIPFKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EKGGCGBHLBO JKGCHKOAIPN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ELGHDOBDPAF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FAMCJPJCCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> OMLGINPHKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AKMHIICMEPA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJGEIBHBGGB(params Type[] FCJGCPKOEEP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AECPFMILNLP(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T AECPFMILNLP<T>(T ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AECPFMILNLP<T>(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject AECPFMILNLP(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NDAFMFMHIDL : IDisposable, AKMHIICMEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> CPLGKMECCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> GNKPFEJPFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform EIICFNLNBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> CMKFENDJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ENPFOPFLNKI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D88B80", Offset = "0x7D87580", VA = "0x187D88B80")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	public static void JGOIPALGEOO(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D89320", Offset = "0x7D87D20", VA = "0x187D89320")]
	[UnityEngine.Scripting.Preserve]
	public NDAFMFMHIDL([CNHMBDDCGKB(null)] ELGHDOBDPAF CAEPJMMHOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D88490", Offset = "0x7D86E90", VA = "0x187D88490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D88C70", Offset = "0x7D87670", VA = "0x187D88C70", Slot = "5")]
	public void MJGEIBHBGGB(params Type[] FCJGCPKOEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D88260", Offset = "0x7D86C60", VA = "0x187D88260", Slot = "6")]
	public GameObject AECPFMILNLP(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7850", Offset = "0x3BB6250", VA = "0x183BB7850", Slot = "7")]
	public T AECPFMILNLP<T>(T ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BB78C0", Offset = "0x3BB62C0", VA = "0x183BB78C0", Slot = "8")]
	public T AECPFMILNLP<T>(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, bool GIHBOIOOIKD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D882F0", Offset = "0x7D86CF0", VA = "0x187D882F0", Slot = "9")]
	public GameObject AECPFMILNLP(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7810", Offset = "0x3BB6210", VA = "0x183BB7810", Slot = "10")]
	public T AECPFMILNLP<T>(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BB72B0", Offset = "0x3BB5CB0", VA = "0x183BB72B0")]
	private T AECPFMILNLP<T>(GameObject ANGPMLNFAIK, Transform EAGGHBKHKHF, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD, [Out] GameObject DALHHFOOBDN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BB78F0", Offset = "0x3BB62F0", VA = "0x183BB78F0")]
	private T HELNBMPCAAG<T>(GameObject HNGFDIJGINB, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D890F0", Offset = "0x7D87AF0", VA = "0x187D890F0")]
	private void POMAJKHJBCD(EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D887E0", Offset = "0x7D871E0", VA = "0x187D887E0")]
	private void FPIICFBOPBP(EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D88380", Offset = "0x7D86D80", VA = "0x187D88380")]
	private void CIMEEOFDHED(Component FDMBFEDKLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D88570", Offset = "0x7D86F70", VA = "0x187D88570")]
	private void FPIICFBOPBP(Component FDMBFEDKLFL, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD, bool MADINHGJHNP, [Optional] Type OADIHDGDJAL, [Optional] Type OMENMLFPEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D88CC0", Offset = "0x7D876C0", VA = "0x187D88CC0")]
	private void ONAMMLEPDPH(Component FDMBFEDKLFL, EKGGCGBHLBO JKGCHKOAIPN, bool GIHBOIOOIKD, bool MADINHGJHNP, [Optional] Type OADIHDGDJAL, [Optional] Type OMENMLFPEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D88A10", Offset = "0x7D87410", VA = "0x187D88A10")]
	private void IHPFEBMCCEH(GameObject HNGFDIJGINB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EKGGCGBHLBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> OFMJCCKEBGF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38FA7A0", Offset = "0x38F91A0", VA = "0x1838FA7A0")]
	public EKGGCGBHLBO DGDFODDEBEH<T>(T JBFOPHBBKMA)
	{
		return default(EKGGCGBHLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x38FB6B0", Offset = "0x38FA0B0", VA = "0x1838FB6B0")]
	public T IBPMNADNGOO<T>(T ALKDPGOIFPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x38FAED0", Offset = "0x38F98D0", VA = "0x1838FAED0")]
	public bool EFEDHOLKNME<T>([Out] T JBFOPHBBKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C00", Offset = "0x7D84600", VA = "0x187D85C00")]
	public void MPMJEFEEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GJECDDDAHGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool DGKHGKLAEPL;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1DAF0", VA = "0x182B1F0F0")]
	public GJECDDDAHGL(bool NBEDFPDELEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CABMBIIFALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool HDKEJNKBIJP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D821A0", Offset = "0x7D80BA0", VA = "0x187D821A0")]
	public CABMBIIFALI(bool BBAIHILENPA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, ILMDGIPFKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7D89FC0", Offset = "0x7D889C0", VA = "0x187D89FC0", Slot = "4")]
		public void PrepareImposter(EKGGCGBHLBO JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		public Bounds NEEMOPOOJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7D866E0", Offset = "0x7D850E0", VA = "0x187D866E0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D866A0", Offset = "0x7D850A0", VA = "0x187D866A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D86660", Offset = "0x7D85060", VA = "0x187D86660")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D86570", Offset = "0x7D84F70", VA = "0x187D86570")]
		private void HFCCGDEANGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D87DD0", Offset = "0x7D867D0", VA = "0x187D87DD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7D87DC0", Offset = "0x7D867C0", VA = "0x187D87DC0")]
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
		[IMEGOPBCDNJ("frameCameraToImposterBounds", true)]
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
		[IMEGOPBCDNJ("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x7D87580", Offset = "0x7D85F80", VA = "0x187D87580")]
		public void DPFPGCFOJNH(Vector3 DFLPIJGNBAJ, Quaternion KHNLIBFOMEM, float OMEMELOLGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D875B0", Offset = "0x7D85FB0", VA = "0x187D875B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CJBEBLKJNEI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FDCMMBNGEDK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> JOMLFJGCBLP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> KFLHIHALCCJ;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera DBKFBAJLKNN;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> FOGNNHLAEIJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> BOEAIJHIBIK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode OMIOPODHOEF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color JBPCCALHFMC;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color POPIOFKJKBF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color GNFCDBPMOJP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap EOFPCMNCGGB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool NKOFPEIKLKD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> HKFEMOPOCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D83E80", Offset = "0x7D82880", VA = "0x187D83E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> FLCEIMFPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D83ED0", Offset = "0x7D828D0", VA = "0x187D83ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera FALICMIKFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D82440", Offset = "0x7D80E40", VA = "0x187D82440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D821B0", Offset = "0x7D80BB0", VA = "0x187D821B0")]
	public static void AEBFLBGFEFA(Vector3 BOFDKCMNHKD, Quaternion PFCLAJBFPBL, ImposterRenderConfig NAEOFECFOBE, bool JOMDBHHLGDM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D844D0", Offset = "0x7D82ED0", VA = "0x187D844D0")]
	private static void PPKNPMOEABD(Vector3 BOFDKCMNHKD, Quaternion PFCLAJBFPBL, URPLight LBELKHPMCNL, ImposterRenderConfig.LightConfig BNBHFHBMPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D82E40", Offset = "0x7D81840", VA = "0x187D82E40")]
	public static void FMFJOLDLLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D83F20", Offset = "0x7D82920", VA = "0x187D83F20")]
	private static void MANFHKJENDF(int HFHEMHACLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D83290", Offset = "0x7D81C90", VA = "0x187D83290")]
	public static void HKFJPGOJHKG(ImposterRenderConfig NAEOFECFOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D843F0", Offset = "0x7D82DF0", VA = "0x187D843F0")]
	public static void NMBPFNHONHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D83B40", Offset = "0x7D82540", VA = "0x187D83B40")]
	public static void LCPLODMPJOG(GameObject GDNPKGIIOPF, RenderTexture JPOAMACLDGB, ImposterRenderConfig NAEOFECFOBE, MDHDFONBEAG CNBJDMEILEF, [Optional] Vector3? OKKFBBEKIBC, [Optional] Vector3? FOCHFOEFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D83510", Offset = "0x7D81F10", VA = "0x187D83510")]
	private static void KLOGJLHAGBB(GameObject GDNPKGIIOPF, RenderTexture JPOAMACLDGB, ImposterRenderConfig NAEOFECFOBE, MDHDFONBEAG CNBJDMEILEF, Vector3 OKKFBBEKIBC, Vector3 FOCHFOEFLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D82B80", Offset = "0x7D81580", VA = "0x187D82B80")]
	private static void EHCNNJPNBNL(GameObject GDNPKGIIOPF, Vector3 DIBJHMKGLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D82F20", Offset = "0x7D81920", VA = "0x187D82F20")]
	public static void HKCCJFMMPMG(Bounds GDCDCEPJFOB, ImposterRenderConfig NAEOFECFOBE, [Out] Vector3 OMFDJNNGEMJ, [Out] Quaternion IPNDDFFKHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D82670", Offset = "0x7D81070", VA = "0x187D82670")]
	private static void BOLDONFIOBF(GameObject ANGPMLNFAIK, ImposterRenderConfig NAEOFECFOBE, MDHDFONBEAG CNBJDMEILEF, [Out] Vector3 OMFDJNNGEMJ, [Out] Quaternion IPNDDFFKHJB, [Out] float AIAMGDDGMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D83440", Offset = "0x7D81E40", VA = "0x187D83440")]
	public static RenderTexture JNFENHDPIML(int BDNFEOELIGH, int LAPJMECHNBN, RenderTextureFormat DFJIALHJPBA = RenderTextureFormat.ARGB32, string NJCBIBEEIBB = "[ImposterRendering]Preview")
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
		public struct DOHNOJEEDON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NPBFAPINKBN GKJBNMKJGCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject GPPDOCJIMHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture KBIOKLOJCBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig APPHNHADNOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public MDHDFONBEAG MDHDFONBEAG;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7D84B50", Offset = "0x7D83550", VA = "0x187D84B50")]
			public DOHNOJEEDON(NPBFAPINKBN GNNONNJKBFK, GameObject LIHOJOIBCEN, RenderTexture JPOAMACLDGB, ImposterRenderConfig AKLNFIBNIOE, MDHDFONBEAG CNBJDMEILEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static EFONCAEBAHP<DOHNOJEEDON, RenderTexture> DGMLAOGMHDL;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<DOHNOJEEDON> DGBDBDBIMKA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PKDJCKDJKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7D85070", Offset = "0x7D83A70", VA = "0x187D85070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D85190", Offset = "0x7D83B90", VA = "0x187D85190")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GDNPKGIIOPF, RenderTexture JPOAMACLDGB, ImposterRenderConfig NAEOFECFOBE, MDHDFONBEAG CNBJDMEILEF, CancellationToken JKPNCAGHEDI, bool EEBIHDAPBGL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D84BC0", Offset = "0x7D835C0", VA = "0x187D84BC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D85100", Offset = "0x7D83B00", VA = "0x187D85100", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D84DD0", Offset = "0x7D837D0", VA = "0x187D84DD0")]
		private static Task<RenderTexture> FLKFBIMKCLC(DOHNOJEEDON GMLJPEPLDKF, CancellationToken JKPNCAGHEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7D85590", Offset = "0x7D83F90", VA = "0x187D85590")]
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
