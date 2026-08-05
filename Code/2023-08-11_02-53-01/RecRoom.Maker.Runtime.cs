using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MAGJBJMDLOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AKOMCEKHFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NGAFNCEJONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Vector3 ABMOMIGLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 CPLMCLJINKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EAGECPAADNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AOHDBGCPIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JINCKDAANML
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NIIMKFEHCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GFABOKJMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BGEKHCAPBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 LGGBOPJNGPJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(EAGEBDIDDPK AJPKMCGGPLJ, Collider DAEKDCLDNCE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(EAGEBDIDDPK AJPKMCGGPLJ, Collider DAEKDCLDNCE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(EAGEBDIDDPK AJPKMCGGPLJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 OGLFHOJAFLG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion MFFGJMMCGAI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float IJICPBHJJLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PENPCMNKEKI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CMJGBCHOELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object AMCDGOPKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LDLFAEJDDJB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GameObject DCKJHLJNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Guid JMIPHCGDMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 PFJCFHCNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Quaternion GILONKGEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float DINGNFIDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float KOOJKGHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 PHFEGIBIEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MFAOEPGFMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	MJAIFDHDHGB NOKHCLJBEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HLGMGOCLGFD CKLOBFCNDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OEPKDIHMBCF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool CanUpdateDeformation(Vector3 MMGDEGILIPA, float EMLHLOKKFOB, float FANDICDNALO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void UpdateDeformation(Vector3 MMGDEGILIPA, float EMLHLOKKFOB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CanBeRaycasted(Collider PINIOELHAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JECOIDDMFHB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EONKLOPPKME(in Vector3 HPBBFNNBAFE, in Vector3 JJEDPBPHNPK, ref Vector3 AFJOMCLLIJA, ref Vector3 LKJKFPNAKOC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MOMKMJEPGLE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int MJCHBOOHJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(KJCKPCKEGIG? GKFBFPHHLOH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(FMCIPOPBHDP? FPMLPGBBOFE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DJIHEJCBBPL CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GNKAOFECAHK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IEnumerable<JBJKJFCAHME.NNPIEFKJEGN> FHGMLNNEPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(JBJKJFCAHME.NNPIEFKJEGN AHGHLKHHDCP);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(JBJKJFCAHME.NNPIEFKJEGN AHGHLKHHDCP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MJAIFDHDHGB
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IReadOnlyList<LJBJMOFFMGO> MBAPDHKEFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string LFPHFDFLBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JHEOEEGHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<string> ICJBCGCJNIK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<MJAIFDHDHGB> GBOPGICJEAM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FJFLCKPJLPP, BOFOEJIMBDC> IOKNFJOCKOH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action CKJAJPNBDMK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MCDOGJAOHCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DJIHEJCBBPL CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 PAOMABBDKAH, out Quaternion APAHFEOKBOD, out float MFIGNEPFOBC, out Vector3 JHMFBDLDFKL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? PAOMABBDKAH, Quaternion? APAHFEOKBOD, float? MFIGNEPFOBC, Vector3? JHMFBDLDFKL);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BCGDODDOBPE<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public MJAIFDHDHGB NOKHCLJBEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Collider[] KOONOKLNECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA48BE0", Offset = "0xA473E0", VA = "0x180A48BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Renderer[] KGKCGECOOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8A9770", Offset = "0x8A7F70", VA = "0x1808A9770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MJAIFDHDHGB> GJIGDBLBJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB840", Offset = "0x6ECA040", VA = "0x186ECB840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB8E0", Offset = "0x6ECA0E0", VA = "0x186ECB8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB480", Offset = "0x6EC9C80", VA = "0x186ECB480")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB540", Offset = "0x6EC9D40", VA = "0x186ECB540")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB5F0", Offset = "0x6EC9DF0", VA = "0x186ECB5F0")]
		public void SetIConfigurable(MJAIFDHDHGB NAHDOEJLPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB490", Offset = "0x6EC9C90", VA = "0x186ECB490")]
		public void ChangeCollidersAndRenderers(Collider[] NFHDEGECOHA, Renderer[] IDJCCAAECPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB730", Offset = "0x6EC9F30", VA = "0x186ECB730")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB5A0", Offset = "0x6EC9DA0", VA = "0x186ECB5A0")]
		public void RunConfigurationSpecialActions(MJAIFDHDHGB AMOIAGFLFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB7C0", Offset = "0x6EC9FC0", VA = "0x186ECB7C0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FJBNDMEFPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FKJJMDDDBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BJNNIPGOLHO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JCAEGCAOHJG KNNOBJMHFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JDPFPEDICKO
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JHLIHJNFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	JDCOJJICJBO FDAGCDEHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<bool> NHJMNJKHENA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int CENGLBAEAOL);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NMPJPEAEDCL GetCulprit(DJIHEJCBBPL PPEMAHKEPDE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FINJKEOBBBK
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	object KCCOKJIJDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Type ALCKPMCMECG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Guid CMMKEGIKIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NFNADNHHCCF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece JCLFOLDHLHE);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece JCLFOLDHLHE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider PINIOELHAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKNPBANJLKN
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ADPNAPFPOHI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NCHNBHDGGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CostInfo KGAMIJFFFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IIFMAHFOKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool LANGECACMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool GFDLNCMLLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NECGDCGMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool AIBMHMDCFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IEnumerable<Collider> FPKAELPMLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool IFMPMEACNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BGPJLNEENJD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool KNGMFGNEAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool CPPDNLIHOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JBJKJFCAHME
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate FHBHCINKCMA NNPIEFKJEGN();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<NNPIEFKJEGN> OJOHBDPHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NNPIEFKJEGN> KBDEBHCPLDF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerable<NNPIEFKJEGN> BBDOCKKPFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC930", Offset = "0x6ECB130", VA = "0x186ECC930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCA00", Offset = "0x6ECB200", VA = "0x186ECCA00")]
	public void GLILACFFLBJ(NNPIEFKJEGN AHGHLKHHDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC9A0", Offset = "0x6ECB1A0", VA = "0x186ECC9A0")]
	public bool FNJGHMKCCPI(NNPIEFKJEGN AHGHLKHHDCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum FHBHCINKCMA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum MKBCFKIGNFK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HLGMGOCLGFD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OJIEAIBBAIJ = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long IOGMNLPDFKI = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OBPLCCMPMNP<Guid, ObscuredLong, ObscuredInt, ObscuredBool> PGIKGJPPEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private HPLMGOJMEJK<ObscuredBool, ObscuredInt, ObscuredInt> JPGMPKOFEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun IGMMIIIPDOH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Guid HJMLPLMHOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB980", Offset = "0x6ECA180", VA = "0x186ECB980")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long OHPNGKKMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC540", Offset = "0x6ECAD40", VA = "0x186ECC540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JBIBPJBJELF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBCA0", Offset = "0x6ECA4A0", VA = "0x186ECBCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BMAJLPJPEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBE90", Offset = "0x6ECA690", VA = "0x186ECBE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NOPCDIPHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC000", Offset = "0x6ECA800", VA = "0x186ECC000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int GAPJHLPILBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBDF0", Offset = "0x6ECA5F0", VA = "0x186ECBDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GMBDMKPHMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC380", Offset = "0x6ECAB80", VA = "0x186ECC380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MPFAIGHPNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC340", Offset = "0x6ECAB40", VA = "0x186ECC340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC5F0", Offset = "0x6ECADF0", VA = "0x186ECC5F0")]
	public HLGMGOCLGFD(MonoBehaviourPun DEBHFNDOIFH, string NKNNPFIIPLH, Guid HPCKACIJJEM, long BOPJFPKGCKC, int DHFFCMNALII, bool NKPCCPBOJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC0A0", Offset = "0x6ECA8A0", VA = "0x186ECC0A0")]
	public void IMGBFFDLHBH(NMPJPEAEDCL LBKDDHKFKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC420", Offset = "0x6ECAC20", VA = "0x186ECC420")]
	public void NMBGHOLBPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB9F0", Offset = "0x6ECA1F0", VA = "0x186ECB9F0")]
	public void BDCEDMLOOPD(Guid ELFMNCFAJAJ, long BOPJFPKGCKC, int DHFFCMNALII, bool NKPCCPBOJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBBD0", Offset = "0x6ECA3D0", VA = "0x186ECBBD0")]
	public void BDCEDMLOOPD(HLGMGOCLGFD OALEAAIPGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBD40", Offset = "0x6ECA540", VA = "0x186ECBD40")]
	public void DLKHNDFOBHB(NPEPKNMMPNC NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBF30", Offset = "0x6ECA730", VA = "0x186ECBF30")]
	public void GAAAKIPHAFJ(NPEPKNMMPNC NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6ECC260", Offset = "0x6ECAA60", VA = "0x186ECC260")]
	public static NPEPKNMMPNC MMHKDPGBFAB(Guid HPCKACIJJEM, long BOPJFPKGCKC, int HKJJJEMLLEG, bool NKPCCPBOJHK)
	{
		return null;
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
