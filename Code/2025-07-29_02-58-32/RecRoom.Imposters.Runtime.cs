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
	private readonly struct KJHHGJOEAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IOKADMPDPPM DNDGFAOPJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BMEFPAKGMBA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
		public KJHHGJOEAMK(IOKADMPDPPM IEAKGPJFMCO, string NKEANKNENKE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ILBHECIDBGG : IAsyncStateMachine
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
		public KJHHGJOEAMK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8343880", Offset = "0x8342280", VA = "0x188343880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8343C40", Offset = "0x8342640", VA = "0x188343C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider EJGIKLACPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OPLDLGECPOF<KJHHGJOEAMK, GameObject> JMBACPNGPHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NGKDPKAHJPP CJIJBJKHHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OPLDLGECPOF<KJHHGJOEAMK, GameObject> IBCCLOHOKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8342A60", Offset = "0x8341460", VA = "0x188342A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HCEIIHGBLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8342840", Offset = "0x8341240", VA = "0x188342840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8342640", Offset = "0x8341040", VA = "0x188342640", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8342BC0", Offset = "0x83415C0", VA = "0x188342BC0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8342720", Offset = "0x8341120", VA = "0x188342720")]
	[AsyncStateMachine(typeof(ILBHECIDBGG))]
	private Task<GameObject> EMMMMCONBKI(KJHHGJOEAMK EIEDPAMELAA, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8342890", Offset = "0x8341290", VA = "0x188342890")]
	public Task<GameObject> LoadItemAsync(IOKADMPDPPM IEAKGPJFMCO, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8342C30", Offset = "0x8341630", VA = "0x188342C30")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OMHFFGDBFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IOKADMPDPPM GDILDDCEMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IBEMOGNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
		public OMHFFGDBFGI(IOKADMPDPPM IEPHFLLDCLK, Texture GIAGKAKEOKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BIHFKPAPNDH
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
	private class GDLHFGLFOBG : MKJJOFDHLJK<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AEIOJHAMAOJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GDLHFGLFOBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x833D460", Offset = "0x833BE60", VA = "0x18833D460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x833DC50", Offset = "0x833C650", VA = "0x18833DC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IOKADMPDPPM IEPHFLLDCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BAEBJICDNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BBHFFDCLOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken OMJKEHOJJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D DPPIEEBBLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject PFOFMHMHMMF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override DPMDGLGHBHJ<Texture2D> MMBOOOFMKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8342D20", Offset = "0x8341720", VA = "0x188342D20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BDPBBCLCMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8342E70", Offset = "0x8341870", VA = "0x188342E70")]
		public GDLHFGLFOBG(IOKADMPDPPM IEPHFLLDCLK, RenderTexture BAEBJICDNHB, ImposterRenderConfig BBHFFDCLOHM, CancellationToken OMJKEHOJJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8342D80", Offset = "0x8341780", VA = "0x188342D80")]
		[AsyncStateMachine(typeof(AEIOJHAMAOJ))]
		private Task<Texture2D> HMGMKAIGKLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8342C70", Offset = "0x8341670", VA = "0x188342C70", Slot = "10")]
		protected override void BLALHCGAKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8342CA0", Offset = "0x83416A0", VA = "0x188342CA0")]
		private static void CBDFHBJMMGE(GameObject PFOFMHMHMMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GHAMMDAFPBM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8343030", Offset = "0x8341A30", VA = "0x188343030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
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
	[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private BIHFKPAPNDH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[ENLJNEOAHMH("size", BIHFKPAPNDH.Custom)]
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
	private static int FNAPJFOCDBM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OHMGACEGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OIJAKAMGOLF<GameObject> KAFNJIMKJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private DAMMDADGLAC CJNOPKLBENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource LNGJLPHIAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FDLGIOOGFEJ<Texture2D> HEBKOODJNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private IOKADMPDPPM EAICCNBBDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture GBPPBDJOPPD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int PMCGNAJPIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8344C20", Offset = "0x8343620", VA = "0x188344C20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8344C70", Offset = "0x8343670", VA = "0x188344C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PHHBHMNPDJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8344610", Offset = "0x8343010", VA = "0x188344610")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IOKADMPDPPM GDILDDCEMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83441F0", Offset = "0x8342BF0", VA = "0x1883441F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool ALBNPMKCKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2493DF0", Offset = "0x24927F0", VA = "0x182493DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int PHCBOOOCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83444F0", Offset = "0x8342EF0", VA = "0x1883444F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83441E0", Offset = "0x8342BE0", VA = "0x1883441E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83447F0", Offset = "0x83431F0", VA = "0x1883447F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8344590", Offset = "0x8342F90", VA = "0x188344590")]
	private void KDPCOCJCABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8344B40", Offset = "0x8343540", VA = "0x188344B40")]
	public void Set(IOKADMPDPPM FKGOEHELFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8344AF0", Offset = "0x83434F0", VA = "0x188344AF0")]
	public void Set(Texture GIAGKAKEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8344B00", Offset = "0x8343500", VA = "0x188344B00")]
	public void Set(OMHFFGDBFGI PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8344350", Offset = "0x8342D50", VA = "0x188344350")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83448F0", Offset = "0x83432F0", VA = "0x1883448F0")]
	public void SetInternal(IOKADMPDPPM FKGOEHELFMN, [Optional] Texture JJNBOIDMBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83448E0", Offset = "0x83432E0", VA = "0x1883448E0")]
	public void SetCustomSize(int GACHCFACDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA93AE0", Offset = "0xA924E0", VA = "0x180A93AE0")]
	public void SetAntiAliasing(int AHNMOKAKFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8344440", Offset = "0x8342E40", VA = "0x188344440")]
	[AsyncStateMachine(typeof(GHAMMDAFPBM))]
	private void GGNLAGGBAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8344360", Offset = "0x8342D60", VA = "0x188344360")]
	private void DABFOAFJGHH(Texture GIAGKAKEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8344BA0", Offset = "0x83435A0", VA = "0x188344BA0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, EBKFEFBOIMB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float DEJKKFCMNHN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void PrepareImposter(AEDLCGEDLGP HKENEGGNMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83441A0", Offset = "0x8342BA0", VA = "0x1883441A0")]
	public void SetReferencePoint(Vector3 GDEEHHOMKPN, Quaternion IEBOBJIHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8343FB0", Offset = "0x83429B0", VA = "0x188343FB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8344180", Offset = "0x8342B80", VA = "0x188344180")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20F8700", Offset = "0x20F7100", VA = "0x1820F8700")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AGAEFJHJIGP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static AGAEFJHJIGP EMMCNNAMHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float FBGECDPAOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6F40", Offset = "0x2CC5940", VA = "0x182CC6F40")]
	public AGAEFJHJIGP(float GMCJLFIKPID)
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
		[Cpp2IlInjected.Address(RVA = "0x8345540", Offset = "0x8343F40", VA = "0x188345540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
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
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OGHHKHEOHOB = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int DCLNKBNEDCJ = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> HKDHGGNNGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool PIPGNPBEAHL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8344E90", Offset = "0x8343890", VA = "0x188344E90")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8344D90", Offset = "0x8343790", VA = "0x188344D90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83450D0", Offset = "0x8343AD0", VA = "0x1883450D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IOKADMPDPPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DCEFEKBGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AGAEFJHJIGP AGAEFJHJIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GPKCGIGOHJP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LBONAOBJLIL(CancellationToken OMJKEHOJJFF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LGMHEBGMBIL(IOKADMPDPPM EFNHKCDKOGH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBHMAMNHDHM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFPHIMEMCKP();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IFJMFGFBPFJ(uint? HHENCCGOGPM, [Out] FDLGIOOGFEJ<Texture2D> KMFEEFNPNEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MOAEBFAGHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8345190", Offset = "0x8343B90", VA = "0x188345190")]
	public static bool GOOMKJGMELK(IOKADMPDPPM JGJKNMJFPEK, IOKADMPDPPM IOCPNAIDKFE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, EBKFEFBOIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8341AB0", Offset = "0x83404B0", VA = "0x188341AB0", Slot = "4")]
		public void PrepareImposter(AEDLCGEDLGP HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EBKFEFBOIMB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AEDLCGEDLGP HKENEGGNMIM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JGKGIILHPIO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KHNGCIFDBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MDNDACNAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NGKDPKAHJPP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBPIBKHINAJ(params Type[] JJPOLJDJKGJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ENKOEKNGEDK<T>(T IJAFMJKMLAD, Transform DFKFFPKHNCH, bool GADOPDDAKPH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T ENKOEKNGEDK<T>(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, bool GADOPDDAKPH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject ENKOEKNGEDK(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CGEJGNKOKNN : IDisposable, NGKDPKAHJPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> FBKNMKBECDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> AMIHOACAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform JLIFNADMPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> KGDFCOANAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> KEECAAHMBIJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8340C80", Offset = "0x833F680", VA = "0x188340C80")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	public static void CPNCCEEHJEL(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8341670", Offset = "0x8340070", VA = "0x188341670")]
	[UnityEngine.Scripting.Preserve]
	public CGEJGNKOKNN([LNLOHEINMEO(null)] JGKGIILHPIO NPEHPLNOBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8340D80", Offset = "0x833F780", VA = "0x188340D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8341620", Offset = "0x8340020", VA = "0x188341620", Slot = "5")]
	public void KBPIBKHINAJ(params Type[] JJPOLJDJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AB30", Offset = "0x3A69530", VA = "0x183A6AB30", Slot = "6")]
	public T ENKOEKNGEDK<T>(T IJAFMJKMLAD, Transform DFKFFPKHNCH, bool GADOPDDAKPH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AB00", Offset = "0x3A69500", VA = "0x183A6AB00", Slot = "7")]
	public T ENKOEKNGEDK<T>(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, bool GADOPDDAKPH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8340F70", Offset = "0x833F970", VA = "0x188340F70", Slot = "8")]
	public GameObject ENKOEKNGEDK(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AAC0", Offset = "0x3A694C0", VA = "0x183A6AAC0", Slot = "9")]
	public T ENKOEKNGEDK<T>(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3A6A550", Offset = "0x3A68F50", VA = "0x183A6A550")]
	private T ENKOEKNGEDK<T>(GameObject IJAFMJKMLAD, Transform DFKFFPKHNCH, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH, [Out] GameObject LMOOOIMDJGH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A6A260", Offset = "0x3A68C60", VA = "0x183A6A260")]
	private T DEJEDKJIJGI<T>(GameObject CEENMGBCJEJ, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8340620", Offset = "0x833F020", VA = "0x188340620")]
	private void BDDKIMDKAPE(AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8341000", Offset = "0x833FA00", VA = "0x188341000")]
	private void GGLJLDPPCHP(AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8340E60", Offset = "0x833F860", VA = "0x188340E60")]
	private void EGLDJMKDECG(Component BIMLKJFNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8341230", Offset = "0x833FC30", VA = "0x188341230")]
	private void GGLJLDPPCHP(Component BIMLKJFNDFP, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH, bool IDIFIMPACKB, [Optional] Type DKIEDLCGDEB, [Optional] Type PMIFFNLOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8340850", Offset = "0x833F250", VA = "0x188340850")]
	private void BMADBAGCJDD(Component BIMLKJFNDFP, AEDLCGEDLGP HKENEGGNMIM, bool GADOPDDAKPH, bool IDIFIMPACKB, [Optional] Type DKIEDLCGDEB, [Optional] Type PMIFFNLOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83414B0", Offset = "0x833FEB0", VA = "0x1883414B0")]
	private void HELKPIJPFAG(GameObject CEENMGBCJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AEDLCGEDLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> EELPPKJJKIE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31C2060", Offset = "0x31C0A60", VA = "0x1831C2060")]
	public AEDLCGEDLGP MAAIKGLMNNO<T>(T GMKFALMHNPH)
	{
		return default(AEDLCGEDLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31C1780", Offset = "0x31C0180", VA = "0x1831C1780")]
	public T DHBICMHDGKM<T>(T KKCMINIPIBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31C1890", Offset = "0x31C0290", VA = "0x1831C1890")]
	public bool KPLGLDIBGLN<T>([Out] T GMKFALMHNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x833D410", Offset = "0x833BE10", VA = "0x18833D410")]
	public void CHLOADNGFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FOFDFEEKOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool KCAEDJDLEAK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
	public FOFDFEEKOOC(bool MPOGEBPNJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BDLKIPDFDMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NPEELEBOOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8340610", Offset = "0x833F010", VA = "0x188340610")]
	public BDLKIPDFDMC(bool ILDIMBDBBDC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, EBKFEFBOIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8345280", Offset = "0x8343C80", VA = "0x188345280", Slot = "4")]
		public void PrepareImposter(AEDLCGEDLGP HKENEGGNMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
		public Bounds HJPIALIKICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8343E20", Offset = "0x8342820", VA = "0x188343E20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8343DE0", Offset = "0x83427E0", VA = "0x188343DE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8343DA0", Offset = "0x83427A0", VA = "0x188343DA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8343CB0", Offset = "0x83426B0", VA = "0x188343CB0")]
		private void GEEGFCHOJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8345170", Offset = "0x8343B70", VA = "0x188345170")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8345160", Offset = "0x8343B60", VA = "0x188345160")]
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
		[ENLJNEOAHMH("frameCameraToImposterBounds", true)]
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
		[ENLJNEOAHMH("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8344CF0", Offset = "0x83436F0", VA = "0x188344CF0")]
		public void IEAEIPGPBMD(Vector3 CJOAPJOBLHB, Quaternion MONHEAODOKJ, float GDPIACJGHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8344D20", Offset = "0x8343720", VA = "0x188344D20")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class APMIKIGGPID
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 BLFOCEGJNNG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> KIBPAOIGFOP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> AHBPPGNCEEH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera PCHDDOHAECD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> OIEDMEIAGBP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> ELLCKLINAGN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode ELOCIPOIDKL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color ANPHKKHLGKB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BECCNMKCFLA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color CMIPGMGFJMG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap HLPKKNJHEKB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool BPJPALLDBHF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> AOFMLNMAGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83401C0", Offset = "0x833EBC0", VA = "0x1883401C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PKFLFKBNADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x833F290", Offset = "0x833DC90", VA = "0x18833F290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera DFBAPBJMNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x833EB50", Offset = "0x833D550", VA = "0x18833EB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x833F2E0", Offset = "0x833DCE0", VA = "0x18833F2E0")]
	public static void HOMFLOLGIOJ(Vector3 LKKFIHIDBIP, Quaternion LNLBALAJBML, ImposterRenderConfig KKNFFOGJOIM, bool MOHOAABABJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x833EDA0", Offset = "0x833D7A0", VA = "0x18833EDA0")]
	private static void EKLFKPMCLBN(Vector3 LKKFIHIDBIP, Quaternion LNLBALAJBML, URPLight NHEKNCBLNBE, ImposterRenderConfig.LightConfig HDJBHMPHKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x833F0C0", Offset = "0x833DAC0", VA = "0x18833F0C0")]
	public static void EOHOAGIENHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x833FD90", Offset = "0x833E790", VA = "0x18833FD90")]
	private static void ODBPHHNMKCF(int GPKNFOMGKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8340210", Offset = "0x833EC10", VA = "0x188340210")]
	public static void PGALPOJMFCO(ImposterRenderConfig KKNFFOGJOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x833F1A0", Offset = "0x833DBA0", VA = "0x18833F1A0")]
	public static void FEEJJOBLLFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x833E810", Offset = "0x833D210", VA = "0x18833E810")]
	public static void COMCJKALJIM(GameObject FPOOHFNPLBM, RenderTexture BAEBJICDNHB, ImposterRenderConfig KKNFFOGJOIM, AGAEFJHJIGP HKBGJAPPHDA, [Optional] Vector3? DNOICNPPMNK, [Optional] Vector3? OBADADLDMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x833E1B0", Offset = "0x833CBB0", VA = "0x18833E1B0")]
	private static void CKKNAOKFOKI(GameObject FPOOHFNPLBM, RenderTexture BAEBJICDNHB, ImposterRenderConfig KKNFFOGJOIM, AGAEFJHJIGP HKBGJAPPHDA, Vector3 DNOICNPPMNK, Vector3 OBADADLDMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x833F580", Offset = "0x833DF80", VA = "0x18833F580")]
	private static void JGJIBPBLKAA(GameObject FPOOHFNPLBM, Vector3 GIDFHNICKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x833DD70", Offset = "0x833C770", VA = "0x18833DD70")]
	public static void AHECHFBEBAH(Bounds FOMCPODIHDI, ImposterRenderConfig KKNFFOGJOIM, [Out] Vector3 BIKGJLECKNG, [Out] Quaternion MBCOFJPBHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x833F860", Offset = "0x833E260", VA = "0x18833F860")]
	private static void LADKKKOMIIO(GameObject IJAFMJKMLAD, ImposterRenderConfig KKNFFOGJOIM, AGAEFJHJIGP HKBGJAPPHDA, [Out] Vector3 BIKGJLECKNG, [Out] Quaternion MBCOFJPBHJA, [Out] float JHNIFILIIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x833E0E0", Offset = "0x833CAE0", VA = "0x18833E0E0")]
	public static RenderTexture CKCBHGEFDBN(int OFMOKEHMKFL, int CNPILOHIEFC, RenderTextureFormat NANAIMNHOFH = RenderTextureFormat.ARGB32, string EMGHNBBFIOM = "[ImposterRendering]Preview")
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
		public struct AFAMLLOOMAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public HNFFHHICMCD KFCNJBMKJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject LKMPIHNACIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture PHHBHMNPDJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig MBLMPIBODNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AGAEFJHJIGP AGAEFJHJIGP;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x833DCC0", Offset = "0x833C6C0", VA = "0x18833DCC0")]
			public AFAMLLOOMAF(HNFFHHICMCD JFLAJONBEOJ, GameObject IBNBLPBGFCO, RenderTexture BAEBJICDNHB, ImposterRenderConfig BBHFFDCLOHM, AGAEFJHJIGP HKBGJAPPHDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static OPLDLGECPOF<AFAMLLOOMAF, RenderTexture> ILPPHGNHCDE;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<AFAMLLOOMAF> IJKNJDCEEOJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int ECBLBMAEHEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8341E10", Offset = "0x8340810", VA = "0x188341E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83421E0", Offset = "0x8340BE0", VA = "0x1883421E0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FPOOHFNPLBM, RenderTexture BAEBJICDNHB, ImposterRenderConfig KKNFFOGJOIM, AGAEFJHJIGP HKBGJAPPHDA, CancellationToken OMJKEHOJJFF, bool NFPHCGMOEJC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8341C00", Offset = "0x8340600", VA = "0x188341C00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8342140", Offset = "0x8340B40", VA = "0x188342140", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8341EA0", Offset = "0x83408A0", VA = "0x188341EA0")]
		private static Task<RenderTexture> OPEIMJNJCHP(AFAMLLOOMAF PFHFALMBAEK, CancellationToken OMJKEHOJJFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8342600", Offset = "0x8341000", VA = "0x188342600")]
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
