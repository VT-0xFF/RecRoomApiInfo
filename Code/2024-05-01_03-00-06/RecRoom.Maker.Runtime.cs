using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
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
		public CINFAOKHFKB<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NMCNOHAMLNF HGPJFNBIAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] CNLOLGOJPBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] PILJNCAEIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<NMCNOHAMLNF> IMCABBJAELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x62551B0", Offset = "0x6253FB0", VA = "0x1862551B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6255260", Offset = "0x6254060", VA = "0x186255260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6254E40", Offset = "0x6253C40", VA = "0x186254E40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6254EF0", Offset = "0x6253CF0", VA = "0x186254EF0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6254F60", Offset = "0x6253D60", VA = "0x186254F60")]
		public void SetIConfigurable(NMCNOHAMLNF DOEJDKOGOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6254E50", Offset = "0x6253C50", VA = "0x186254E50")]
		public void ChangeCollidersAndRenderers(Collider[] LPNCPFFKCNP, Renderer[] NGFEOOFBMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6255090", Offset = "0x6253E90", VA = "0x186255090")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6254F40", Offset = "0x6253D40", VA = "0x186254F40")]
		public void RunConfigurationSpecialActions(NMCNOHAMLNF EAIOLKCAFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6255120", Offset = "0x6253F20", VA = "0x186255120")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BPBIJGILONI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BGAIAHHGDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object ADNDMAGEPOK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LCINLMGEDBI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece ELIDEEMONMN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece ELIDEEMONMN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider PLGNHDMELGA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LDNPHKFFIFI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject DBBMAMINFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid LIIBOEKBMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FLKKJFCKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 PLJDFINMPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 CBHGHOKJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion HCADLGNAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion PEMBIJKPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float KDADLHAHELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float GLALHHELIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 GPNLPIGIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 KACHEDNIJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ANCIFLBDGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NMCNOHAMLNF HGPJFNBIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BEOLNDBHLMK IBNPIFHJLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MKAFGIOPIEK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 NLBAOGAPKBG, float IAPCKIEMHJK, float OHNAFICFNPI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 NLBAOGAPKBG, float IAPCKIEMHJK, bool NKOFMLNHBIG, Space JJGNKAOCGAL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider PLGNHDMELGA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OEMKPPENBPE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EBAJHPHGOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OLMALFACNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 JPHEKILFIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 GJAPAHFOFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HCNEIJFMOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LKDAFGENNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BLFKIBEMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LLEINKKFGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PPDAGHANGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NACCBAAHGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 NJKGJKNGMLM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(IGBLHJMBPJG IABBEJMCAEO, Collider HKBFBJLAPHP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(IGBLHJMBPJG IABBEJMCAEO, Collider HKBFBJLAPHP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(IGBLHJMBPJG IABBEJMCAEO);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 GNOAGOKHCMF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion JHCKLLPPFGH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float HGBKJEFLNMD);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HOFMMHGMFNL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLMLKGAIHLO([In] Vector3 GBCFIJMPBKM, [In] Vector3 BCGALFAPEPA, Vector3 GJKMBNDCEOK, Vector3 ELKFIDDLEIG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EENHELMGNKD
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HPHBIHNOPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MJAHGDHMCCG PALHCDBHLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCGGALEOBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BBBPIPJEGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PBNEGLMBCGH FNJBBOPDEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> MJFAGINOHMK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int DFCEBAFNEHM);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPMIEGMKNGH GetCulprit(APFFHHPPDFB EEKJIAGGFLF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAPLHDBBCKA
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<HHOLFALFBLB.DKCPOEBAJJN> MIKEIABDAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(HHOLFALFBLB.DKCPOEBAJJN ALKNILLOKCE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(HHOLFALFBLB.DKCPOEBAJJN ALKNILLOKCE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KBJECCMBLAD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GBNHKCGFHDB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NJIFIECCJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LNCNOCKFKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JEGIFCPEKHL
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int AALPPPEGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(HHFPIAGHHCN? GLOJFOFNFJH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(JLKPHNPIODB? DIIKGALEMAO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APFFHHPPDFB CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BJMPHGMLHKF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PCPIPOBMKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo GFNIEPKFFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool BBNHOILNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PLHGCMACHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GAHDJGDCFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IPOFFACALHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GIPALEEJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> JJPIOFGCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GIPPJHHDDFE? KNOBMMBAKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool MACGNAPGHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool JNHMLGKMHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PFABGPIGBNC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APFFHHPPDFB CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 JPLKOMKCHGP, [Out] Quaternion IHHAEIJMAPE, [Out] float MKNOOGKJIGK, [Out] Vector3 OIDMIFLHCFL);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? JPLKOMKCHGP, Quaternion? IHHAEIJMAPE, float? MKNOOGKJIGK, Vector3? OIDMIFLHCFL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FHKOIKEHBMO
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object IECNJIFMJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type OFIDKLFDBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid JJNPIHKCAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NMCNOHAMLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<DNJBHCBGHHL> KMIEMDJJELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string FLKKJFCKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string KKHGONCKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> MFNMAIBGPIF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<NMCNOHAMLNF> NBOOGEPNIPP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<OBOIOBLBFHH, ODICJDILCIP> COEGEGLBOGE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action EIIDPGBAPOI;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AAGMIOKIJKL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool NGAEOOBLPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HHOLFALFBLB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate AHBDABAIPPP DKCPOEBAJJN();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<DKCPOEBAJJN> AAJEPJPIHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<DKCPOEBAJJN> ECGJBAEKKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<DKCPOEBAJJN> DJLCHJBFFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62577B0", Offset = "0x62565B0", VA = "0x1862577B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62575A0", Offset = "0x62563A0", VA = "0x1862575A0")]
	public void HDCMKJKDALC(DKCPOEBAJJN ALKNILLOKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6257540", Offset = "0x6256340", VA = "0x186257540")]
	public bool BOIJHFOIOPE(DKCPOEBAJJN ALKNILLOKCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum AHBDABAIPPP
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BEOLNDBHLMK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int MBLHEIHOFBN = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long GANNGEHAENJ = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NFPONIIGCNC<Guid, ObscuredLong, ObscuredInt, ObscuredBool> OLBILFJHLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MMHLLKHGEBA<ObscuredBool, ObscuredInt, ObscuredInt> EIIIKNOJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun IMGBGPELIHK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid HDBGELOGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62542C0", Offset = "0x62530C0", VA = "0x1862542C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long HGMMDCKOKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6254940", Offset = "0x6253740", VA = "0x186254940")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JCENMMMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62549E0", Offset = "0x62537E0", VA = "0x1862549E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IACHNNJBJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6254A70", Offset = "0x6253870", VA = "0x186254A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NEONCFHHHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6254870", Offset = "0x6253670", VA = "0x186254870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NPIJEHFEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62540C0", Offset = "0x6252EC0", VA = "0x1862540C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JMGGHCHBCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6254540", Offset = "0x6253340", VA = "0x186254540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LIDBGCIBIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6254900", Offset = "0x6253700", VA = "0x186254900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6254B00", Offset = "0x6253900", VA = "0x186254B00")]
	public BEOLNDBHLMK(MonoBehaviourPun NINCNBGHDJK, string LLIODNENIAC, Guid FIDDCEAMHPC, long EDLIDFHBLIM, int COCEHEFAMBD, bool MDEADDCIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6254330", Offset = "0x6253130", VA = "0x186254330")]
	public void FACEFCBFGHO(GPMIEGMKNGH ONBALGEONCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6253FB0", Offset = "0x6252DB0", VA = "0x186253FB0")]
	public void ABFKIBPPKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x62545D0", Offset = "0x62533D0", VA = "0x1862545D0")]
	public void HBPIHILNAPB(Guid LAINIPPBKKG, long EDLIDFHBLIM, int COCEHEFAMBD, bool MDEADDCIMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62547A0", Offset = "0x62535A0", VA = "0x1862547A0")]
	public void HBPIHILNAPB(BEOLNDBHLMK GGINNHLAMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62544D0", Offset = "0x62532D0", VA = "0x1862544D0")]
	public void FLBLGFFPKOG(LLFJMNBDEOA LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6254210", Offset = "0x6253010", VA = "0x186254210")]
	public void DMONIKEPBFE(LLFJMNBDEOA LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6254150", Offset = "0x6252F50", VA = "0x186254150")]
	public static LLFJMNBDEOA CPHNDJNALHJ(Guid FIDDCEAMHPC, long EDLIDFHBLIM, int CCADAGLACGP, bool MDEADDCIMFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class BCNEMJOKPLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static BFFNIPDAHMM<Vector3> FKNGFFFEHLK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static BFFNIPDAHMM<Vector3> IHGGFLEFNDP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6253D00", Offset = "0x6252B00", VA = "0x186253D00", Slot = "4")]
	protected virtual void EAJNLBLNDPA(Vector3 OLAHNOGBDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6253D90", Offset = "0x6252B90", VA = "0x186253D90", Slot = "5")]
	protected virtual void MGALPLHDDGD(Vector3 OLAHNOGBDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected BCNEMJOKPLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class BEAAJCEKDBG : BCNEMJOKPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6253F30", Offset = "0x6252D30", VA = "0x186253F30")]
	public void LLFKHOIKAKD(Vector3 JPLKOMKCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6253F00", Offset = "0x6252D00", VA = "0x186253F00")]
	public void BGCGJFEGEBC(Vector3 JPLKOMKCHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6253F60", Offset = "0x6252D60", VA = "0x186253F60")]
	public BEAAJCEKDBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HBFOLPGOCIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker BJCDPGBJCFG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker CJEOHPECNFF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string MGDKGLEOIAK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string AECGBOEFDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] EJJLKNOPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] CPIOLFIDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject PPEKKKNOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider FPEMIIAJDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject FHBGDBGFJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter KKAIENMCGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh EPABCANNHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh HMEIMMHAFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] HFCAIGBEPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> JCFNJGGJAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] FBKCOCGELFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 NKHAGKMIPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 KHGBFFDEMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion EALMDHMGMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] CDLJDHMAGHA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh KHCNEFEGGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6256270", Offset = "0x6255070", VA = "0x186256270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh GCDPEMCKCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6256300", Offset = "0x6255100", VA = "0x186256300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int FFNOMMAPFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6256190", Offset = "0x6254F90", VA = "0x186256190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> JHPIALBGENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62553B0", Offset = "0x62541B0", VA = "0x1862553B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6257070", Offset = "0x6255E70", VA = "0x186257070")]
	public HBFOLPGOCIA(Material CNLGDMLIJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62561B0", Offset = "0x6254FB0", VA = "0x1862561B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6255310", Offset = "0x6254110", VA = "0x186255310")]
	public void ACIJFOBICEJ(Vector2 OELIIMBBLJO, Vector2 GFNAIDOJFEP, Camera KOABNEBFIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62562C0", Offset = "0x62550C0", VA = "0x1862562C0")]
	public void GIGPFGALIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x62568A0", Offset = "0x62556A0", VA = "0x1862568A0")]
	private IEnumerable<Collider> MDGLMEAGJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6256460", Offset = "0x6255260", VA = "0x186256460")]
	private void KMMKEHKCEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62553C0", Offset = "0x62541C0", VA = "0x1862553C0")]
	private void CCKEGJIBJCG(Material LKFHNDFBKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6255520", Offset = "0x6254320", VA = "0x186255520")]
	private void CFPGILFLOMC(Vector2 OELIIMBBLJO, Vector2 GFNAIDOJFEP, Camera KOABNEBFIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6255910", Offset = "0x6254710", VA = "0x186255910")]
	private void CJBCAFNOIJK(Vector2 OELIIMBBLJO, Vector2 GFNAIDOJFEP, Camera KOABNEBFIJD, Vector2 DNHGEGBBLIC, Vector2 PANMIFIPCJF, Vector3 NEAKEEIDPAD, Vector3 KOPGKFHHPIO, Vector3 CGAKODMFKFF, Vector3 NNLAAKDNHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62563F0", Offset = "0x62551F0", VA = "0x1862563F0")]
	private void JOPOBEJHKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62565A0", Offset = "0x62553A0", VA = "0x1862565A0")]
	private void KPBGCGGBPAO(Vector3 FGEKJKMJMLG, Vector3 NEAKEEIDPAD, Vector3 KOPGKFHHPIO, Vector3 CGAKODMFKFF, Vector3 NNLAAKDNHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6256350", Offset = "0x6255150", VA = "0x186256350")]
	private void JEANDJFPIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GHICIHEBPLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OBHAAHEEIFD<T> NDPGMMKGKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AFOPKJFCLNK<T> IJOBKPGOJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> EIABOBLIKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> CBGCJGECMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> NCCBINIPFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> GPNCMFCDCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> LKPGOGNNNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> BAPNBJANDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private EMEPGAHIMIJ JLLJLOICEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private BEAAJCEKDBG KBAPACLMOFO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x393A9D0", Offset = "0x39397D0", VA = "0x18393A9D0")]
	public GHICIHEBPLB(OBHAAHEEIFD<T> NDPGMMKGKFO, AFOPKJFCLNK<T> IJOBKPGOJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x39389D0", Offset = "0x39377D0", VA = "0x1839389D0")]
	public void FIAKOELMJPA(EMEPGAHIMIJ JLLJLOICEHP = EMEPGAHIMIJ.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3939910", Offset = "0x3938710", VA = "0x183939910")]
	public void IEMMDHCMGNP(IEnumerable<Collider> FFECBCMIHAC, Vector3 MKJAGGFMPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x393A950", Offset = "0x3939750", VA = "0x18393A950")]
	public bool NDFHCKOJLFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x393A830", Offset = "0x3939630", VA = "0x18393A830")]
	[CompilerGenerated]
	private bool JALJOFDCDCL(T FCLAAGLFIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x393A8C0", Offset = "0x39396C0", VA = "0x18393A8C0")]
	[CompilerGenerated]
	private bool LOFFPHFDLOF(T FCLAAGLFIOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum EMEPGAHIMIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Remove
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
