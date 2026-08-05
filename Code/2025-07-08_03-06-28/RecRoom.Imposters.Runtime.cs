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
	private readonly struct PCEOHKBHCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GAOBPBBLMBJ GDFDCLDMCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HAPNNFMFLDB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public PCEOHKBHCFI(GAOBPBBLMBJ AAAMEBCAOFM, string JFBBNLMLCMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KADLBNLPHBJ : IAsyncStateMachine
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
		public PCEOHKBHCFI queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80FB9F0", Offset = "0x80FA7F0", VA = "0x1880FB9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80FBDB0", Offset = "0x80FABB0", VA = "0x1880FBDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CALHOOKMOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GFPGBBFBAJF<PCEOHKBHCFI, GameObject> NMIBIGBKPNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NGOELDKMCJI FHBDNMGKHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GFPGBBFBAJF<PCEOHKBHCFI, GameObject> GGOOLIECNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80F6300", Offset = "0x80F5100", VA = "0x1880F6300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LHCOGAMFNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80F62B0", Offset = "0x80F50B0", VA = "0x1880F62B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80F61D0", Offset = "0x80F4FD0", VA = "0x1880F61D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80F6630", Offset = "0x80F5430", VA = "0x1880F6630", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80F60B0", Offset = "0x80F4EB0", VA = "0x1880F60B0")]
	[AsyncStateMachine(typeof(KADLBNLPHBJ))]
	private Task<GameObject> AHDGNJFIJEP(PCEOHKBHCFI KPDINOEKPMB, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80F6460", Offset = "0x80F5260", VA = "0x1880F6460")]
	public Task<GameObject> LoadItemAsync(GAOBPBBLMBJ AAAMEBCAOFM, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80F66A0", Offset = "0x80F54A0", VA = "0x1880F66A0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JEGLLJBEFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GAOBPBBLMBJ IADIEJHAPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LCGMKOCLFJE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
		public JEGLLJBEFAK(GAOBPBBLMBJ ONIECPBDBIG, Texture HINEJAGCAOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MLDCMEMBFGM
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
	private class NEBHECIMBHN : NHPPAEANIOK<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct PCGHFEMKJJI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NEBHECIMBHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x80FCA50", Offset = "0x80FB850", VA = "0x1880FCA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x80FD240", Offset = "0x80FC040", VA = "0x1880FD240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GAOBPBBLMBJ ONIECPBDBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture IEEHJNEMLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig JPJAJAPGBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HIMDFBHMPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D OFENHGAKDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject NALGDDBNIMM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override CEBCBDBEPBJ<Texture2D> DPGHKFLKNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x80FC690", Offset = "0x80FB490", VA = "0x1880FC690", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> KDLPMCBGBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80FC890", Offset = "0x80FB690", VA = "0x1880FC890")]
		public NEBHECIMBHN(GAOBPBBLMBJ ONIECPBDBIG, RenderTexture IEEHJNEMLJL, ImposterRenderConfig JPJAJAPGBEP, CancellationToken HIMDFBHMPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80FC7A0", Offset = "0x80FB5A0", VA = "0x1880FC7A0")]
		[AsyncStateMachine(typeof(PCGHFEMKJJI))]
		private Task<Texture2D> KDIIFMHLNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80FC6F0", Offset = "0x80FB4F0", VA = "0x1880FC6F0", Slot = "10")]
		protected override void IJGHMIJHLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80FC720", Offset = "0x80FB520", VA = "0x1880FC720")]
		private static void KCBOICBPLJE(GameObject NALGDDBNIMM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LECMACIABAJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FBE20", Offset = "0x80FAC20", VA = "0x1880FBE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
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
	[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MLDCMEMBFGM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GFLDJILPEIO("size", MLDCMEMBFGM.Custom)]
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
	private static int JOKDHAACJIK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture ODEMHPFDNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PDEMAECCJNL<GameObject> LMCJGOAKHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private IHGBKKPAEJC MOCEOLFDKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource JJKKCMEFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NONKHMPPJIB<Texture2D> PKLJJGHNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GAOBPBBLMBJ FNDPMHOBDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture PBAHOBLKEJD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int KDMMBLAKAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C00", Offset = "0x80F7A00", VA = "0x1880F8C00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C50", Offset = "0x80F7A50", VA = "0x1880F8C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture AFLHEENGCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80F84D0", Offset = "0x80F72D0", VA = "0x1880F84D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GAOBPBBLMBJ IADIEJHAPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80F8290", Offset = "0x80F7090", VA = "0x1880F8290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PIPGCKMINGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2407A80", Offset = "0x2406880", VA = "0x182407A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int BAEIAJOOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80F81E0", Offset = "0x80F6FE0", VA = "0x1880F81E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80F81D0", Offset = "0x80F6FD0", VA = "0x1880F81D0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80F87E0", Offset = "0x80F75E0", VA = "0x1880F87E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80F86B0", Offset = "0x80F74B0", VA = "0x1880F86B0")]
	private void KHKODIHJIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80F8AD0", Offset = "0x80F78D0", VA = "0x1880F8AD0")]
	public void Set(GAOBPBBLMBJ KPNCHJAAGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80F8AE0", Offset = "0x80F78E0", VA = "0x1880F8AE0")]
	public void Set(Texture HINEJAGCAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80F8AF0", Offset = "0x80F78F0", VA = "0x1880F8AF0")]
	public void Set(JEGLLJBEFAK BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80F8280", Offset = "0x80F7080", VA = "0x1880F8280")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80F88E0", Offset = "0x80F76E0", VA = "0x1880F88E0")]
	public void SetInternal(GAOBPBBLMBJ KPNCHJAAGAI, [Optional] Texture NGABIKFBDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80F88D0", Offset = "0x80F76D0", VA = "0x1880F88D0")]
	public void SetCustomSize(int PKHCABKDPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA5C500", Offset = "0xA5B300", VA = "0x180A5C500")]
	public void SetAntiAliasing(int EACNFBGAGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80F8730", Offset = "0x80F7530", VA = "0x1880F8730")]
	[AsyncStateMachine(typeof(LECMACIABAJ))]
	private void KPPNMPHKDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80F83F0", Offset = "0x80F71F0", VA = "0x1880F83F0")]
	private void EMEHMGCLMHI(Texture HINEJAGCAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80F8B80", Offset = "0x80F7980", VA = "0x1880F8B80")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, BDFOMBKFGEB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float KLFOPFPKGCL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80F8190", Offset = "0x80F6F90", VA = "0x1880F8190")]
	public void SetReferencePoint(Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80F7FA0", Offset = "0x80F6DA0", VA = "0x1880F7FA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80F8170", Offset = "0x80F6F70", VA = "0x1880F8170")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20718E0", Offset = "0x20706E0", VA = "0x1820718E0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AHKHOIJJLDD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static AHKHOIJJLDD ALIGJGFGAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float CKBJPAIPDMI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AC00", Offset = "0x2C09A00", VA = "0x182C0AC00")]
	public AHKHOIJJLDD(float MCKOEGKIKAF)
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
		[Cpp2IlInjected.Address(RVA = "0x80FD570", Offset = "0x80FC370", VA = "0x1880FD570", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
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
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int KJMFDLNPPPK = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int MAIBNOIOEJI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> PLLGAABNEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HNNMHMMCKPJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E70", Offset = "0x80F7C70", VA = "0x1880F8E70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80F8D70", Offset = "0x80F7B70", VA = "0x1880F8D70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80F90C0", Offset = "0x80F7EC0", VA = "0x1880F90C0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GAOBPBBLMBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string IDHKFNPOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AHKHOIJJLDD AHKHOIJJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BFAAJJKGGFE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AKJINBBHHNP(CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBHPBPPACBL(GAOBPBBLMBJ LOKLFHKEJPC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPMKEHMMOCD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOCENLNHBKN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HHDOFNJEKPI(uint? JNBJJNFPLGD, [Out] NONKHMPPJIB<Texture2D> DBMHIDKMPBE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BDKMHPMCAEN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x80F5430", Offset = "0x80F4230", VA = "0x1880F5430")]
	public static bool GDGHIMDJJFL(GAOBPBBLMBJ NHFEELGJIJA, GAOBPBBLMBJ JLAHJDMMIGB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, BDFOMBKFGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80F5520", Offset = "0x80F4320", VA = "0x1880F5520", Slot = "4")]
		public void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BDFOMBKFGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PIEJOAJCLHG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NBLMJMLEDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BKKDDFCPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NGOELDKMCJI
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBAMKHDAKMC(params Type[] MIOOHGINEFJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OAJCHDIOGHK(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OAJCHDIOGHK<T>(T FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OAJCHDIOGHK<T>(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OAJCHDIOGHK(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IKOBFNCGLAP : IDisposable, NGOELDKMCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LNKPIDGOBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> IGIOIGDADFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform PLJICNAACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> JPLKLKBELDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LGIAGPHHJJG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80F7650", Offset = "0x80F6450", VA = "0x1880F7650")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	public static void NPDNKFNEHEP(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80F7860", Offset = "0x80F6660", VA = "0x1880F7860")]
	[UnityEngine.Scripting.Preserve]
	public IKOBFNCGLAP([OLOAAHJODHH(null)] PIEJOAJCLHG AFFFMOAPDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80F6C90", Offset = "0x80F5A90", VA = "0x1880F6C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80F67A0", Offset = "0x80F55A0", VA = "0x1880F67A0", Slot = "5")]
	public void CBAMKHDAKMC(params Type[] MIOOHGINEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80F77D0", Offset = "0x80F65D0", VA = "0x1880F77D0", Slot = "6")]
	public GameObject OAJCHDIOGHK(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAF10", Offset = "0x3BC9D10", VA = "0x183BCAF10", Slot = "7")]
	public T OAJCHDIOGHK<T>(T FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB530", Offset = "0x3BCA330", VA = "0x183BCB530", Slot = "8")]
	public T OAJCHDIOGHK<T>(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, bool NHCNCMICABO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80F7740", Offset = "0x80F6540", VA = "0x1880F7740", Slot = "9")]
	public GameObject OAJCHDIOGHK(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB4F0", Offset = "0x3BCA2F0", VA = "0x183BCB4F0", Slot = "10")]
	public T OAJCHDIOGHK<T>(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAF80", Offset = "0x3BC9D80", VA = "0x183BCAF80")]
	private T OAJCHDIOGHK<T>(GameObject FLFNPLAKMCE, Transform CMDMCJGFCDK, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO, [Out] GameObject HAOIOFNMIEO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB560", Offset = "0x3BCA360", VA = "0x183BCB560")]
	private T OPKHNJPLMAC<T>(GameObject JLNNGPHDMLM, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80F7420", Offset = "0x80F6220", VA = "0x1880F7420")]
	private void JOHLNCJKADB(HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80F6A60", Offset = "0x80F5860", VA = "0x1880F6A60")]
	private void DMDCFOJPJHG(HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80F7310", Offset = "0x80F6110", VA = "0x1880F7310")]
	private void IDAEEDGADEB(Component LPAADBJGJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80F67F0", Offset = "0x80F55F0", VA = "0x1880F67F0")]
	private void DMDCFOJPJHG(Component LPAADBJGJNL, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO, bool HEOMLFICOAO, [Optional] Type GGKLODMJOBL, [Optional] Type FENDAMFEAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80F6EE0", Offset = "0x80F5CE0", VA = "0x1880F6EE0")]
	private void GPPHEEFLFNB(Component LPAADBJGJNL, HMEICLGJFBH OAEBFAAHGEJ, bool NHCNCMICABO, bool HEOMLFICOAO, [Optional] Type GGKLODMJOBL, [Optional] Type FENDAMFEAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80F6D70", Offset = "0x80F5B70", VA = "0x1880F6D70")]
	private void FBMGKPNMPNM(GameObject JLNNGPHDMLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HMEICLGJFBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> IPFNNJPGCNH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3BA78D0", Offset = "0x3BA66D0", VA = "0x183BA78D0")]
	public HMEICLGJFBH LAGAMOKKAFA<T>(T LKIGLBJMJDG)
	{
		return default(HMEICLGJFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8000", Offset = "0x3BA6E00", VA = "0x183BA8000")]
	public T LHCLHJGACJJ<T>(T JILABBLHNAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3BA70F0", Offset = "0x3BA5EF0", VA = "0x183BA70F0")]
	public bool GNHMKAHECGG<T>([Out] T LKIGLBJMJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80F6750", Offset = "0x80F5550", VA = "0x1880F6750")]
	public void MKDKKBLDFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OILPHHHONOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GJMGFJJGHFG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E250", Offset = "0x2C0D050", VA = "0x182C0E250")]
	public OILPHHHONOE(bool OMCDGILCMGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BGBHBDBJDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool BJGEPCGGLGH;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80F5510", Offset = "0x80F4310", VA = "0x1880F5510")]
	public BGBHBDBJDIL(bool MGHIHPDDEOH)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, BDFOMBKFGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80FD2B0", Offset = "0x80FC0B0", VA = "0x1880FD2B0", Slot = "4")]
		public void PrepareImposter(HMEICLGJFBH OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
		public Bounds CIFGKLLIDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80F7E10", Offset = "0x80F6C10", VA = "0x1880F7E10")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80F7DD0", Offset = "0x80F6BD0", VA = "0x1880F7DD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80F7D90", Offset = "0x80F6B90", VA = "0x1880F7D90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80F7CA0", Offset = "0x80F6AA0", VA = "0x1880F7CA0")]
		private void EHBOHLAMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
				[Cpp2IlInjected.Address(RVA = "0x80FC670", Offset = "0x80FB470", VA = "0x1880FC670")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80FC660", Offset = "0x80FB460", VA = "0x1880FC660")]
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
		[GFLDJILPEIO("frameCameraToImposterBounds", true)]
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
		[GFLDJILPEIO("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x80F8CD0", Offset = "0x80F7AD0", VA = "0x1880F8CD0")]
		public void LMIMLFPLAAM(Vector3 IAFINMFEHBK, Quaternion IPMJNHFGDDO, float LKANIIAIEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80F8D00", Offset = "0x80F7B00", VA = "0x1880F8D00")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class JEHMGNPGCHA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FHBANKMDOKO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> AFBDFMMEDCB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> BPNMHODPEOG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera GCMLDLPMKOA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> PIFOCAIKFEE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> HDDEJAMGJLO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode HJOONJIKNFA;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color HKPKNBPNEFK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color HHHOBJPHOMG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color KBGHPHHEDPF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap OKBJMNPIFGM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool DMLLIGLMCPA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> AFMPHOJOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80FA560", Offset = "0x80F9360", VA = "0x1880FA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> AFPPCCLOKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80FA020", Offset = "0x80F8E20", VA = "0x1880FA020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GLFKKPBKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80F9150", Offset = "0x80F7F50", VA = "0x1880F9150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80FA960", Offset = "0x80F9760", VA = "0x1880FA960")]
	public static void HILPLECKIEK(Vector3 PAMKIAFMENN, Quaternion CGBLMHAEBPO, ImposterRenderConfig KIDEJIHECGG, bool NANPMNLAJFN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80FA070", Offset = "0x80F8E70", VA = "0x1880FA070")]
	private static void DJPOJGCIBDM(Vector3 PAMKIAFMENN, Quaternion CGBLMHAEBPO, URPLight GCFNEDDKNKP, ImposterRenderConfig.LightConfig NDNIOOJIKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80FAC00", Offset = "0x80F9A00", VA = "0x1880FAC00")]
	public static void MGPBLBECANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80FB390", Offset = "0x80FA190", VA = "0x1880FB390")]
	private static void PFNLMNBDLFA(int KBPPDPCPAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80FA390", Offset = "0x80F9190", VA = "0x1880FA390")]
	public static void DMIPIMEFDID(ImposterRenderConfig KIDEJIHECGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80F93A0", Offset = "0x80F81A0", VA = "0x1880F93A0")]
	public static void AIDFPBDCAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80FB050", Offset = "0x80F9E50", VA = "0x1880FB050")]
	public static void PCNHKJDKFLJ(GameObject GJKCCECDCMB, RenderTexture IEEHJNEMLJL, ImposterRenderConfig KIDEJIHECGG, AHKHOIJJLDD HLEFDCJPCGE, [Optional] Vector3? NOPGIPFFCBF, [Optional] Vector3? FGIPJHHIBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80F9490", Offset = "0x80F8290", VA = "0x1880F9490")]
	private static void BBDPDJCOCCF(GameObject GJKCCECDCMB, RenderTexture IEEHJNEMLJL, ImposterRenderConfig KIDEJIHECGG, AHKHOIJJLDD HLEFDCJPCGE, Vector3 NOPGIPFFCBF, Vector3 FGIPJHHIBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80FA680", Offset = "0x80F9480", VA = "0x1880FA680")]
	private static void HAALEAMJANB(GameObject GJKCCECDCMB, Vector3 JBBPAAFLLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80FACE0", Offset = "0x80F9AE0", VA = "0x1880FACE0")]
	public static void NGLJIPDOEAF(Bounds IMJNBLGOIPH, ImposterRenderConfig KIDEJIHECGG, [Out] Vector3 FGKNCKGHBPH, [Out] Quaternion AKDHHDNHHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x80F9AF0", Offset = "0x80F88F0", VA = "0x1880F9AF0")]
	private static void CDDOAOMDCDC(GameObject FLFNPLAKMCE, ImposterRenderConfig KIDEJIHECGG, AHKHOIJJLDD HLEFDCJPCGE, [Out] Vector3 FGKNCKGHBPH, [Out] Quaternion AKDHHDNHHCE, [Out] float AHJAAKGODGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80FA5B0", Offset = "0x80F93B0", VA = "0x1880FA5B0")]
	public static RenderTexture FNEMNNIJJJF(int GLIFAAMMBIN, int AAILBPBKGGD, RenderTextureFormat PEIENLIDFFI = RenderTextureFormat.ARGB32, string DFJFMJDPENG = "[ImposterRendering]Preview")
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
		public struct EMLOCHOJCPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public OEFHFMHBIFE GKNAAEHDHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject ABHMGDJFKAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture AFLHEENGCHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig KLKACLKKFPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AHKHOIJJLDD AHKHOIJJLDD;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x80F66E0", Offset = "0x80F54E0", VA = "0x1880F66E0")]
			public EMLOCHOJCPM(OEFHFMHBIFE BNGDJOLFKPE, GameObject PBCIAMGLLJB, RenderTexture IEEHJNEMLJL, ImposterRenderConfig JPJAJAPGBEP, AHKHOIJJLDD HLEFDCJPCGE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static GFPGBBFBAJF<EMLOCHOJCPM, RenderTexture> FBFKDPEHONP;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<EMLOCHOJCPM> CHPHPGKGAGK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MKIOKNMFMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x80F5880", Offset = "0x80F4680", VA = "0x1880F5880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80F5C50", Offset = "0x80F4A50", VA = "0x1880F5C50")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GJKCCECDCMB, RenderTexture IEEHJNEMLJL, ImposterRenderConfig KIDEJIHECGG, AHKHOIJJLDD HLEFDCJPCGE, CancellationToken HIMDFBHMPLL, bool CNJGKOGNDPE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80F5670", Offset = "0x80F4470", VA = "0x1880F5670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80F5BB0", Offset = "0x80F49B0", VA = "0x1880F5BB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80F5910", Offset = "0x80F4710", VA = "0x1880F5910")]
		private static Task<RenderTexture> NIFNCNGNLEF(EMLOCHOJCPM LCBHDLADIOM, CancellationToken HIMDFBHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x80F6070", Offset = "0x80F4E70", VA = "0x1880F6070")]
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
