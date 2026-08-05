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
	private readonly struct INFHBGNLHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GOIPMIIIFIO GEMECOCDBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string IMLAMDBADPA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
		public INFHBGNLHFN(GOIPMIIIFIO CPEKCOJILBD, string AFPNHEGFHHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LJGBMCFEKPI : IAsyncStateMachine
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
		public INFHBGNLHFN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E820", Offset = "0x6D7DC20", VA = "0x186D7E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EBE0", Offset = "0x6D7DFE0", VA = "0x186D7EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FEBILMFNENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EJLCMECDGCA<INFHBGNLHFN, GameObject> OFGKMCCPCDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HFFJGLOFCNG NDMCAEFKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EJLCMECDGCA<INFHBGNLHFN, GameObject> IAKEBICGMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D79370", Offset = "0x6D78770", VA = "0x186D79370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ALEIDKLAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D79320", Offset = "0x6D78720", VA = "0x186D79320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D79120", Offset = "0x6D78520", VA = "0x186D79120", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D796A0", Offset = "0x6D78AA0", VA = "0x186D796A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D79200", Offset = "0x6D78600", VA = "0x186D79200")]
	[AsyncStateMachine(typeof(LJGBMCFEKPI))]
	private Task<GameObject> BAGGIOODKAM(INFHBGNLHFN GOBIJCFMPAJ, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D794D0", Offset = "0x6D788D0", VA = "0x186D794D0")]
	public Task<GameObject> LoadItemAsync(GOIPMIIIFIO CPEKCOJILBD, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D79710", Offset = "0x6D78B10", VA = "0x186D79710")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CFIMKOEOMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GOIPMIIIFIO DLGOHIJJBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LFMFNBAGMCB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8AA360", Offset = "0x8A9760", VA = "0x1808AA360")]
		public CFIMKOEOMKF(GOIPMIIIFIO DFKNAJADBGA, Texture LGMOHAIKHNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CAJFHEPMHOM
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
	private class KFHHHOBLJEN : OGNFHNOKBJP<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FOHMKAOHCDP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KFHHHOBLJEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D79750", Offset = "0x6D78B50", VA = "0x186D79750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D79F40", Offset = "0x6D79340", VA = "0x186D79F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GOIPMIIIFIO DFKNAJADBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EDLKOOKPCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig HLBKPLCKICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GBOOEEMCFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D ECMPOEJOEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject BOBBLMAABGH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override ELLFHPNCMJG<Texture2D> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D7DAD0", Offset = "0x6D7CED0", VA = "0x186D7DAD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DCD0", Offset = "0x6D7D0D0", VA = "0x186D7DCD0")]
		public KFHHHOBLJEN(GOIPMIIIFIO DFKNAJADBGA, RenderTexture EDLKOOKPCOD, ImposterRenderConfig HLBKPLCKICM, CancellationToken GBOOEEMCFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DBE0", Offset = "0x6D7CFE0", VA = "0x186D7DBE0")]
		[AsyncStateMachine(typeof(FOHMKAOHCDP))]
		private Task<Texture2D> MONNJFMLIHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DB30", Offset = "0x6D7CF30", VA = "0x186D7DB30", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DB60", Offset = "0x6D7CF60", VA = "0x186D7DB60")]
		private static void IAFAPPDDCEB(GameObject BOBBLMAABGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LDLPOKIKCAK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D7DFE0", Offset = "0x6D7D3E0", VA = "0x186D7DFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
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
	[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private CAJFHEPMHOM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[OMMNAOOCBKL("size", CAJFHEPMHOM.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
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

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int OABGMAHIALH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture AHAFKHPEANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private GNHOCMMMIHH<GameObject> OMAOGIEMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private HBMBDNJPECN IHLHDMHABIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource JGOKKKADFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OELCFEONCJD<Texture2D> FGBCMEABIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GOIPMIIIFIO GMBDBGAJEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture AEIMFGILLIJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MPHAEMHCAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D5A0", Offset = "0x6D7C9A0", VA = "0x186D7D5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D5F0", Offset = "0x6D7C9F0", VA = "0x186D7D5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NMGHNDBGIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7CDA0", Offset = "0x6D7C1A0", VA = "0x186D7CDA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A1350", Offset = "0x8A0750", VA = "0x1808A1350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GOIPMIIIFIO DLGOHIJJBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89CD80", VA = "0x18089D980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D7CC40", Offset = "0x6D7C040", VA = "0x186D7CC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OKMPGMACHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1A23EA0", Offset = "0x1A232A0", VA = "0x181A23EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IIAOLNHEBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D7CF80", Offset = "0x6D7C380", VA = "0x186D7CF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CC20", Offset = "0x6D7C020", VA = "0x186D7CC20")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D180", Offset = "0x6D7C580", VA = "0x186D7D180")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D020", Offset = "0x6D7C420", VA = "0x186D7D020")]
	private void KMJOKLPAGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D480", Offset = "0x6D7C880", VA = "0x186D7D480")]
	public void Set(GOIPMIIIFIO KBDFGNFFIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D470", Offset = "0x6D7C870", VA = "0x186D7D470")]
	public void Set(Texture LGMOHAIKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D490", Offset = "0x6D7C890", VA = "0x186D7D490")]
	public void Set(CFIMKOEOMKF PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CC30", Offset = "0x6D7C030", VA = "0x186D7CC30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D280", Offset = "0x6D7C680", VA = "0x186D7D280")]
	public void SetInternal(GOIPMIIIFIO KBDFGNFFIGF, [Optional] Texture OIGOCNKBFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D270", Offset = "0x6D7C670", VA = "0x186D7D270")]
	public void SetCustomSize(int FMFIJPEGGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
	public void SetAntiAliasing(int EJPNGPIPGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CB70", Offset = "0x6D7BF70", VA = "0x186D7CB70")]
	[AsyncStateMachine(typeof(LDLPOKIKCAK))]
	private void AHMHLEDBEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D0A0", Offset = "0x6D7C4A0", VA = "0x186D7D0A0")]
	private void MMCLMKOKOLH(Texture LGMOHAIKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D520", Offset = "0x6D7C920", VA = "0x186D7D520")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OOCMIKJGMBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float DCNFOPJIDMC = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
	public void PrepareImposter(ODJKGOGCLAI FFHLFAMMNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CB30", Offset = "0x6D7BF30", VA = "0x186D7CB30")]
	public void SetReferencePoint(Vector3 LFDNCFPNICE, Quaternion NGPOFJJCJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C940", Offset = "0x6D7BD40", VA = "0x186D7C940")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CB10", Offset = "0x6D7BF10", VA = "0x186D7CB10")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1926160", Offset = "0x1925560", VA = "0x181926160")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HNNGIMBLGEM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static HNNGIMBLGEM NBPDPLKFEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float DEADBHNFINF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2431B20", Offset = "0x2430F20", VA = "0x182431B20")]
	public HNNGIMBLGEM(float LPECPMIBFII)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FE00", Offset = "0x6D7F200", VA = "0x186D7FE00", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
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
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int GPHEAANANEB = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BGNHDKODGJP = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> NBOFHKBEPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool AAJKLDLKLPM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D800", Offset = "0x6D7CC00", VA = "0x186D7D800")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D700", Offset = "0x6D7CB00", VA = "0x186D7D700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DA40", Offset = "0x6D7CE40", VA = "0x186D7DA40")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GOIPMIIIFIO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OFMKFNCCPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HNNGIMBLGEM HNNGIMBLGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OMBMEFOGPHP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AELMLGJIGFL(CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMLJONGOBCJ(GOIPMIIIFIO OGKFFDCECEL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOFEPANFPJO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICGLPFGDHEO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OIJIIGMIEHN(uint? KODKMCPOHDN, [Out] OELCFEONCJD<Texture2D> EMLPHPBOACI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KHCEHKAGOMF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D7DE90", Offset = "0x6D7D290", VA = "0x186D7DE90")]
	public static bool DNBPJBDFJKE(GOIPMIIIFIO OGOOCFEAPFI, GOIPMIIIFIO BNJNLPIHIOI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, OOCMIKJGMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D78590", Offset = "0x6D77990", VA = "0x186D78590", Slot = "4")]
		public void PrepareImposter(ODJKGOGCLAI FFHLFAMMNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OOCMIKJGMBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ODJKGOGCLAI FFHLFAMMNGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CFFJIFCICHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OMPDLHJNIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> KDCAIODENOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HFFJGLOFCNG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJHIDCIMDEK(params Type[] NJJPENIJJDB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject BMFBCCGOHME(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T BMFBCCGOHME<T>(T ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T BMFBCCGOHME<T>(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject BMFBCCGOHME(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PNNIFFPLJKH : IDisposable, HFFJGLOFCNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BGKEKCMMFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> KGLOIDIENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform JNLMFKPGKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> GGECJFHBKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DGIDLGHJMCG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F340", Offset = "0x6D7E740", VA = "0x186D7F340")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	public static void GIDGJLHOKMO(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F700", Offset = "0x6D7EB00", VA = "0x186D7F700")]
	[UnityEngine.Scripting.Preserve]
	public PNNIFFPLJKH([NDMEANGLJKD(null)] CFFJIFCICHD OLGNNKOAHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EDB0", Offset = "0x6D7E1B0", VA = "0x186D7EDB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F430", Offset = "0x6D7E830", VA = "0x186D7F430", Slot = "5")]
	public void IJHIDCIMDEK(params Type[] NJJPENIJJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EC90", Offset = "0x6D7E090", VA = "0x186D7EC90", Slot = "6")]
	public GameObject BMFBCCGOHME(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30A65F0", Offset = "0x30A59F0", VA = "0x1830A65F0", Slot = "7")]
	public T BMFBCCGOHME<T>(T ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x30A65A0", Offset = "0x30A59A0", VA = "0x1830A65A0", Slot = "8")]
	public T BMFBCCGOHME<T>(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, bool BFMFGDHCMOF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ED20", Offset = "0x6D7E120", VA = "0x186D7ED20", Slot = "9")]
	public GameObject BMFBCCGOHME(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30A5F70", Offset = "0x30A5370", VA = "0x1830A5F70", Slot = "10")]
	public T BMFBCCGOHME<T>(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30A5FD0", Offset = "0x30A53D0", VA = "0x1830A5FD0")]
	private T BMFBCCGOHME<T>(GameObject ACHABLJAHGP, Transform EGIKLIBGODG, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF, [Out] GameObject AHCNCLAOAEP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30A6680", Offset = "0x30A5A80", VA = "0x1830A6680")]
	private T OPCBKDDLEEJ<T>(GameObject NEMCGAENDDH, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F480", Offset = "0x6D7E880", VA = "0x186D7F480")]
	private void OKHKMLFDHIB(Component COMALCPHDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EE90", Offset = "0x6D7E290", VA = "0x186D7EE90")]
	private void FIFNMAKGFPK(Component COMALCPHDMG, ODJKGOGCLAI FFHLFAMMNGJ, bool BFMFGDHCMOF, bool PPKMIMNKODK, [Optional] Type MKGFNEIIBNG, [Optional] Type MMGMPJBCEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F590", Offset = "0x6D7E990", VA = "0x186D7F590")]
	private void ONBEABFGAFH(GameObject NEMCGAENDDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ODJKGOGCLAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> EHJIFLDANIL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3086D80", Offset = "0x3086180", VA = "0x183086D80")]
	public ODJKGOGCLAI NBJJIKECOBK<T>(T PBMCHAIHMML)
	{
		return default(ODJKGOGCLAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30864A0", Offset = "0x30858A0", VA = "0x1830864A0")]
	public T GEKLBPFDDHO<T>(T POOOEFHFGKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30865B0", Offset = "0x30859B0", VA = "0x1830865B0")]
	public bool IELONOIKEDC<T>([Out] T PBMCHAIHMML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GABKOINLINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool BFJDADLIGPE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2431B30", Offset = "0x2430F30", VA = "0x182431B30")]
	public GABKOINLINJ(bool HAFLICCGAFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MCMAMCDFNKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool PEIGHCKFHGB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EC80", Offset = "0x6D7E080", VA = "0x186D7EC80")]
	public MCMAMCDFNKJ(bool FPDELDFLKBA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, OOCMIKJGMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FB40", Offset = "0x6D7EF40", VA = "0x186D7FB40", Slot = "4")]
		public void PrepareImposter(ODJKGOGCLAI FFHLFAMMNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
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
		public Bounds PAGICMPIJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D7C7B0", Offset = "0x6D7BBB0", VA = "0x186D7C7B0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C770", Offset = "0x6D7BB70", VA = "0x186D7C770")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C730", Offset = "0x6D7BB30", VA = "0x186D7C730")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C640", Offset = "0x6D7BA40", VA = "0x186D7C640")]
		private void CHDGILHKBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
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
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6D7EC60", Offset = "0x6D7E060", VA = "0x186D7EC60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D7EC50", Offset = "0x6D7E050", VA = "0x186D7EC50")]
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
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D670", Offset = "0x6D7CA70", VA = "0x186D7D670")]
		public void JEHILENLBGC(Vector3 DIGHGMEJIJE, Quaternion KILAOANAIAL, float KEFOKIJNIJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D6A0", Offset = "0x6D7CAA0", VA = "0x186D7D6A0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HDILFPICGNG
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 KJDEJDPFIPK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> EHMBIECJIBD;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> AEECOKKHPJC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera FINFLPPJDGF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> KMLNGBLFIFF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> NIIKFEBNBLO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode PMGGHMFCDBC;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color JANHLGFIKFK;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color LNJDPGMMMFA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color HOLEEDLBHMO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap DNMGGGEMOCN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool LLHKPAFFHGE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> GLCKDFLNEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7BB40", Offset = "0x6D7AF40", VA = "0x186D7BB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> KHFNPNAHANJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7BA20", Offset = "0x6D7AE20", VA = "0x186D7BA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera CBFAAHJLLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D7C090", Offset = "0x6D7B490", VA = "0x186D7C090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D79FB0", Offset = "0x6D793B0", VA = "0x186D79FB0")]
	public static void ABLFMALOKFM(Vector3 BIDELLHPFAJ, Quaternion MHCEOMPNAAL, ImposterRenderConfig PMIDDEMJOLN, bool LNLAEKFDDHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AF10", Offset = "0x6D7A310", VA = "0x186D7AF10")]
	private static void EPHJILNMCON(Vector3 BIDELLHPFAJ, Quaternion MHCEOMPNAAL, URPLight JPMLILLODJD, ImposterRenderConfig.LightConfig OLBLEFMCICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B510", Offset = "0x6D7A910", VA = "0x186D7B510")]
	public static void FJHPIKGPAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B5F0", Offset = "0x6D7A9F0", VA = "0x186D7B5F0")]
	private static void FPGBHKKMJHF(int OGEAACDAEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BED0", Offset = "0x6D7B2D0", VA = "0x186D7BED0")]
	public static void KLGLEPCKBDL(ImposterRenderConfig PMIDDEMJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C2E0", Offset = "0x6D7B6E0", VA = "0x186D7C2E0")]
	public static void OHBNMKPPFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BB90", Offset = "0x6D7AF90", VA = "0x186D7BB90")]
	public static void KGHCMBBNPGJ(GameObject HPFLKACNOBI, RenderTexture EDLKOOKPCOD, ImposterRenderConfig PMIDDEMJOLN, HNNGIMBLGEM KPAHHGCOEDD, [Optional] Vector3? LAGMDIDOHIK, [Optional] Vector3? FFDKDPBNFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A8C0", Offset = "0x6D79CC0", VA = "0x186D7A8C0")]
	private static void EPDFBIJKAGL(GameObject HPFLKACNOBI, RenderTexture EDLKOOKPCOD, ImposterRenderConfig PMIDDEMJOLN, HNNGIMBLGEM KPAHHGCOEDD, Vector3 LAGMDIDOHIK, Vector3 FFDKDPBNFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B230", Offset = "0x6D7A630", VA = "0x186D7B230")]
	private static void FIKOGCFHLIJ(GameObject HPFLKACNOBI, Vector3 KCBIBJPCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A250", Offset = "0x6D79650", VA = "0x186D7A250")]
	private static void AGLJBAHNIJJ(GameObject ACHABLJAHGP, ImposterRenderConfig PMIDDEMJOLN, HNNGIMBLGEM KPAHHGCOEDD, [Out] Vector3 EFMBMKPLDIB, [Out] Quaternion CBPCBHNMNME, [Out] float CNAOHPJEOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BA70", Offset = "0x6D7AE70", VA = "0x186D7BA70")]
	public static RenderTexture HNPDDGIINIH(int ALKBDMCODNI, int NDMBEPDJGMF, RenderTextureFormat BEMIADMLHDO = RenderTextureFormat.ARGB32, string GLLMFAEAFKO = "[ImposterRendering]Preview")
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
		public struct KKCCMAGKANC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public ONPFBNMJAGM NHKEOGAEEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject JKMDHMMMCBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture NMGHNDBGIJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig JOCOAHPBLIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public HNNGIMBLGEM HNNGIMBLGEM;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6D7DF70", Offset = "0x6D7D370", VA = "0x186D7DF70")]
			public KKCCMAGKANC(ONPFBNMJAGM CCDGLNLOPLO, GameObject BKAECMFCLHF, RenderTexture EDLKOOKPCOD, ImposterRenderConfig HLBKPLCKICM, HNNGIMBLGEM KPAHHGCOEDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static EJLCMECDGCA<KKCCMAGKANC, RenderTexture> CDGJEAKFMCN;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<KKCCMAGKANC> NHOFJIGDHGO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int ECDNJPJOFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6D78C30", Offset = "0x6D78030", VA = "0x186D78C30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D78CC0", Offset = "0x6D780C0", VA = "0x186D78CC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HPFLKACNOBI, RenderTexture EDLKOOKPCOD, ImposterRenderConfig PMIDDEMJOLN, HNNGIMBLGEM KPAHHGCOEDD, CancellationToken GBOOEEMCFEA, bool AEHPMIALEFC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D786E0", Offset = "0x6D77AE0", VA = "0x186D786E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D78B90", Offset = "0x6D77F90", VA = "0x186D78B90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D788F0", Offset = "0x6D77CF0", VA = "0x186D788F0")]
		private static Task<RenderTexture> DNBDMNKFFHM(KKCCMAGKANC DEDLLEGEMEG, CancellationToken GBOOEEMCFEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D790E0", Offset = "0x6D784E0", VA = "0x186D790E0")]
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
