using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OJDHGHKLCGL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	public OJDHGHKLCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, FLDIIEDDNHD, HEPGAIPANLN, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IAIMPBMLKHB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xF00AE0", Offset = "0xEFF6E0", VA = "0x180F00AE0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[AEOHFHBJLNK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[AEOHFHBJLNK]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F55640", Offset = "0x5F54240", VA = "0x185F55640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F55600", Offset = "0x5F54200", VA = "0x185F55600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F55680", Offset = "0x5F54280", VA = "0x185F55680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F55850", Offset = "0x5F54450", VA = "0x185F55850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F557C0", Offset = "0x5F543C0", VA = "0x185F557C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x11A6200", Offset = "0x11A4E00", VA = "0x1811A6200")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10C8860", Offset = "0x10C7460", VA = "0x1810C8860")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F555C0", Offset = "0x5F541C0", VA = "0x185F555C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F55730", Offset = "0x5F54330", VA = "0x185F55730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F551F0", Offset = "0x5F53DF0", VA = "0x185F551F0")]
	public void CopyBounds(SavedExtents MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F55520", Offset = "0x5F54120", VA = "0x185F55520")]
	public void SetLocalSpaceBounds(Bounds MOIGDNCDPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x135C3A0", Offset = "0x135AFA0", VA = "0x18135C3A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F55510", Offset = "0x5F54110", VA = "0x185F55510")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F549C0", Offset = "0x5F535C0", VA = "0x185F549C0")]
	private void BLMKHGDLCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F552E0", Offset = "0x5F53EE0", VA = "0x185F552E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F54BB0", Offset = "0x5F537B0", VA = "0x185F54BB0")]
	public static void CalculateLocalBoundsFor(GameObject ENOCMPCACJI, out Bounds MOIGDNCDPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F55220", Offset = "0x5F53E20", VA = "0x185F55220")]
	private static void ECCJAHCCPND(Bounds GHDGKPNPOBN, Color EKIHFBHEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F55540", Offset = "0x5F54140", VA = "0x185F55540")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696B30", VA = "0x180697F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x111F240", Offset = "0x111DE40", VA = "0x18111F240")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB09D30", Offset = "0xB08930", VA = "0x180B09D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public virtual void DPALNENFJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[OJDHGHKLCGL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3108D00", Offset = "0x3107900", VA = "0x183108D00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3108430", Offset = "0x3107030", VA = "0x183108430", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3109240", Offset = "0x3107E40", VA = "0x183109240")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NNAOLMOMHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public NNAOLMOMHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3384FB0", Offset = "0x3383BB0", VA = "0x183384FB0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[OJDHGHKLCGL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1336800", Offset = "0x1335400", VA = "0x181336800", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1336830", Offset = "0x1335430", VA = "0x181336830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1336750", Offset = "0x1335350", VA = "0x181336750", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey BIMCDHOFDCP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x13367B0", Offset = "0x13353B0", VA = "0x1813367B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1336650", Offset = "0x1335250", VA = "0x181336650", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x13361A0", Offset = "0x1334DA0", VA = "0x1813361A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x13359C0", Offset = "0x13345C0", VA = "0x1813359C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1335580", Offset = "0x1334180", VA = "0x181335580", Slot = "14")]
	protected virtual string DLBAAHPGIGI(TKeyVal MOFCMNMIPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1335550", Offset = "0x1334150", VA = "0x181335550", Slot = "4")]
	public bool ContainsKey(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1336540", Offset = "0x1335140", VA = "0x181336540", Slot = "5")]
	public bool TryGetValue(TKey BIMCDHOFDCP, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1335610", Offset = "0x1334210", VA = "0x181335610", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1335610", Offset = "0x1334210", VA = "0x181335610", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1336570", Offset = "0x1335170", VA = "0x181336570")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DJDFKEDPPCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KOIKAOEPPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public KOIKAOEPPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32C6820", Offset = "0x32C5420", VA = "0x1832C6820")]
		internal bool <GetSamples>b__0(global::LJNOPIFCOMG<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float IBKKIPPADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PLNLCDCDNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::LJNOPIFCOMG<float, T>> BBMLLFCPOBB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NFABGCPJENC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2F25A40", Offset = "0x2F24640", VA = "0x182F25A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2F25E40", Offset = "0x2F24A40", VA = "0x182F25E40")]
	public DJDFKEDPPCI(float GMNDMAKLFDA, float DJAHALFABJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2F25C20", Offset = "0x2F24820", VA = "0x182F25C20")]
	public bool JBLKNPBAJON(float MPPFCIMADEL, T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2F25930", Offset = "0x2F24530", VA = "0x182F25930")]
	public int GBGFHNGHHJD(float MPPFCIMADEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2F255F0", Offset = "0x2F241F0", VA = "0x182F255F0")]
	public IEnumerable<T> CMDGPBFGEDM(float MPPFCIMADEL, [Optional] float? NCLPDNPIBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F25990", Offset = "0x2F24590", VA = "0x182F25990")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F25D80", Offset = "0x2F24980", VA = "0x182F25D80")]
	private void OGENFFHCAHL(float MPPFCIMADEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FHOAGDMDMFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OJLKHOFBPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FCLPAKFBGCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float CCBDAKCDAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> MJNLICEKGDI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int ADBJOLLFPIJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private OJLKHOFBPLC[] EJLDCNGHIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MIKIOIHOKLA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float EMFIKIHIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xECB9D0", Offset = "0xECA5D0", VA = "0x180ECB9D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xECB9E0", Offset = "0xECA5E0", VA = "0x180ECB9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28961D0", Offset = "0x2894DD0", VA = "0x1828961D0")]
	public FHOAGDMDMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2896200", Offset = "0x2894E00", VA = "0x182896200")]
	public FHOAGDMDMFC(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2895090", Offset = "0x2893C90", VA = "0x182895090")]
	public void ELGBPIMHCCH(float MPPFCIMADEL, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28958E0", Offset = "0x28944E0", VA = "0x1828958E0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2895350", Offset = "0x2893F50", VA = "0x182895350")]
	public bool GGNGENFAJGG(float CBBEIMNONNO, float JDNINCPFJBD, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2895FE0", Offset = "0x2894BE0", VA = "0x182895FE0")]
	public bool JGNFMOIOFJN(float CBBEIMNONNO, float JDNINCPFJBD, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2894E60", Offset = "0x2893A60", VA = "0x182894E60")]
	public void CEINOECCFPH(float CBBEIMNONNO, float JDNINCPFJBD, List<T> NFMJIELOGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2896150", Offset = "0x2894D50", VA = "0x182896150")]
	private int MNFLKNJLAKO(int KFIMLMLLABJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2895310", Offset = "0x2893F10", VA = "0x182895310")]
	private void FMGPJEDLAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NPOIFJECAMF();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MOHCGNMJBMF(T MGIINGKDNDK, T GNLBKLBDKBA, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CENIBHOEPBG(T GKFICKKHACC, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NIPPNNMGLID(T MGIINGKDNDK, T GNLBKLBDKBA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BCAEAPDLMAO(T MGIINGKDNDK, T GNLBKLBDKBA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HINJHOCGJOE : global::FHOAGDMDMFC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1889E10", Offset = "0x1888A10", VA = "0x181889E10", Slot = "4")]
	protected override Vector3 NPOIFJECAMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x106C020", Offset = "0x106AC20", VA = "0x18106C020", Slot = "5")]
	protected override Vector3 MOHCGNMJBMF(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F50B60", Offset = "0x5F4F760", VA = "0x185F50B60", Slot = "6")]
	protected override Vector3 CENIBHOEPBG(Vector3 GKFICKKHACC, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F50BC0", Offset = "0x5F4F7C0", VA = "0x185F50BC0", Slot = "7")]
	protected override Vector3 NIPPNNMGLID(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F50AF0", Offset = "0x5F4F6F0", VA = "0x185F50AF0", Slot = "8")]
	protected override Vector3 BCAEAPDLMAO(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F50C40", Offset = "0x5F4F840", VA = "0x185F50C40")]
	public HINJHOCGJOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JHPMKGMOOJA : global::FHOAGDMDMFC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F524B0", Offset = "0x5F510B0", VA = "0x185F524B0")]
	public JHPMKGMOOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F52440", Offset = "0x5F51040", VA = "0x185F52440")]
	public JHPMKGMOOJA(int LBLAPKMJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x11684C0", Offset = "0x11670C0", VA = "0x1811684C0", Slot = "4")]
	protected override float NPOIFJECAMF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3813210", Offset = "0x3811E10", VA = "0x183813210", Slot = "5")]
	protected override float MOHCGNMJBMF(float MGIINGKDNDK, float GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5095EE0", Offset = "0x5094AE0", VA = "0x185095EE0", Slot = "6")]
	protected override float CENIBHOEPBG(float GKFICKKHACC, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x249D8F0", Offset = "0x249C4F0", VA = "0x18249D8F0", Slot = "7")]
	protected override float NIPPNNMGLID(float MGIINGKDNDK, float GNLBKLBDKBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F52430", Offset = "0x5F51030", VA = "0x185F52430", Slot = "8")]
	protected override float BCAEAPDLMAO(float MGIINGKDNDK, float GNLBKLBDKBA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EMEKAMMHBHG
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8650", Offset = "0x1AC7250", VA = "0x181AC8650")]
	public static global::FGDHGNAGJPF<T1> GLBIKEOEKPG<T1>(T1 AKLCFJHIHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8150", Offset = "0x1AC6D50", VA = "0x181AC8150")]
	public static global::LJNOPIFCOMG<T1, T2> GLBIKEOEKPG<T1, T2>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1AC81C0", Offset = "0x1AC6DC0", VA = "0x181AC81C0")]
	public static global::EJLOBEOJGJG<T1, T2, T3> GLBIKEOEKPG<T1, T2, T3>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8530", Offset = "0x1AC7130", VA = "0x181AC8530")]
	public static global::ONEAHEBEGJL<T1, T2, T3, T4> GLBIKEOEKPG<T1, T2, T3, T4>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8490", Offset = "0x1AC7090", VA = "0x181AC8490")]
	public static global::NEONLNAGOAD<T1, T2, T3, T4, T5> GLBIKEOEKPG<T1, T2, T3, T4, T5>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1AC83E0", Offset = "0x1AC6FE0", VA = "0x181AC83E0")]
	public static global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8320", Offset = "0x1AC6F20", VA = "0x181AC8320")]
	public static global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6, T7>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8250", Offset = "0x1AC6E50", VA = "0x181AC8250")]
	public static global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> GLBIKEOEKPG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ, T8 EMAJAILPPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1851B60", Offset = "0x1850760", VA = "0x181851B60")]
	[IteratorStateMachine(typeof(MKHDFMGKFEH))]
	public static IEnumerable<global::LJNOPIFCOMG<T1, T2>> AGOOACLCPCI<T1, T2>(IEnumerable<T1> LEOEMBMBFBC, IEnumerable<T2> GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1851D40", Offset = "0x1850940", VA = "0x181851D40")]
	[IteratorStateMachine(typeof(GCHGIKLCPLD))]
	public static IEnumerable<global::EJLOBEOJGJG<T1, T2, T3>> AGOOACLCPCI<T1, T2, T3>(IEnumerable<T1> LEOEMBMBFBC, IEnumerable<T2> GHDGKPNPOBN, IEnumerable<T3> EKIHFBHEKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84D040", Offset = "0x84BC40", VA = "0x18084D040")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D030", Offset = "0x84BC30", VA = "0x18084D030")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84D010", Offset = "0x84BC10", VA = "0x18084D010")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D8B0", Offset = "0x5F4C4B0", VA = "0x185F4D8B0")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D930", Offset = "0x5F4C530", VA = "0x185F4D930")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D900", Offset = "0x5F4C500", VA = "0x185F4D900")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL, int BMFAKOGKLJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D8D0", Offset = "0x5F4C4D0", VA = "0x185F4D8D0")]
	internal static int GHMCNOOHMBG(int FALJFLDFCMC, int PGPOKLIDJCD, int DMPCNGPKMCL, int LOEKPBAFJFE, int BCJGCLJBFKM, int KMLLAKNOBHL, int BMFAKOGKLJO, int MBNHFJPJACK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FGDHGNAGJPF<T1> : IComparable<global::FGDHGNAGJPF<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x17F46E0", Offset = "0x17F32E0", VA = "0x1817F46E0")]
	public FGDHGNAGJPF(T1 AKLCFJHIHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2890720", Offset = "0x288F320", VA = "0x182890720", Slot = "4")]
	public int CompareTo(global::FGDHGNAGJPF<T1> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2890790", Offset = "0x288F390", VA = "0x182890790", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x955D80", Offset = "0x954980", VA = "0x180955D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2890830", Offset = "0x288F430", VA = "0x182890830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LJNOPIFCOMG<T1, T2> : IComparable<global::LJNOPIFCOMG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x250A850", Offset = "0x2509450", VA = "0x18250A850")]
	public LJNOPIFCOMG(T1 AKLCFJHIHNK, T2 OLPHBONPDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2508840", Offset = "0x2507440", VA = "0x182508840", Slot = "4")]
	public int CompareTo(global::LJNOPIFCOMG<T1, T2> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2508E90", Offset = "0x2507A90", VA = "0x182508E90", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2509B30", Offset = "0x2508730", VA = "0x182509B30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x250A1B0", Offset = "0x2508DB0", VA = "0x18250A1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EJLOBEOJGJG<T1, T2, T3> : IComparable<global::EJLOBEOJGJG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2E00350", Offset = "0x2DFEF50", VA = "0x182E00350")]
	public EJLOBEOJGJG(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFC40", Offset = "0x2DFE840", VA = "0x182DFFC40", Slot = "4")]
	public int CompareTo(global::EJLOBEOJGJG<T1, T2, T3> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFD40", Offset = "0x2DFE940", VA = "0x182DFFD40", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2E00030", Offset = "0x2DFEC30", VA = "0x182E00030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2E00090", Offset = "0x2DFEC90", VA = "0x182E00090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ONEAHEBEGJL<T1, T2, T3, T4> : IComparable<global::ONEAHEBEGJL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2769FC0", Offset = "0x2768BC0", VA = "0x182769FC0")]
	public ONEAHEBEGJL(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2769B70", Offset = "0x2768770", VA = "0x182769B70", Slot = "4")]
	public int CompareTo(global::ONEAHEBEGJL<T1, T2, T3, T4> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2769CB0", Offset = "0x27688B0", VA = "0x182769CB0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2769DD0", Offset = "0x27689D0", VA = "0x182769DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2769E90", Offset = "0x2768A90", VA = "0x182769E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NEONLNAGOAD<T1, T2, T3, T4, T5> : IComparable<global::NEONLNAGOAD<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2690800", Offset = "0x268F400", VA = "0x182690800")]
	public NEONLNAGOAD(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x26902F0", Offset = "0x268EEF0", VA = "0x1826902F0", Slot = "4")]
	public int CompareTo(global::NEONLNAGOAD<T1, T2, T3, T4, T5> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2690470", Offset = "0x268F070", VA = "0x182690470", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x26905B0", Offset = "0x268F1B0", VA = "0x1826905B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x26906B0", Offset = "0x268F2B0", VA = "0x1826906B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> : IComparable<global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x339D530", Offset = "0x339C130", VA = "0x18339D530")]
	public GIHHLPNBBLF(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x339CF70", Offset = "0x339BB70", VA = "0x18339CF70", Slot = "4")]
	public int CompareTo(global::GIHHLPNBBLF<T1, T2, T3, T4, T5, T6> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x339D130", Offset = "0x339BD30", VA = "0x18339D130", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x339D2A0", Offset = "0x339BEA0", VA = "0x18339D2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x339D3C0", Offset = "0x339BFC0", VA = "0x18339D3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 LLOBDOBJMGO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3966150", Offset = "0x3964D50", VA = "0x183966150")]
	public ACKKNBPGNFD(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3965AD0", Offset = "0x39646D0", VA = "0x183965AD0", Slot = "4")]
	public int CompareTo(global::ACKKNBPGNFD<T1, T2, T3, T4, T5, T6, T7> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3965CD0", Offset = "0x39648D0", VA = "0x183965CD0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3965E70", Offset = "0x3964A70", VA = "0x183965E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3965FC0", Offset = "0x3964BC0", VA = "0x183965FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 FOGLOONGNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 DNFKIEJHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 DDJONAHELKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 FGGFJBFJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 JIHECKDIGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 OCJOMHPHPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 LLOBDOBJMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 FNBONADOCIL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2283A90", Offset = "0x2282690", VA = "0x182283A90")]
	public FCCHPDAFJEJ(T1 AKLCFJHIHNK, T2 OLPHBONPDPK, T3 AJFPCLGPFDJ, T4 POEDOJJFLGA, T5 NDMCMILHIHB, T6 LPHNEICONNA, T7 NHKIJFILGHJ, T8 EMAJAILPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2283360", Offset = "0x2281F60", VA = "0x182283360", Slot = "4")]
	public int CompareTo(global::FCCHPDAFJEJ<T1, T2, T3, T4, T5, T6, T7, T8> MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x22835B0", Offset = "0x22821B0", VA = "0x1822835B0", Slot = "0")]
	public override bool Equals(object MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2283770", Offset = "0x2282370", VA = "0x182283770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22838E0", Offset = "0x22824E0", VA = "0x1822838E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1901030", Offset = "0x18FFC30", VA = "0x181901030")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F92500", Offset = "0x3F91100", VA = "0x183F92500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float BCFDIMBHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x10CBB50", Offset = "0x10CA750", VA = "0x1810CBB50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F927A0", Offset = "0x3F913A0", VA = "0x183F927A0")]
	public T HNDJMJCNHEL(float NDJEJACDKEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F92900", Offset = "0x3F91500", VA = "0x183F92900")]
	public T OFLBLFPMMGH(float NDJEJACDKEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MOHCGNMJBMF(T MGIINGKDNDK, T GNLBKLBDKBA, float NDJEJACDKEB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3813210", Offset = "0x3811E10", VA = "0x183813210", Slot = "4")]
	protected override float MOHCGNMJBMF(float MGIINGKDNDK, float GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ECA0", Offset = "0x5F4D8A0", VA = "0x185F4ECA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x106C020", Offset = "0x106AC20", VA = "0x18106C020", Slot = "4")]
	protected override Vector3 MOHCGNMJBMF(Vector3 MGIINGKDNDK, Vector3 GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F567E0", Offset = "0x5F553E0", VA = "0x185F567E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D010", Offset = "0x5F4BC10", VA = "0x185F4D010", Slot = "4")]
	protected override Color MOHCGNMJBMF(Color MGIINGKDNDK, Color GNLBKLBDKBA, float NDJEJACDKEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D060", Offset = "0x5F4BC60", VA = "0x185F4D060")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DKGJHLLCHDL : global::OFNFJFAMGLI<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D550", Offset = "0x5F4C150", VA = "0x185F4D550")]
	public DKGJHLLCHDL(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D4F0", Offset = "0x5F4C0F0", VA = "0x185F4D4F0")]
	public DKGJHLLCHDL(NNOPJMODPBD[] NGBDNOPFIDJ, bool POGPOIGBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D480", Offset = "0x5F4C080", VA = "0x185F4D480", Slot = "6")]
	protected override uint GEDFFPAJIBB(uint IAIMPBMLKHB, string GKFICKKHACC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDLNGMDIBIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FDLNGMDIBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OAMOLMBHKGN
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LPAGGOAEGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<OIGDPEFJPLN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LPAGGOAEGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F53680", Offset = "0x5F52280", VA = "0x185F53680")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OIGDPEFJPLN>> GLMFPOBMGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int KNEECEJPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int OKNDEHJOKGG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCEC360", Offset = "0xCEAF60", VA = "0x180CEC360")]
	private OAMOLMBHKGN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<OIGDPEFJPLN>> JEEAKIIOILI, int OCDHAMCKHGC, int LJHJJDLEMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F53EB0", Offset = "0x5F52AB0", VA = "0x185F53EB0")]
	public static OAMOLMBHKGN KCNAIILPDFM()
	{
		return default(OAMOLMBHKGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F53AC0", Offset = "0x5F526C0", VA = "0x185F53AC0")]
	public (int, int, Task) GHEEGHJCLIA(int KOKPOEFBIML, [Optional] CancellationToken ADCKNELPFOJ)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F539E0", Offset = "0x5F525E0", VA = "0x185F539E0")]
	public void FFGOPJFCEBO(int KOKPOEFBIML, int LJHJJDLEMKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class APBPNHKBAFN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> MCLMIDHFLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> MBKPIGGFJFM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GFDLDMBAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x287DAB0", Offset = "0x287C6B0", VA = "0x18287DAB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> KMNHDDOCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B272A0", Offset = "0x2B25EA0", VA = "0x182B272A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x25590B0", Offset = "0x2557CB0", VA = "0x1825590B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x363FA60", Offset = "0x363E660", VA = "0x18363FA60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x363F250", Offset = "0x363DE50", VA = "0x18363F250")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x363F440", Offset = "0x363E040", VA = "0x18363F440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x363EED0", Offset = "0x363DAD0", VA = "0x18363EED0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x363F8B0", Offset = "0x363E4B0", VA = "0x18363F8B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27DF810", Offset = "0x27DE410", VA = "0x1827DF810", Slot = "9")]
	public void Add(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x363EEA0", Offset = "0x363DAA0", VA = "0x18363EEA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x363EF30", Offset = "0x363DB30", VA = "0x18363EF30", Slot = "8")]
	public bool ContainsKey(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x363EF90", Offset = "0x363DB90", VA = "0x18363EF90", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x363F880", Offset = "0x363E480", VA = "0x18363F880", Slot = "10")]
	public bool Remove(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x363F880", Offset = "0x363E480", VA = "0x18363F880", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x363F950", Offset = "0x363E550", VA = "0x18363F950", Slot = "11")]
	public bool TryGetValue(TKey BIMCDHOFDCP, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x363F3C0", Offset = "0x363DFC0", VA = "0x18363F3C0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x363EFC0", Offset = "0x363DBC0", VA = "0x18363EFC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x363F0C0", Offset = "0x363DCC0", VA = "0x18363F0C0")]
	public void ELGBPIMHCCH(TVal FIHIOAOIPNG, TKey BIMCDHOFDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x363F100", Offset = "0x363DD00", VA = "0x18363F100")]
	public void ELGBPIMHCCH(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x363F520", Offset = "0x363E120", VA = "0x18363F520")]
	public bool MMDFCNEELDN(TVal BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x363F4C0", Offset = "0x363E0C0", VA = "0x18363F4C0")]
	public bool KOOJGAMNGBI(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A41030", Offset = "0x2A3FC30", VA = "0x182A41030")]
	public bool DOHHNJJEEIG(TVal BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A41030", Offset = "0x2A3FC30", VA = "0x182A41030")]
	public bool DOHHNJJEEIG(KeyValuePair<TVal, TKey> MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x363F390", Offset = "0x363DF90", VA = "0x18363F390")]
	public bool GINCMLLPDOD(TVal BIMCDHOFDCP, out TKey GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x363F310", Offset = "0x363DF10", VA = "0x18363F310")]
	public IEnumerator<KeyValuePair<TVal, TKey>> GGACKCNAKED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x363F140", Offset = "0x363DD40", VA = "0x18363F140")]
	private void GBAOBEDBANH(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x363ED60", Offset = "0x363D960", VA = "0x18363ED60")]
	private void AENHIGPGMKI(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x363F6D0", Offset = "0x363E2D0", VA = "0x18363F6D0")]
	private bool NPHFNODOKBI(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x363F790", Offset = "0x363E390", VA = "0x18363F790")]
	private bool NPHFNODOKBI(TVal FIHIOAOIPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x363F980", Offset = "0x363E580", VA = "0x18363F980")]
	public APBPNHKBAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JJOODFODJOE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::JJOODFODJOE<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x31ACB80", Offset = "0x31AB780", VA = "0x1831ACB80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2F20", Offset = "0x2EC1B20", VA = "0x182EC2F20")]
		public Enumerator(global::JJOODFODJOE<T> NFMJIELOGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x31A9860", Offset = "0x31A8460", VA = "0x1831A9860", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x31AB3D0", Offset = "0x31A9FD0", VA = "0x1831AB3D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x31A8F60", Offset = "0x31A7B60", VA = "0x1831A8F60")]
		private void FEGAICJJDPO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] PAACEHPKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int IOGAMBOBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int EJDDJHJACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int OPAPEIICLLC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E37240", Offset = "0x3E35E40", VA = "0x183E37240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E37650", Offset = "0x3E36250", VA = "0x183E37650")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E37870", Offset = "0x3E36470", VA = "0x183E37870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E381C0", Offset = "0x3E36DC0", VA = "0x183E381C0")]
	public JJOODFODJOE(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E37420", Offset = "0x3E36020", VA = "0x183E37420")]
	public void ELGBPIMHCCH(T NDJEJACDKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E368A0", Offset = "0x3E354A0", VA = "0x183E368A0")]
	public void CIOCKIHBBLE(IEnumerable<T> HIPOJJABCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E377D0", Offset = "0x3E363D0", VA = "0x183E377D0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E37A70", Offset = "0x3E36670", VA = "0x183E37A70")]
	public void KNODKDJMCEN(int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E379E0", Offset = "0x3E365E0", VA = "0x183E379E0")]
	public void IFDLBGGBBLI(int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E37DA0", Offset = "0x3E369A0", VA = "0x183E37DA0")]
	public void NHNMLLALKJF(T[] EJLDCNGHIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E375D0", Offset = "0x3E361D0", VA = "0x183E375D0")]
	public Enumerator EMHOENNLHOC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E38040", Offset = "0x3E36C40", VA = "0x183E38040", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E38040", Offset = "0x3E36C40", VA = "0x183E38040", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E36E80", Offset = "0x3E35A80", VA = "0x183E36E80")]
	private int DLIGJKGCCJK(int BNNEENLPEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E37280", Offset = "0x3E35E80", VA = "0x183E37280")]
	private int EFKCIFJDIBL(int BNNEENLPEFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class JNHGDPHDOEN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FD70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x40A4540", Offset = "0x40A3140", VA = "0x1840A4540", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x40A45E0", Offset = "0x40A31E0", VA = "0x1840A45E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x40A44E0", Offset = "0x40A30E0", VA = "0x1840A44E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFF0", Offset = "0x2BB9BF0", VA = "0x182BBAFF0")]
	public JNHGDPHDOEN(Func<Internal, External> IEPBJFBIJCM, Func<External, Internal> FGIDPBOLFPN, bool PHLJIIECGMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x40A4200", Offset = "0x40A2E00", VA = "0x1840A4200", Slot = "6")]
	public int IndexOf(External MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x40A3E80", Offset = "0x40A2A80", VA = "0x1840A3E80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x40A3EE0", Offset = "0x40A2AE0", VA = "0x1840A3EE0", Slot = "13")]
	public bool Contains(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x40A3F70", Offset = "0x40A2B70", VA = "0x1840A3F70", Slot = "14")]
	public void CopyTo(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x40A3D90", Offset = "0x40A2990", VA = "0x1840A3D90", Slot = "11")]
	public void Add(External MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x40A42F0", Offset = "0x40A2EF0", VA = "0x1840A42F0", Slot = "7")]
	public void Insert(int BNNEENLPEFO, External MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x40A4450", Offset = "0x40A3050", VA = "0x1840A4450", Slot = "15")]
	public bool Remove(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x40A4390", Offset = "0x40A2F90", VA = "0x1840A4390", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x40A4190", Offset = "0x40A2D90", VA = "0x1840A4190", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x23DC0A0", Offset = "0x23DACA0", VA = "0x1823DC0A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class ACIGMFOPGPF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3965A30", Offset = "0x3964630", VA = "0x183965A30", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x39659D0", Offset = "0x39645D0", VA = "0x1839659D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x17F46E0", Offset = "0x17F32E0", VA = "0x1817F46E0")]
	public ACIGMFOPGPF(Func<Internal, External> IEPBJFBIJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3965980", Offset = "0x3964580", VA = "0x183965980")]
	public ACIGMFOPGPF(IReadOnlyList<Internal> LENGKEKMOEB, Func<Internal, External> IEPBJFBIJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3965760", Offset = "0x3964360", VA = "0x183965760")]
	public void NHNMLLALKJF(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39656F0", Offset = "0x39642F0", VA = "0x1839656F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x23DBBE0", Offset = "0x23DA7E0", VA = "0x1823DBBE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MDHCAHMIMOG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> LNBMIHEECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFB50", Offset = "0x2FEE750", VA = "0x182FEFB50", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFAF0", Offset = "0x2FEE6F0", VA = "0x182FEFAF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x17F46E0", Offset = "0x17F32E0", VA = "0x1817F46E0")]
	public MDHCAHMIMOG(IReadOnlyList<Internal> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF820", Offset = "0x2FEE420", VA = "0x182FEF820")]
	public bool KOOJGAMNGBI(External MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF8C0", Offset = "0x2FEE4C0", VA = "0x182FEF8C0")]
	public void NHNMLLALKJF(External[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF7B0", Offset = "0x2FEE3B0", VA = "0x182FEF7B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x23DC0A0", Offset = "0x23DACA0", VA = "0x1823DC0A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class KGKPPJLLDNK
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BPEKIJOIAJF(object[] MAGEMABOILP);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected KGKPPJLLDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class AAJNGDMNEFI<T> : KGKPPJLLDNK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct HKBNCHEIJFA
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum NGIDLNJEKDE
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NGIDLNJEKDE BIEGICDMJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T KDJGJCHCIKK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int OLPELHMNIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool PCFLOCECMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool LPCKLOPBENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> LIEGKDMDMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<HKBNCHEIJFA> BFAGCMLKEFM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JHMCGHJCCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3962D10", Offset = "0x3961910", VA = "0x183962D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3962FA0", Offset = "0x3961BA0", VA = "0x183962FA0")]
	protected AAJNGDMNEFI(bool LPCKLOPBENG, bool PCFLOCECMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3962E60", Offset = "0x3961A60", VA = "0x183962E60")]
	protected bool LHAKGNDBACI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3962EE0", Offset = "0x3961AE0", VA = "0x183962EE0")]
	protected void OCCGAHLHJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x39628C0", Offset = "0x39614C0", VA = "0x1839628C0")]
	protected void BDGOCPGADCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x295D460", Offset = "0x295C060", VA = "0x18295D460")]
	private static void EMBFJNGFLON<U>(ref List<U> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3962BB0", Offset = "0x39617B0", VA = "0x183962BB0", Slot = "5")]
	public void ELGBPIMHCCH(T KDJGJCHCIKK, bool BAIIBDCELHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3962A70", Offset = "0x3961670", VA = "0x183962A70", Slot = "6")]
	public void DOHHNJJEEIG(T KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3962D50", Offset = "0x3961950", VA = "0x183962D50")]
	public void GJPIAAEOJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KIEAILPLKCH
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DEFJOCBMFPI : global::AAJNGDMNEFI<Action>, KIEAILPLKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D3E0", Offset = "0x5F4BFE0", VA = "0x185F4D3E0")]
	public DEFJOCBMFPI(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D1D0", Offset = "0x5F4BDD0", VA = "0x185F4D1D0")]
	public void PHAMCHAEBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D0A0", Offset = "0x5F4BCA0", VA = "0x185F4D0A0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D170", Offset = "0x5F4BD70", VA = "0x185F4D170")]
	public static DEFJOCBMFPI PFCLMAKECFN(DEFJOCBMFPI GEEHLNKCFJK, Action KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D110", Offset = "0x5F4BD10", VA = "0x185F4D110")]
	public static DEFJOCBMFPI KJPIPKKGFFF(DEFJOCBMFPI GEEHLNKCFJK, Action KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JFOLBFPJAJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HMJKIFGHEAH<T> : global::AAJNGDMNEFI<Action<T>>, global::JFOLBFPJAJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public HMJKIFGHEAH(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0EB0", Offset = "0x2BBFAB0", VA = "0x182BC0EB0")]
	public void PHAMCHAEBGF(T NDJEJACDKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEAA0", Offset = "0x2BBD6A0", VA = "0x182BBEAA0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0530", Offset = "0x2BBF130", VA = "0x182BC0530")]
	public static global::HMJKIFGHEAH<T> PFCLMAKECFN(global::HMJKIFGHEAH<T> GEEHLNKCFJK, Action<T> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0490", Offset = "0x2BBF090", VA = "0x182BC0490")]
	public static global::HMJKIFGHEAH<T> KJPIPKKGFFF(global::HMJKIFGHEAH<T> GEEHLNKCFJK, Action<T> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EIDBHKKGKFL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class ADBKFHJLPAO<T, U> : global::AAJNGDMNEFI<Action<T, U>>, global::EIDBHKKGKFL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public ADBKFHJLPAO(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x396B540", Offset = "0x396A140", VA = "0x18396B540")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3966570", Offset = "0x3965170", VA = "0x183966570", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3969420", Offset = "0x3968020", VA = "0x183969420")]
	public static global::ADBKFHJLPAO<T, U> PFCLMAKECFN(global::ADBKFHJLPAO<T, U> GEEHLNKCFJK, Action<T, U> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3969380", Offset = "0x3967F80", VA = "0x183969380")]
	public static global::ADBKFHJLPAO<T, U> KJPIPKKGFFF(global::ADBKFHJLPAO<T, U> GEEHLNKCFJK, Action<T, U> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MIKCFKEKDPD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PHLHGHHFMBE<T, U, V> : global::AAJNGDMNEFI<Action<T, U, V>>, global::MIKCFKEKDPD<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public PHLHGHHFMBE(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B0C0", Offset = "0x2B59CC0", VA = "0x182B5B0C0")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2B57EC0", Offset = "0x2B56AC0", VA = "0x182B57EC0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2B596B0", Offset = "0x2B582B0", VA = "0x182B596B0")]
	public static global::PHLHGHHFMBE<T, U, V> PFCLMAKECFN(global::PHLHGHHFMBE<T, U, V> GEEHLNKCFJK, Action<T, U, V> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2B59610", Offset = "0x2B58210", VA = "0x182B59610")]
	public static global::PHLHGHHFMBE<T, U, V> KJPIPKKGFFF(global::PHLHGHHFMBE<T, U, V> GEEHLNKCFJK, Action<T, U, V> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PHGJKOBGFIN<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BMHJOPLONMF<T, U, V, W> : global::AAJNGDMNEFI<Action<T, U, V, W>>, global::PHGJKOBGFIN<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public BMHJOPLONMF(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x23CC1E0", Offset = "0x23CADE0", VA = "0x1823CC1E0")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x23CA4D0", Offset = "0x23C90D0", VA = "0x1823CA4D0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x23CB760", Offset = "0x23CA360", VA = "0x1823CB760")]
	public static global::BMHJOPLONMF<T, U, V, W> PFCLMAKECFN(global::BMHJOPLONMF<T, U, V, W> GEEHLNKCFJK, Action<T, U, V, W> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x23CB6C0", Offset = "0x23CA2C0", VA = "0x1823CB6C0")]
	public static global::BMHJOPLONMF<T, U, V, W> KJPIPKKGFFF(global::BMHJOPLONMF<T, U, V, W> GEEHLNKCFJK, Action<T, U, V, W> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface COJAIEDLHLH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W, X> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W, X> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BJHHMPLNPPJ<T, U, V, W, X> : global::AAJNGDMNEFI<Action<T, U, V, W, X>>, global::COJAIEDLHLH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public BJHHMPLNPPJ(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x28862E0", Offset = "0x2884EE0", VA = "0x1828862E0")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL, X IODEOJKDCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2885B90", Offset = "0x2884790", VA = "0x182885B90", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2886240", Offset = "0x2884E40", VA = "0x182886240")]
	public static global::BJHHMPLNPPJ<T, U, V, W, X> PFCLMAKECFN(global::BJHHMPLNPPJ<T, U, V, W, X> GEEHLNKCFJK, Action<T, U, V, W, X> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28861A0", Offset = "0x2884DA0", VA = "0x1828861A0")]
	public static global::BJHHMPLNPPJ<T, U, V, W, X> KJPIPKKGFFF(global::BJHHMPLNPPJ<T, U, V, W, X> GEEHLNKCFJK, Action<T, U, V, W, X> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AGEMOAJAPNH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(Action<T, U, V, W, X, Y> KDJGJCHCIKK, bool BAIIBDCELHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOHHNJJEEIG(Action<T, U, V, W, X, Y> KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class EOJJMHDEFOG<T, U, V, W, X, Y> : global::AAJNGDMNEFI<Action<T, U, V, W, X, Y>>, global::AGEMOAJAPNH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x23CCD00", Offset = "0x23CB900", VA = "0x1823CCD00")]
	public EOJJMHDEFOG(bool LPCKLOPBENG = false, bool PCFLOCECMHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x438AC70", Offset = "0x4389870", VA = "0x18438AC70")]
	public void PHAMCHAEBGF(T NDJEJACDKEB, U GMOOJEKFFCN, V MINMGIMIPFB, W AEPJHDKHAPL, X IODEOJKDCNL, Y FNMMGECGLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4389EB0", Offset = "0x4388AB0", VA = "0x184389EB0", Slot = "4")]
	public override void BPEKIJOIAJF(object[] MAGEMABOILP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x438A600", Offset = "0x4389200", VA = "0x18438A600")]
	public static global::EOJJMHDEFOG<T, U, V, W, X, Y> PFCLMAKECFN(global::EOJJMHDEFOG<T, U, V, W, X, Y> GEEHLNKCFJK, Action<T, U, V, W, X, Y> KDJGJCHCIKK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x438A560", Offset = "0x4389160", VA = "0x18438A560")]
	public static global::EOJJMHDEFOG<T, U, V, W, X, Y> KJPIPKKGFFF(global::EOJJMHDEFOG<T, U, V, W, X, Y> GEEHLNKCFJK, Action<T, U, V, W, X, Y> KDJGJCHCIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JKODBIAOFNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct MPBBAMMGGJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::JKODBIAOFNH<T> KCKDNFEHHHG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2558CE0", Offset = "0x25578E0", VA = "0x182558CE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2558CB0", Offset = "0x25578B0", VA = "0x182558CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x88CB80", Offset = "0x88B780", VA = "0x18088CB80")]
		public MPBBAMMGGJL(global::JKODBIAOFNH<T> KCKDNFEHHHG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JCLCIJJHKHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<MPBBAMMGGJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::JKODBIAOFNH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BD40", Offset = "0x2B0A940", VA = "0x182B0BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5DE0", Offset = "0x1FB49E0", VA = "0x181FB5DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ACLEOKAPDDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<MPBBAMMGGJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::JKODBIAOFNH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x39663C0", Offset = "0x3964FC0", VA = "0x1839663C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5DE0", Offset = "0x1FB49E0", VA = "0x181FB5DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim LDECEDOGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T KNKGBNJOHIA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int LENECOBLFOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3D580", Offset = "0x3E3C180", VA = "0x183E3D580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DBC0", Offset = "0x3E3C7C0", VA = "0x183E3DBC0")]
	public JKODBIAOFNH(in T KNKGBNJOHIA, int EJNAOLLIBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DC60", Offset = "0x3E3C860", VA = "0x183E3DC60")]
	public JKODBIAOFNH(in T KNKGBNJOHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DB80", Offset = "0x3E3C780", VA = "0x183E3DB80")]
	public MPBBAMMGGJL PEHHINIJIDF()
	{
		return default(MPBBAMMGGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DB40", Offset = "0x3E3C740", VA = "0x183E3DB40")]
	public MPBBAMMGGJL PEHHINIJIDF(CancellationToken ADCKNELPFOJ)
	{
		return default(MPBBAMMGGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D9E0", Offset = "0x3E3C5E0", VA = "0x183E3D9E0")]
	[AsyncStateMachine(typeof(global::JKODBIAOFNH<>.JCLCIJJHKHL))]
	public Task<MPBBAMMGGJL> EPNNHKILAAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D700", Offset = "0x3E3C300", VA = "0x183E3D700")]
	[AsyncStateMachine(typeof(global::JKODBIAOFNH<>.ACLEOKAPDDH))]
	public Task<MPBBAMMGGJL> EPNNHKILAAI(CancellationToken ADCKNELPFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FJDOEKHBBJO
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EB20", Offset = "0x5F4D720", VA = "0x185F4EB20")]
	public static global::JKODBIAOFNH<OIGDPEFJPLN> KCNAIILPDFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EB80", Offset = "0x5F4D780", VA = "0x185F4EB80")]
	public static global::JKODBIAOFNH<OIGDPEFJPLN> KCNAIILPDFM(int EJNAOLLIBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8650", Offset = "0x1AC7250", VA = "0x181AC8650")]
	public static global::JKODBIAOFNH<T> KCNAIILPDFM<T>(in T KNKGBNJOHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x22E6520", Offset = "0x22E5120", VA = "0x1822E6520")]
	public static global::JKODBIAOFNH<T> KCNAIILPDFM<T>(in T KNKGBNJOHIA, int EJNAOLLIBEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IDPLKMIMIEO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> APBPDDDDJFB(TRequest BOBJBDACGIL, CancellationToken ADCKNELPFOJ);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum ANNOLJLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class DAAHDICHHED
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float NKLPCEHHKPI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan PIIOLOFIBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int BPFIGBOCLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ANNOLJLMCLP PINOPIIICFC;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly DAAHDICHHED BLGCIDCPBFE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float HODABNPKEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2E0EE90", Offset = "0x2E0DA90", VA = "0x182E0EE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan NILMDNNPDDB
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2E0EF00", Offset = "0x2E0DB00", VA = "0x182E0EF00")]
		public DAAHDICHHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct AGPLGNKGGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest BOBJBDACGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken ADCKNELPFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> NFDBDOFNPHG;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3B96E80", Offset = "0x3B95A80", VA = "0x183B96E80")]
		public AGPLGNKGGGN(TRequest BOBJBDACGIL, TaskCompletionSource<TResult> NFDBDOFNPHG, CancellationToken ADCKNELPFOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EOOJKNBBGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public EOOJKNBBGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OPFBAOLAGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::IDPLKMIMIEO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x276DF90", Offset = "0x276CB90", VA = "0x18276DF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ALJGHPLIHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::IDPLKMIMIEO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AGPLGNKGGGN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3BA8740", Offset = "0x3BA7340", VA = "0x183BA8740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CNHFOIMHBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<AGPLGNKGGGN> AEOGDMLEGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DAAHDICHHED ELAGDDFNKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly APBPDDDDJFB COPKCKLCJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task KLIDLKOBEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HEGMHGNAIAM;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x17F1870", Offset = "0x17F0470", VA = "0x1817F1870")]
	public IDPLKMIMIEO(APBPDDDDJFB COPKCKLCJOJ, [Optional] DAAHDICHHED ELAGDDFNKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x17F0840", Offset = "0x17EF440", VA = "0x1817F0840")]
	public Task<TResult> LPOANLJOFCG(TRequest BOBJBDACGIL, CancellationToken ADCKNELPFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x17F0CE0", Offset = "0x17EF8E0", VA = "0x1817F0CE0")]
	private void NAIOBOAAPKP(AGPLGNKGGGN HNEAAKKCNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x17F0FB0", Offset = "0x17EFBB0", VA = "0x1817F0FB0")]
	[AsyncStateMachine(typeof(global::IDPLKMIMIEO<, >.OPFBAOLAGJM))]
	private Task OIBKFEAINMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x17EFE90", Offset = "0x17EEA90", VA = "0x1817EFE90")]
	private AGPLGNKGGGN DMODAANMPLG()
	{
		return default(AGPLGNKGGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x17F12D0", Offset = "0x17EFED0", VA = "0x1817F12D0")]
	[AsyncStateMachine(typeof(global::IDPLKMIMIEO<, >.ALJGHPLIHFA))]
	private Task PNPDEBLMJMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x17EFCF0", Offset = "0x17EE8F0", VA = "0x1817EFCF0")]
	private void DAGDILFNNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x17F0590", Offset = "0x17EF190", VA = "0x1817F0590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NGJAKFONHKP<TKey, TVal> : global::HNFMCDMACCI<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int LBIBIHNBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> JOBKLDIACKJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int ICJJKCDFKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2698120", Offset = "0x2696D20", VA = "0x182698120", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int HIJNNAJCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2698150", Offset = "0x2696D50", VA = "0x182698150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2697BE0", Offset = "0x26967E0", VA = "0x182697BE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2698180", Offset = "0x2696D80", VA = "0x182698180")]
	public NGJAKFONHKP(int BPGPHKEJPBF, [Optional] HINNMIKLHLE FAHNKMAOADD, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2698080", Offset = "0x2696C80", VA = "0x182698080")]
	public void KNLDNJIAKNN(TKey BIMCDHOFDCP, TVal GKFICKKHACC, bool PPEOOEPAJLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2698000", Offset = "0x2696C00", VA = "0x182698000")]
	public bool JNFPHJDADNB(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2697CE0", Offset = "0x26968E0", VA = "0x182697CE0", Slot = "6")]
	public override bool GINCMLLPDOD(TKey NDKPGBEDMFK, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2697DF0", Offset = "0x26969F0", VA = "0x182697DF0")]
	public bool HMLGCJCHABO(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2697AD0", Offset = "0x26966D0", VA = "0x182697AD0")]
	public bool BMGIKLKNBCN(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2697D80", Offset = "0x2696980", VA = "0x182697D80", Slot = "7")]
	public override void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2697C40", Offset = "0x2696840", VA = "0x182697C40")]
	private bool FOLKGIMCOJK(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class HNFMCDMACCI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int HINNMIKLHLE(TKey BIMCDHOFDCP, TVal GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CCGFDCNDGKI
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey POMHLJMDJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal AMPEKKPGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PEPLKIOHEKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6991B0", Offset = "0x697DB0", VA = "0x1806991B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x82CDE0", Offset = "0x82B9E0", VA = "0x18082CDE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime BJGFBGGDIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE9FA20", Offset = "0xE9E620", VA = "0x180E9FA20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3091AC0", Offset = "0x30906C0", VA = "0x183091AC0")]
		public CCGFDCNDGKI(TKey BIMCDHOFDCP, TVal FIHIOAOIPNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int KJOFOKKOPDC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CCGFDCNDGKI>> NKCNGKBBEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CCGFDCNDGKI> GHNBGCKBBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly HINNMIKLHLE FAHNKMAOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan JGMEAFDBPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KOCLMPDDPHJ LGKDHHCPCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int KLBMGCBECHA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x677020", Offset = "0x675C20", VA = "0x180677020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool FPBCJKKJLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2BC30D0", Offset = "0x2BC1CD0", VA = "0x182BC30D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int ICJJKCDFKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x95F870", Offset = "0x95E470", VA = "0x18095F870", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int CGKKILDEEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x200A5F0", Offset = "0x20091F0", VA = "0x18200A5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x17F3870", Offset = "0x17F2470", VA = "0x1817F3870", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GFDLDMBAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2860", Offset = "0x2BC1460", VA = "0x182BC2860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2640", Offset = "0x2BC1240", VA = "0x182BC2640")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2A80", Offset = "0x2BC1680", VA = "0x182BC2A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3560", Offset = "0x2BC2160", VA = "0x182BC3560")]
	public HNFMCDMACCI(int BPGPHKEJPBF, [Optional] HINNMIKLHLE FAHNKMAOADD, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3630", Offset = "0x2BC2230", VA = "0x182BC3630")]
	public HNFMCDMACCI(TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3510", Offset = "0x2BC2110", VA = "0x182BC3510")]
	public HNFMCDMACCI(int BPGPHKEJPBF, TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3240", Offset = "0x2BC1E40", VA = "0x182BC3240")]
	public HNFMCDMACCI(int BPGPHKEJPBF, HINNMIKLHLE FAHNKMAOADD, TimeSpan JGMEAFDBPNA, [Optional] IEqualityComparer<TKey> OJDJGIJPAHA, [Optional] KOCLMPDDPHJ LGKDHHCPCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2DB0", Offset = "0x2BC19B0", VA = "0x182BC2DB0")]
	public void KFDHJHJCICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3160", Offset = "0x2BC1D60", VA = "0x182BC3160")]
	public void NMFBOCJEJOB(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2280", Offset = "0x2BC0E80", VA = "0x182BC2280")]
	public bool DOHHNJJEEIG(TKey BIMCDHOFDCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2AC0", Offset = "0x2BC16C0", VA = "0x182BC2AC0")]
	private TVal HMFHOBMDMGG(TKey NDKPGBEDMFK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2680", Offset = "0x2BC1280", VA = "0x182BC2680", Slot = "6")]
	public virtual bool GINCMLLPDOD(TKey NDKPGBEDMFK, out TVal GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BC27F0", Offset = "0x2BC13F0", VA = "0x182BC27F0", Slot = "7")]
	public virtual void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC21C0", Offset = "0x2BC0DC0", VA = "0x182BC21C0")]
	private bool AHBCNDBJCHO(CCGFDCNDGKI AGGFHDNDMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC23F0", Offset = "0x2BC0FF0", VA = "0x182BC23F0")]
	private void DONJBBMKIAI(LinkedListNode<CCGFDCNDGKI> LDBBPJCJGCC, TVal IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2BB0", Offset = "0x2BC17B0", VA = "0x182BC2BB0")]
	private void KBFHBLDHILI(TKey BIMCDHOFDCP, TVal GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2F30", Offset = "0x2BC1B30", VA = "0x182BC2F30")]
	private void KJNMJELFCIF(CCGFDCNDGKI AGGFHDNDMJM, TVal IOOLGMDKBMN, int JLCKPDBPCEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class MPFBCGKBHBN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> LENGKEKMOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> NHPLLLGAGMB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x23CE960", Offset = "0x23CD560", VA = "0x1823CE960", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2559780", Offset = "0x2558380", VA = "0x182559780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2558DA0", Offset = "0x25579A0", VA = "0x182558DA0", Slot = "11")]
	public void Add(T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2559320", Offset = "0x2557F20", VA = "0x182559320")]
	public bool NKDBGPNCFBD(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2559560", Offset = "0x2558160", VA = "0x182559560", Slot = "15")]
	public bool Remove(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2559000", Offset = "0x2557C00", VA = "0x182559000", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2559670", Offset = "0x2558270", VA = "0x182559670", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2558DD0", Offset = "0x25579D0", VA = "0x182558DD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x17F6B40", Offset = "0x17F5740", VA = "0x1817F6B40", Slot = "13")]
	public bool Contains(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2558E30", Offset = "0x2557A30", VA = "0x182558E30", Slot = "14")]
	public void CopyTo(T[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x25590B0", Offset = "0x2557CB0", VA = "0x1825590B0", Slot = "6")]
	public int IndexOf(T MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x25591B0", Offset = "0x2557DB0", VA = "0x1825591B0", Slot = "7")]
	public void Insert(int BNNEENLPEFO, T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x25593C0", Offset = "0x2557FC0", VA = "0x1825593C0", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2558F30", Offset = "0x2557B30", VA = "0x182558F30")]
	public void GFIDMAHEEHM(Predicate<T> AHMJOHFIKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2559080", Offset = "0x2557C80", VA = "0x182559080")]
	public void HAACIBKFDHB(Comparison<T> HDKEONKBBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x25596A0", Offset = "0x25582A0", VA = "0x1825596A0")]
	public MPFBCGKBHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PLFOBMNGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5F54040", Offset = "0x5F52C40", VA = "0x185F54040")]
	public static Vector3 NPPGHBPBDJM(this GameObject ENOCMPCACJI, float DHMCCHJCPFO)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2A75130", Offset = "0x2A73D30", VA = "0x182A75130")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F55DC0", Offset = "0x5F549C0", VA = "0x185F55DC0")]
		public SerializedGuid(in Guid LNKDDEDGKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5F55D30", Offset = "0x5F54930", VA = "0x185F55D30")]
		public static SerializedGuid PLOBEEKPPCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F55910", Offset = "0x5F54510", VA = "0x185F55910")]
		public static SerializedGuid DJIECFDHDCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F55BD0", Offset = "0x5F547D0", VA = "0x185F55BD0")]
		public bool ONEAKNMADMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F55D00", Offset = "0x5F54900", VA = "0x185F55D00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F55C60", Offset = "0x5F54860", VA = "0x185F55C60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F55B40", Offset = "0x5F54740", VA = "0x185F55B40")]
		public bool OKMKGFFNCCL(in Guid LNKDDEDGKJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5F559A0", Offset = "0x5F545A0", VA = "0x185F559A0", Slot = "7")]
		public bool Equals(SerializedGuid MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F55A50", Offset = "0x5F54650", VA = "0x185F55A50", Slot = "0")]
		public override bool Equals(object KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F55B30", Offset = "0x5F54730", VA = "0x185F55B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F558E0", Offset = "0x5F544E0", VA = "0x185F558E0", Slot = "6")]
		public int CompareTo(SerializedGuid MCLIMJFDMCF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AAEINDPKIFD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type PIBELKLPADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string AMPOMAILCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool NKCCAFCLNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool DDGMFOFAPMH;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F4C9A0", Offset = "0x5F4B5A0", VA = "0x185F4C9A0")]
	public AAEINDPKIFD(Type DBBHNONBNID, string OJKGNIIJCNE, bool ONCCHDOCPOO = false, bool OEJEHIOFJBC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EPDEBKCILFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HLPKIAGACKB<T> : EPDEBKCILFH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GCNEFACGJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string BECCPFDHFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HLPKIAGACKB<T> LCHKPHKBICE(Action<T> APJILEEAIPO);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HLPKIAGACKB<T> AHJLIDIGLME(Action<T> APJILEEAIPO);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::HLPKIAGACKB<T> NMOEBBCIDMO(Action<T, T> CGBKJOKFDLA);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::HLPKIAGACKB<T> BNAOKHIGPOK(Action<T, T> CGBKJOKFDLA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::HLPKIAGACKB<T> KCMGHILJOKI(Action<string> KEONGEFNJKM);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HLPKIAGACKB<T> IAJNBJDAMAG(Action<string> KEONGEFNJKM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NFHJCFBKDMM<T> : global::HLPKIAGACKB<T>, EPDEBKCILFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::ADBKFHJLPAO<T, T> OGMNGABPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::HMJKIFGHEAH<T> GOFCFCPNJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::HMJKIFGHEAH<string> KDILMHKLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string OMKDGOMBDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BMBFIGGJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool ONDMGDKDGCN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2278190", Offset = "0x2276D90", VA = "0x182278190", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GCNEFACGJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x742540", Offset = "0x741140", VA = "0x180742540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string BECCPFDHFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1AFC670", Offset = "0x1AFB270", VA = "0x181AFC670", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x26963D0", Offset = "0x2694FD0", VA = "0x1826963D0")]
	private void EPMCBJFFJMB(T OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x26966C0", Offset = "0x26952C0", VA = "0x1826966C0")]
	private void MGGBGOADNIO(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2696470", Offset = "0x2695070", VA = "0x182696470")]
	public void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2696770", Offset = "0x2695370", VA = "0x182696770", Slot = "6")]
	public global::HLPKIAGACKB<T> NMOEBBCIDMO(Action<T, T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2696380", Offset = "0x2694F80", VA = "0x182696380", Slot = "7")]
	public global::HLPKIAGACKB<T> BNAOKHIGPOK(Action<T, T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2696630", Offset = "0x2695230", VA = "0x182696630", Slot = "4")]
	public global::HLPKIAGACKB<T> LCHKPHKBICE(Action<T> CGBKJOKFDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2696330", Offset = "0x2694F30", VA = "0x182696330", Slot = "5")]
	public global::HLPKIAGACKB<T> AHJLIDIGLME(Action<T> APJILEEAIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2696590", Offset = "0x2695190", VA = "0x182696590", Slot = "8")]
	public global::HLPKIAGACKB<T> KCMGHILJOKI(Action<string> KEONGEFNJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2696520", Offset = "0x2695120", VA = "0x182696520", Slot = "9")]
	public global::HLPKIAGACKB<T> IAJNBJDAMAG(Action<string> KEONGEFNJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x26967C0", Offset = "0x26953C0", VA = "0x1826967C0")]
	public NFHJCFBKDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MCKAEHMCHLC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class LIGHKAIMJPN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::HLPKIAGACKB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::ENFBMJFPLIK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public LIGHKAIMJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2501880", Offset = "0x2500480", VA = "0x182501880")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AC03C0", Offset = "0x2ABEFC0", VA = "0x182AC03C0")]
	public static global::CGDFFALNLAC<T> DKHIEHMEGIE<T>(this global::HLPKIAGACKB<T> KKFMNOBFKCC, Action<T> PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EEKDJEFEHJA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct AFKKOELPLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JFMAOBFPHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long DIIAALKMPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int BCNMJCJODAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KDAIDJDFBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool EMJFEHIDJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string LNICNJEJKPL;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3B96CE0", Offset = "0x3B958E0", VA = "0x183B96CE0")]
		public AFKKOELPLLE(long JFMAOBFPHPH, int BCNMJCJODAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B96CB0", Offset = "0x3B958B0", VA = "0x183B96CB0")]
		public AFKKOELPLLE(long JFMAOBFPHPH, long DIIAALKMPMH, int BCNMJCJODAJ, int KDAIDJDFBLE, bool EMJFEHIDJDO, string LNICNJEJKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3B96B60", Offset = "0x3B95760", VA = "0x183B96B60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FIFPJEAJENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3B96BD0", Offset = "0x3B957D0", VA = "0x183B96BD0")]
		public int GGLKJLDHAFC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3B96AD0", Offset = "0x3B956D0", VA = "0x183B96AD0")]
		public int DAIDGLNKPEP(int LEPCMIBLCHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3B96AF0", Offset = "0x3B956F0", VA = "0x183B96AF0")]
		public double ELJMDHMOHED()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3B96C20", Offset = "0x3B95820", VA = "0x183B96C20")]
		public AFKKOELPLLE PKBCPNGIJDI(long DIIAALKMPMH, int KDAIDJDFBLE)
		{
			return default(AFKKOELPLLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class CEJMOEANPLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey POMHLJMDJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::EEKDJEFEHJA<TKey> BIEDEPNABLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<CEJMOEANPLC> BBEJKGAFJJM;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string EDOMCDCCLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x22814B0", Offset = "0x22800B0", VA = "0x1822814B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2C2C600", Offset = "0x2C2B200", VA = "0x182C2C600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<CEJMOEANPLC> AIMCOHFHBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x309AD60", Offset = "0x3099960", VA = "0x18309AD60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public AFKKOELPLLE HOIHHEGBLMK
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1669E60", Offset = "0x1668A60", VA = "0x181669E60")]
			[CompilerGenerated]
			get
			{
				return default(AFKKOELPLLE);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x309AE60", Offset = "0x3099A60", VA = "0x18309AE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x309AFA0", Offset = "0x3099BA0", VA = "0x18309AFA0")]
		internal CEJMOEANPLC(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, TKey BIMCDHOFDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x309AE90", Offset = "0x3099A90", VA = "0x18309AE90")]
		public CEJMOEANPLC PINCFFKBOGP(TKey BIMCDHOFDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x309AD80", Offset = "0x3099980", VA = "0x18309AD80")]
		public void HINCMHIALJF(TKey BIMCDHOFDCP, Action<CEJMOEANPLC> KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x35CD460", Offset = "0x35CC060", VA = "0x1835CD460")]
		public T HINCMHIALJF<T>(TKey BIMCDHOFDCP, Func<CEJMOEANPLC, T> FEADACHODCB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x35CD2F0", Offset = "0x35CBEF0", VA = "0x1835CD2F0")]
		[AsyncStateMachine(typeof(NJFLIINNCNO))]
		public Task<T> BIHJCPJLJKO<T>(TKey BIMCDHOFDCP, Func<CEJMOEANPLC, Task<T>> FEADACHODCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x309ABB0", Offset = "0x30997B0", VA = "0x18309ABB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FLJIJPGBNJF : IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, AFKKOELPLLE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EEKDJEFEHJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, AFKKOELPLLE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, AFKKOELPLLE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x289EE00", Offset = "0x289DA00", VA = "0x18289EE00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AFKKOELPLLE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x289EE70", Offset = "0x289DA70", VA = "0x18289EE70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x289EF20", Offset = "0x289DB20", VA = "0x18289EF20")]
		[DebuggerHidden]
		public FLJIJPGBNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x254D8C0", Offset = "0x254C4C0", VA = "0x18254D8C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x289EA90", Offset = "0x289D690", VA = "0x18289EA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x289EED0", Offset = "0x289DAD0", VA = "0x18289EED0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x289EE30", Offset = "0x289DA30", VA = "0x18289EE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x289ED40", Offset = "0x289D940", VA = "0x18289ED40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x200C710", Offset = "0x200B310", VA = "0x18200C710", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ADJOBGLNIFE : IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, AFKKOELPLLE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private CEJMOEANPLC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CEJMOEANPLC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::EEKDJEFEHJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<CEJMOEANPLC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, AFKKOELPLLE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, AFKKOELPLLE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x289EE00", Offset = "0x289DA00", VA = "0x18289EE00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AFKKOELPLLE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x3758550", Offset = "0x3757150", VA = "0x183758550", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x289EF20", Offset = "0x289DB20", VA = "0x18289EF20")]
		[DebuggerHidden]
		public ADJOBGLNIFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x37585B0", Offset = "0x37571B0", VA = "0x1837585B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3757E60", Offset = "0x3756A60", VA = "0x183757E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3758650", Offset = "0x3757250", VA = "0x183758650")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x37586B0", Offset = "0x37572B0", VA = "0x1837586B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3758510", Offset = "0x3757110", VA = "0x183758510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3758400", Offset = "0x3757000", VA = "0x183758400", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AFKKOELPLLE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x37584E0", Offset = "0x37570E0", VA = "0x1837584E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, AFKKOELPLLE> LIDNPCOFMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, AFKKOELPLLE> ONOJDKBGJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::EEKDJEFEHJA<TKey>> FJOBJCMMCCC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string BJMBMGKNCAB = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CEJMOEANPLC HACLDCEMHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int ELGCBOCKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch LGEMGNOLLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int GGLDEPCDCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string ODLAOAEFNCA;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public CEJMOEANPLC DFLIICFHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string EDOMCDCCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675CD0", VA = "0x1806770D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1640", Offset = "0x2DF0240", VA = "0x182DF1640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long NJGAOAMDFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1830", Offset = "0x2DF0430", VA = "0x182DF1830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int HDDDBECGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF16A0", Offset = "0x2DF02A0", VA = "0x182DF16A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1910", Offset = "0x2DF0510", VA = "0x182DF1910")]
	public EEKDJEFEHJA(TKey LJKEMPANMNC, [Optional] int? BCNMJCJODAJ, [Optional][CanBeNull] Stopwatch LGEMGNOLLDB, [Optional] Action<TKey, AFKKOELPLLE> LIDNPCOFMBE, [Optional] Action<TKey, AFKKOELPLLE> ONOJDKBGJMD, [Optional] Action<global::EEKDJEFEHJA<TKey>> FJOBJCMMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DF15B0", Offset = "0x2DF01B0", VA = "0x182DF15B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DF18D0", Offset = "0x2DF04D0", VA = "0x182DF18D0")]
	public void JJDCNDIGJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DF18F0", Offset = "0x2DF04F0", VA = "0x182DF18F0")]
	public void MIPEJPDCOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF17A0", Offset = "0x2DF03A0", VA = "0x182DF17A0")]
	[IteratorStateMachine(typeof(global::EEKDJEFEHJA<>.FLJIJPGBNJF))]
	public IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)> HLCIFFBNHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DF16D0", Offset = "0x2DF02D0", VA = "0x182DF16D0")]
	[IteratorStateMachine(typeof(global::EEKDJEFEHJA<>.ADJOBGLNIFE))]
	private IEnumerable<(TKey, List<TKey>, AFKKOELPLLE)> HLCIFFBNHDP(List<TKey> GEMBNOGNCGO, CEJMOEANPLC PKKECFJJEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1850", Offset = "0x2DF0450", VA = "0x182DF1850")]
	private (long, int) IJCBKGKDHIN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class MFGMLGIGCMI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected MFGMLGIGCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class PJKKKKJBBIC<TKey> : global::MFGMLGIGCMI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string CBCKINHABEP(TKey BIMCDHOFDCP);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CF80", Offset = "0x2B1BB80", VA = "0x182B1CF80")]
	protected string ILPHECKPLNO(double GEMLHHDBOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CF20", Offset = "0x2B1BB20", VA = "0x182B1CF20")]
	protected string IJEPAFPMOMB(int OCBBCADCKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CEE0", Offset = "0x2B1BAE0", VA = "0x182B1CEE0")]
	private static string HHFMNCGGAGG(TKey BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CD00", Offset = "0x2B1B900", VA = "0x182B1CD00", Slot = "4")]
	public override string BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1CDB0", Offset = "0x2B1B9B0", VA = "0x182B1CDB0")]
	public string BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, [NotNull] CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, [NotNull] CBCKINHABEP MNIJGABINDF);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x23DC0A0", Offset = "0x23DACA0", VA = "0x1823DC0A0")]
	protected PJKKKKJBBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KEPKKLAJFKM<TKey> : global::MFGMLGIGCMI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string LIKCLBMJCHH(TKey BIMCDHOFDCP);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int LADMIBOGPME = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string BGNEMLBOLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double FAJOBHPNIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool JFKACFMDECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int GLJKOHGOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> GPDHFDDCHON;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3691BA0", Offset = "0x36907A0", VA = "0x183691BA0")]
	private static string HHFMNCGGAGG(TKey BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3691CC0", Offset = "0x36908C0", VA = "0x183691CC0")]
	public KEPKKLAJFKM(string BGNEMLBOLAB = "F2", double FAJOBHPNIKI = double.MaxValue, bool JFKACFMDECE = false, int GLJKOHGOCHM = int.MaxValue, [Optional] ISet<string> GPDHFDDCHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3691280", Offset = "0x368FE80", VA = "0x183691280", Slot = "4")]
	public override Dictionary<string, string> BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3691BE0", Offset = "0x36907E0", VA = "0x183691BE0")]
	private bool MAGPBAKPDGN(string ACPFEFIPJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3691330", Offset = "0x368FF30", VA = "0x183691330")]
	public Dictionary<string, string> BDJPALOINJI(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, LIKCLBMJCHH MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x36919F0", Offset = "0x36905F0", VA = "0x1836919F0")]
	private string GFEBKACMDCP(StringBuilder PBEEKLJOEAC, List<TKey> FJCINEEONFP, LIKCLBMJCHH MNIJGABINDF, bool IHGJOFHBGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3691870", Offset = "0x3690470", VA = "0x183691870")]
	private static void DLHPPDPLJBH(StringBuilder HPBJCCBAAHB, string CBOKKIBGDAL, bool MDCIOMFPMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MMJMKLMDFLN<TKey> : global::PJKKKKJBBIC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct HIHOFIMKADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CBCKINHABEP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::MMJMKLMDFLN<TKey> EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int NJODMEFNFPB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] MBAPJMCCEAI;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x25539C0", Offset = "0x25525C0", VA = "0x1825539C0")]
	private MMJMKLMDFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x25529D0", Offset = "0x25515D0", VA = "0x1825529D0", Slot = "5")]
	protected override string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x25528E0", Offset = "0x25514E0", VA = "0x1825528E0")]
	[CompilerGenerated]
	internal static string JKCOFILFDLL(string OFEIHLGAINA, TKey BIMCDHOFDCP, ref HIHOFIMKADJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AHCFLELADBF<TKey> : global::PJKKKKJBBIC<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class AFCLGCEFNNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CBCKINHABEP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public AFCLGCEFNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x200AC20", Offset = "0x2009820", VA = "0x18200AC20")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3B990D0", Offset = "0x3B97CD0", VA = "0x183B990D0", Slot = "5")]
	protected override string PPDNKOEOMEE(global::EEKDJEFEHJA<TKey> BIEDEPNABLP, CBCKINHABEP MNIJGABINDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFC0", Offset = "0x2BB9BC0", VA = "0x182BBAFC0")]
	public AHCFLELADBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class CGANNOOEDMA : global::EEKDJEFEHJA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AKNAFFLMDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<CGANNOOEDMA> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public AKNAFFLMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CA10", Offset = "0x5F4B610", VA = "0x185F4CA10")]
		internal void <Wrap>b__0(global::EEKDJEFEHJA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CEC0", Offset = "0x5F4BAC0", VA = "0x185F4CEC0")]
	public CGANNOOEDMA([Optional] string AHHMFMOCNMM, [Optional] int? BCNMJCJODAJ, [Optional] Stopwatch LGEMGNOLLDB, [Optional] Action<string, AFKKOELPLLE> LIDNPCOFMBE, [Optional] Action<string, AFKKOELPLLE> ONOJDKBGJMD, [Optional] Action<CGANNOOEDMA> FJOBJCMMCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CDE0", Offset = "0x5F4B9E0", VA = "0x185F4CDE0")]
	private static Action<global::EEKDJEFEHJA<string>> HINCMHIALJF(Action<CGANNOOEDMA> PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class KOCLMPDDPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class IKHDEFINEEK : KOCLMPDDPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static KOCLMPDDPHJ EBMHMHOHCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5F50CC0", Offset = "0x5F4F8C0", VA = "0x185F50CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime BGPNAFIIPLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5F50D20", Offset = "0x5F4F920", VA = "0x185F50D20", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float LNGCFOHPNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5F50CB0", Offset = "0x5F4F8B0", VA = "0x185F50CB0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5F50E10", Offset = "0x5F4FA10", VA = "0x185F50E10")]
		public IKHDEFINEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static KOCLMPDDPHJ HKOGDEGDJEF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static KOCLMPDDPHJ BLGCIDCPBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5F534F0", Offset = "0x5F520F0", VA = "0x185F534F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime BGPNAFIIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float LNGCFOHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected KOCLMPDDPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DIHGOMFMIOP : global::NAKJFFBHKOD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D440", Offset = "0x5F4C040", VA = "0x185F4D440")]
	public DIHGOMFMIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NAKJFFBHKOD<T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1552B20", Offset = "0x1551720", VA = "0x181552B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1807CF0", Offset = "0x18068F0", VA = "0x181807CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2686C90", Offset = "0x2685890", VA = "0x182686C90")]
	public NAKJFFBHKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EJCGHCAALCG : global::BKJCAMBKCFF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D720", Offset = "0x5F4C320", VA = "0x185F4D720")]
	public EJCGHCAALCG(Exception AENGIJLJHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BKJCAMBKCFF<T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1552B20", Offset = "0x1551720", VA = "0x181552B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1807CF0", Offset = "0x18068F0", VA = "0x181807CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x288AD90", Offset = "0x2889990", VA = "0x18288AD90")]
	public BKJCAMBKCFF(Exception AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HIPDNCIOIAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	FKDPJJAEIFK CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface BHJADGHBKAP<T> : HIPDNCIOIAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class AIFEKKEPJGB<TTask, T> : global::BHJADGHBKAP<T>, HIPDNCIOIAA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class AHLCPMNJNML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::AIFEKKEPJGB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public AHLCPMNJNML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool NIIEOLOAJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> BCLOPCAMFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource DLBKDDIPECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext CLMFMIPNPDD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> IFKENNIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task FNHEJAHJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::CGDFFALNLAC<T> CBPDDIDJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private FKDPJJAEIFK FINLACKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x17F7AD0", Offset = "0x17F66D0", VA = "0x1817F7AD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B6E0", Offset = "0x3B9A2E0", VA = "0x183B9B6E0")]
	static AIFEKKEPJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BA20", Offset = "0x3B9A620", VA = "0x183B9BA20")]
	protected AIFEKKEPJGB(TTask BCLOPCAMFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B1D0", Offset = "0x3B99DD0", VA = "0x183B9B1D0", Slot = "1")]
	~AIFEKKEPJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B1A0", Offset = "0x3B99DA0", VA = "0x183B9B1A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B400", Offset = "0x3B9A000", VA = "0x183B9B400")]
	private void OJNONIJIFNF(bool HIKJHPFEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BABPEFFEKOC(TTask OAEANEPNMHM);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FAJJFHANBFD();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B240", Offset = "0x3B99E40", VA = "0x183B9B240")]
	[CompilerGenerated]
	private void IANABKDOPPE(object BHOMHPIPDNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface NLEJNCDHDND
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PJPENJPCMDL HAKGKONOGND;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GHGOLJAPJCC : NLEJNCDHDND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GIPHLOHNKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float BELAGFODGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float EEPGELFFCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool ILPKKNHIECH;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PEPLKIOHEKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5F4F820", Offset = "0x5F4E420", VA = "0x185F4F820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F9B0", Offset = "0x5F4E5B0", VA = "0x185F4F9B0")]
		public GIPHLOHNKNC(float HOKMFDPKLJA, float OCMAALMMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F830", Offset = "0x5F4E430", VA = "0x185F4F830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class OAOPANMNLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public GHGOLJAPJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OAOPANMNLFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int BPGPHKEJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int NPADLOOMEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly NLEJNCDHDND[] FIENHBCHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PJPENJPCMDL[] KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GIPHLOHNKNC[] EFPKDFOADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GIPHLOHNKNC PNDAANGOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly KLJLIGBHMNL FDGGFENFOHE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GIPHLOHNKNC HIPOHFHALJN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x479A040", Offset = "0x4798C40", VA = "0x18479A040")]
		get
		{
			return default(GIPHLOHNKNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F5C0", Offset = "0x5F4E1C0", VA = "0x185F4F5C0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EDF0", Offset = "0x5F4D9F0", VA = "0x185F4EDF0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F5E0", Offset = "0x5F4E1E0", VA = "0x185F4F5E0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F6A0", Offset = "0x5F4E2A0", VA = "0x185F4F6A0")]
	public GHGOLJAPJCC(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F040", Offset = "0x5F4DC40", VA = "0x185F4F040")]
	public KLJLIGBHMNL FNBADDAMBPP(GIPHLOHNKNC HIPOJJABCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F0D0", Offset = "0x5F4DCD0", VA = "0x185F4F0D0")]
	public void JJJIJHPALPP(NLEJNCDHDND MAFPLPHJMMP, [Optional] GIPHLOHNKNC OFFGIOHNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F570", Offset = "0x5F4E170", VA = "0x185F4F570")]
	internal int NJHNFHMHPKP(NLEJNCDHDND BKKKBIDKIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5F4F520", Offset = "0x5F4E120", VA = "0x185F4F520")]
	internal GIPHLOHNKNC KNIMJDOFMAG(int BNNEENLPEFO)
	{
		return default(GIPHLOHNKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EEB0", Offset = "0x5F4DAB0", VA = "0x185F4EEB0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void PJPENJPCMDL(float CKFOGIIACBB);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class AOBCMFIBGDN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float JKEANAJPICO = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class EKIOABIEPHK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class JGHKDBEGACH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly NLEJNCDHDND BKKKBIDKIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly PJPENJPCMDL PKPGAEOFIGD;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5F523A0", Offset = "0x5F50FA0", VA = "0x185F523A0")]
		public JGHKDBEGACH(NLEJNCDHDND BKKKBIDKIIC, PJPENJPCMDL PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5F52350", Offset = "0x5F50F50", VA = "0x185F52350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D770", Offset = "0x5F4C370", VA = "0x185F4D770")]
	internal static bool NLKLFCGFFEP(float LEOEMBMBFBC, float GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A076D0", Offset = "0x4A062D0", VA = "0x184A076D0")]
	internal static float PDKNDEENLKH(float LEOEMBMBFBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D7F0", Offset = "0x5F4C3F0", VA = "0x185F4D7F0")]
	public static IDisposable PLMKLDDPKNC(this NLEJNCDHDND BKKKBIDKIIC, PJPENJPCMDL PKPGAEOFIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class KLJLIGBHMNL : NLEJNCDHDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float CKFOGIIACBB;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float FNGHHEDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x11A6200", Offset = "0x11A4E00", VA = "0x1811A6200", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5F53390", Offset = "0x5F51F90", VA = "0x185F53390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PJPENJPCMDL HAKGKONOGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5F532F0", Offset = "0x5F51EF0", VA = "0x185F532F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5F53450", Offset = "0x5F52050", VA = "0x185F53450", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KLJLIGBHMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class JOBKHMNLIFN
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5F529E0", Offset = "0x5F515E0", VA = "0x185F529E0")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this FLDIIEDDNHD FHALGLDMIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5F52A50", Offset = "0x5F51650", VA = "0x185F52A50")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this FLDIIEDDNHD FHALGLDMIJN, HashAlgorithmName OKIDPMKAJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5F526B0", Offset = "0x5F512B0", VA = "0x185F526B0")]
	public static bool HIKGJEDMAIG([CanBeNull] this FLDIIEDDNHD FHALGLDMIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5F52840", Offset = "0x5F51440", VA = "0x185F52840")]
	public static bool HIKGJEDMAIG([CanBeNull] this FLDIIEDDNHD FHALGLDMIJN, out string OMKDGOMBDIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F52640", Offset = "0x5F51240", VA = "0x185F52640")]
	private static string CPCBNOFIJNN([CanBeNull] byte[] EHAMCGPFFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5F52520", Offset = "0x5F51120", VA = "0x185F52520")]
	private static bool AEKFOMLPJMI([NotNull] FLDIIEDDNHD FHALGLDMIJN, [CanBeNull] out byte[] NIMEMFKCFHI, [CanBeNull] out byte[] AAGFANMHCPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class NFDDCBNBAPP
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F53900", Offset = "0x5F52500", VA = "0x185F53900")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this HEPGAIPANLN CIBEJLEAPBA, byte[] BNOCCIJBADH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5F536D0", Offset = "0x5F522D0", VA = "0x185F536D0")]
	[NotNull]
	public static byte[] LDGKAKBNNNK(this HEPGAIPANLN CIBEJLEAPBA, HashAlgorithmName OKIDPMKAJIM, byte[] BNOCCIJBADH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface HEPGAIPANLN
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IAIMPBMLKHB);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FLDIIEDDNHD : HEPGAIPANLN
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] OMLOENPLOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] FNNCMIJKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object EOIHMBAJCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class FIJHODFAOIB
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class HCADFCFFKBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F50A70", Offset = "0x5F4F670", VA = "0x185F50A70")]
		public HCADFCFFKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F50A10", Offset = "0x5F4F610", VA = "0x185F50A10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte FJLGIMFOOAB = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte LFCNBMHPFPL = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> EOKGPHHNIBC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool LMINAKOJGKG;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x22E4DB0", Offset = "0x22E39B0", VA = "0x1822E4DB0")]
	[Conditional("UNITY_EDITOR")]
	private static void BLFPAIOLBJI<T>(params T[] HEDNIEKBOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DC40", Offset = "0x5F4C840", VA = "0x185F4DC40")]
	public static IDisposable CNEPIOFMLNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DCE0", Offset = "0x5F4C8E0", VA = "0x185F4DCE0")]
	public static void FABCHMIDPKA(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] GameObject ENOCMPCACJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x22E5130", Offset = "0x22E3D30", VA = "0x1822E5130")]
	public static void FABCHMIDPKA<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] T NMNKGKHKMCB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x22E50A0", Offset = "0x22E3CA0", VA = "0x1822E50A0")]
	public static void EPFOFKAEEFG<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] T CIBEJLEAPBA) where T : HEPGAIPANLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x22E5200", Offset = "0x22E3E00", VA = "0x1822E5200")]
	public static void IJLIGPJIIIK<T>(this IncrementalHash GOKMIKKPGAJ, [CanBeNull] IList<T> KLPKPOGBAJC) where T : HEPGAIPANLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E070", Offset = "0x5F4CC70", VA = "0x185F4E070")]
	private static bool LHMDJKPNGDB([CanBeNull] HEPGAIPANLN CIBEJLEAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DFB0", Offset = "0x5F4CBB0", VA = "0x185F4DFB0")]
	public static void KGANNDNEIGD(this IncrementalHash IAIMPBMLKHB, [CanBeNull] string CPKBGEGPMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E440", Offset = "0x5F4D040", VA = "0x185F4E440")]
	public static void MPGPCEKDDAN(this IncrementalHash IAIMPBMLKHB, long KJOFGBHIPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E7E0", Offset = "0x5F4D3E0", VA = "0x185F4E7E0")]
	public static void ONFKCNBGBKK(this IncrementalHash IAIMPBMLKHB, int OMAMEIPKPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E610", Offset = "0x5F4D210", VA = "0x185F4E610")]
	public static void NMJMGLNMPBM(this IncrementalHash IAIMPBMLKHB, short FCHMHDBPFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DDD0", Offset = "0x5F4C9D0", VA = "0x185F4DDD0")]
	public static void IFOMHCFOPAD(this IncrementalHash IAIMPBMLKHB, byte MPCABHMOOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E270", Offset = "0x5F4CE70", VA = "0x185F4E270")]
	public static void LOODFFGCIGO(this IncrementalHash IAIMPBMLKHB, bool OAIEOGLNLAA, bool AKNMMCGAGKM = false, bool BFLAMOHBOBN = false, bool EFOFMAIOMPE = false, bool AKIGJAAICOK = false, bool PIJDCOBGMCD = false, bool ANHAOIFMNMG = false, bool KPJOJMDCPJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x22E5660", Offset = "0x22E4260", VA = "0x1822E5660")]
	public static void MFJIJCFLJDD<T>(this IncrementalHash IAIMPBMLKHB, T CDLELKLFEPM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E010", Offset = "0x5F4CC10", VA = "0x185F4E010")]
	public static void LCAMLHHAPFN(this IncrementalHash IAIMPBMLKHB, float ADGIBPEEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E9B0", Offset = "0x5F4D5B0", VA = "0x185F4E9B0")]
	public static void PCEGKJKKILO(this IncrementalHash IAIMPBMLKHB, double BILJNLGNJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D9B0", Offset = "0x5F4C5B0", VA = "0x185F4D9B0")]
	public static void CBEOENNKJHD(this IncrementalHash IAIMPBMLKHB, ulong CLMPPKANPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DA20", Offset = "0x5F4C620", VA = "0x185F4DA20")]
	public static void CBIHOHEHNLI(this IncrementalHash IAIMPBMLKHB, uint BAMAGIAKCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DF40", Offset = "0x5F4CB40", VA = "0x185F4DF40")]
	public static void IJFFPJDJEJI(this IncrementalHash IAIMPBMLKHB, ushort FEEAAPKIGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F4E100", Offset = "0x5F4CD00", VA = "0x185F4E100")]
	public static void LKCDKGDJNBM(this IncrementalHash IAIMPBMLKHB, Vector3 FEGKCHOFJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DA80", Offset = "0x5F4C680", VA = "0x185F4DA80")]
	public static void CFOCGGGBGAE(this IncrementalHash IAIMPBMLKHB, Quaternion BPGMIOPHJFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class BFJKPHCOOLN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type PIBELKLPADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string AMPOMAILCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool NKCCAFCLNGC;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CD80", Offset = "0x5F4B980", VA = "0x185F4CD80")]
	public BFJKPHCOOLN(Type DBBHNONBNID, string OJKGNIIJCNE, bool ONCCHDOCPOO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KFKHJPODDLG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F530F0", Offset = "0x5F51CF0", VA = "0x185F530F0")]
	public KFKHJPODDLG(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F53160", Offset = "0x5F51D60", VA = "0x185F53160")]
	public KFKHJPODDLG(string HDKJDEIGPPL, Exception AMBDHCPDPBL)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C390", VA = "0x18068D790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int OJFFKHAMPMJ, int BOGIFKEPNOK]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3FEAE90", Offset = "0x3FE9A90", VA = "0x183FEAE90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3FEAF30", Offset = "0x3FE9B30", VA = "0x183FEAF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAE00", Offset = "0x3FE9A00", VA = "0x183FEAE00")]
		public Array2D(uint BDBMIEBKIGN, uint KDPLJDNGPBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAD80", Offset = "0x3FE9980", VA = "0x183FEAD80")]
		public void GJPIAAEOJAL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F4CAA0", Offset = "0x5F4B6A0", VA = "0x185F4CAA0")]
		public Array2DVector3(uint BDBMIEBKIGN, uint KDPLJDNGPBM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class EDLELGOOFEO
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int MJKPBCGEEAM = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int GOBJOBFOHAI = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class LDNHPEHKDFI<THandle, TValue> : IDisposable where THandle : struct, MKBPDIMFNJC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> EDNKBFACCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> BLHNHHMKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> MOOFFIGKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> FPCNAOECCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int HALMFDFIIKI;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A41030", Offset = "0x2A3FC30", VA = "0x182A41030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A41860", Offset = "0x2A40460", VA = "0x182A41860")]
	public LDNHPEHKDFI(Action<TValue> FPCNAOECCIP, [Optional] Func<TValue> MOOFFIGKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A40E40", Offset = "0x2A3FA40", VA = "0x182A40E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A41100", Offset = "0x2A3FD00", VA = "0x182A41100")]
	public THandle GLBIKEOEKPG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A40EC0", Offset = "0x2A3FAC0", VA = "0x182A40EC0")]
	public THandle ELGBPIMHCCH(TValue GKFICKKHACC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A40D90", Offset = "0x2A3F990", VA = "0x182A40D90")]
	public bool DOHHNJJEEIG(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A41580", Offset = "0x2A40180", VA = "0x182A41580")]
	public bool KDKECGLKPJA(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A41060", Offset = "0x2A3FC60", VA = "0x182A41060")]
	public bool GIGGJMBFKKD(THandle DKBLPJPHEMF, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A412E0", Offset = "0x2A3FEE0", VA = "0x182A412E0")]
	public TValue HMFHOBMDMGG(THandle DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A40F80", Offset = "0x2A3FB80", VA = "0x182A40F80")]
	public bool FONENOMBNOF(THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A41830", Offset = "0x2A40430", VA = "0x182A41830")]
	private THandle MKPKODHHOGB(int BNNEENLPEFO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A40D60", Offset = "0x2A3F960", VA = "0x182A40D60")]
	private TValue DKHIEHMEGIE(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A41650", Offset = "0x2A40250", VA = "0x182A41650")]
	private void KFHKGADMANN(int BNNEENLPEFO, in THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A40F30", Offset = "0x2A3FB30", VA = "0x182A40F30")]
	private void EPMCBJFFJMB(int BNNEENLPEFO, in TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A41720", Offset = "0x2A40320", VA = "0x182A41720")]
	private THandle MHNNAHCKOJC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A40CB0", Offset = "0x2A3F8B0", VA = "0x182A40CB0")]
	private void AFDPIJACDBO(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A40F70", Offset = "0x2A3FB70", VA = "0x182A40F70")]
	private int FEMMPEMHNOB(int OPAPEIICLLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A41690", Offset = "0x2A40290", VA = "0x182A41690")]
	private bool LJDMFBJKDBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DE640", Offset = "0x6DD240", VA = "0x1806DE640")]
	private void GEFPIMPHHJN(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A416A0", Offset = "0x2A402A0", VA = "0x182A416A0")]
	private bool MFJOEMEHEOK(out THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A41330", Offset = "0x2A3FF30", VA = "0x182A41330")]
	private bool HNLPPFMOPPB(out THandle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A41520", Offset = "0x2A40120", VA = "0x182A41520")]
	private void JJADIMNAHFH(THandle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A41400", Offset = "0x2A40000", VA = "0x182A41400")]
	private void IEBEPNEPABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface MKBPDIMFNJC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface LHEMAHBEHEJ<T> : MKBPDIMFNJC, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KKLHOMICENG
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xDBD370", Offset = "0xDBBF70", VA = "0x180DBD370")]
	public static bool KFLILKNDJOF<T>(this T DKBLPJPHEMF, T MCLIMJFDMCF) where T : struct, MKBPDIMFNJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D13160", Offset = "0x3D11D60", VA = "0x183D13160")]
	public static bool ILPKKNHIECH<T>(this T DKBLPJPHEMF) where T : struct, MKBPDIMFNJC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F531E0", Offset = "0x5F51DE0", VA = "0x185F531E0")]
	public static string MKOCOHPKHNF(this MKBPDIMFNJC DKBLPJPHEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class GMLGGPGGHDA
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum ABGAHOGBJBJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int IAIMPBMLKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool BHFMCCNJIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private ABGAHOGBJBJ OPCGPJFHEJB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool PHIHNICJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F502E0", Offset = "0x5F4EEE0", VA = "0x185F502E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool LNPDEIFKFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F501A0", Offset = "0x5F4EDA0", VA = "0x185F501A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5F509E0", Offset = "0x5F4F5E0", VA = "0x185F509E0")]
	public GMLGGPGGHDA(bool BHFMCCNJIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F50360", Offset = "0x5F4EF60", VA = "0x185F50360")]
	public void OMOCPHDJBDE(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FFA0", Offset = "0x5F4EBA0", VA = "0x185F4FFA0")]
	public void FGKDGKFMLKK(int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F50290", Offset = "0x5F4EE90", VA = "0x185F50290")]
	public void LDHKPENJNLH(uint ALJGAHKJLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F50180", Offset = "0x5F4ED80", VA = "0x185F50180")]
	public void HPEAFIBBEMK(bool EJODOKFKAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F502A0", Offset = "0x5F4EEA0", VA = "0x185F502A0")]
	public void LEHBPFPJMCM(long CNDLJBCLDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FED0", Offset = "0x5F4EAD0", VA = "0x185F4FED0")]
	public void EAOBHJDJIMH(ulong HDBLPDFJDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F502F0", Offset = "0x5F4EEF0", VA = "0x185F502F0")]
	public void OADGLMLJILG(string IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FF10", Offset = "0x5F4EB10", VA = "0x185F4FF10")]
	public void FEIJCOGCEPJ(Enum AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F50050", Offset = "0x5F4EC50", VA = "0x185F50050")]
	public void HCLNNILGMAE(IList LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3522CB0", Offset = "0x35218B0", VA = "0x183522CB0")]
	public void OBPLNOMPGPH<T, U>(Dictionary<T, U> KOHNDAFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FB60", Offset = "0x5F4E760", VA = "0x185F4FB60")]
	private void DPBANLNJJNC(IDictionary KOHNDAFJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F50220", Offset = "0x5F4EE20", VA = "0x185F50220")]
	public int KIOMJKNJADM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F501B0", Offset = "0x5F4EDB0", VA = "0x185F501B0")]
	public short JIMNHOOKBOH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5F50040", Offset = "0x5F4EC40", VA = "0x185F50040")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5F4FAF0", Offset = "0x5F4E6F0", VA = "0x185F4FAF0")]
	private void ALJNMADHMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class IOBEMCEJKJD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class BEFGDHKFLFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode DLIFLKHFBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode GEOFAMNLJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public MEIMBIMJKGJ GHGAIHKFDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<MEIMBIMJKGJ> OOCFAGBONDF;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public BEFGDHKFLFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct MEIMBIMJKGJ : IComparable<MEIMBIMJKGJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int KFNPPICHBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant EEOCCKJAOPO;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6A20B0", Offset = "0x6A0CB0", VA = "0x1806A20B0")]
		public MEIMBIMJKGJ(int KFNPPICHBLJ, TClaimant EEOCCKJAOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5F90", Offset = "0x2FF4B90", VA = "0x182FF5F90")]
		public bool CGFCKLPHHNA(in MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6000", Offset = "0x2FF4C00", VA = "0x182FF6000")]
		public bool GHOCCJFPJIA(in MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5FF0", Offset = "0x2FF4BF0", VA = "0x182FF5FF0", Slot = "4")]
		public int CompareTo(MEIMBIMJKGJ MCLIMJFDMCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6010", Offset = "0x2FF4C10", VA = "0x182FF6010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum JMGBOFIBPHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ONAINMHKHNN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::IOBEMCEJKJD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x17F3970", Offset = "0x17F2570", VA = "0x1817F3970")]
		[DebuggerHidden]
		public ONAINMHKHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2763C50", Offset = "0x2762850", VA = "0x182763C50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2763E10", Offset = "0x2762A10", VA = "0x182763E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2763D30", Offset = "0x2762930", VA = "0x182763D30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1AFA970", Offset = "0x1AF9570", VA = "0x181AFA970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::CDPICIPLBFE<BEFGDHKFLFP> JHCMGPDOAIN;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::CDPICIPLBFE<List<MEIMBIMJKGJ>> HEJNEKLDLKO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int PJDMFPAJDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> IDBIHHHOKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, BEFGDHKFLFP> LONLONHDNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private JMGBOFIBPHC GGBPGDBFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DJKFCHELMJI(TNode BAIMHJNEKGI);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NGDOLIFKACN(TNode BAIMHJNEKGI, TClaimant PDEGIOPJFHG, TClaimant LEJMENJGNED);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x180B740", Offset = "0x180A340", VA = "0x18180B740")]
	public IOBEMCEJKJD(JMGBOFIBPHC GGBPGDBFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x180A450", Offset = "0x1809050", VA = "0x18180A450")]
	public void CGBAEKKCMNF(TNode BAIMHJNEKGI, TNode JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x180A990", Offset = "0x1809590", VA = "0x18180A990")]
	public void JHHLOPAHJIG(TClaimant EEOCCKJAOPO, TNode CHJNHBOPNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x180A4D0", Offset = "0x18090D0", VA = "0x18180A4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x180A3B0", Offset = "0x1808FB0", VA = "0x18180A3B0")]
	private void CDFFCOHDMOE(TClaimant EEOCCKJAOPO, TNode DHECCPJOONE, TNode CHJNHBOPNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x180AD50", Offset = "0x1809950", VA = "0x18180AD50")]
	private int KKJKNGODDKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1809FF0", Offset = "0x1808BF0", VA = "0x181809FF0")]
	private void BEBJAOLHLFP(TClaimant EEOCCKJAOPO, TNode INEBGLFHPPK, TNode NMJJIOLIMGA, int KCLBKOHAMAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x180AE80", Offset = "0x1809A80", VA = "0x18180AE80")]
	private void LKLBGECCOHG(MEIMBIMJKGJ DHBAEDMEPHM, BEFGDHKFLFP CJPPBPILFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x180A730", Offset = "0x1809330", VA = "0x18180A730")]
	private void FLNEIHJAHLK(TClaimant EEOCCKJAOPO, TNode INEBGLFHPPK, TNode NMJJIOLIMGA, int KCLBKOHAMAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x180B410", Offset = "0x180A010", VA = "0x18180B410")]
	private void PENDHHHEOCD(MEIMBIMJKGJ DHBAEDMEPHM, TNode BAIMHJNEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x180AC50", Offset = "0x1809850", VA = "0x18180AC50")]
	private void JLOMMNJCKPO(MEIMBIMJKGJ DHBAEDMEPHM, BEFGDHKFLFP CJPPBPILFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x180A2A0", Offset = "0x1808EA0", VA = "0x18180A2A0")]
	private void BJFIMBADHEO(BEFGDHKFLFP CJPPBPILFFF, bool HOMOLDJOFJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x180B0A0", Offset = "0x1809CA0", VA = "0x18180B0A0")]
	private void OHANADCKCNM(BEFGDHKFLFP CJPPBPILFFF, TNode JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x180ADB0", Offset = "0x18099B0", VA = "0x18180ADB0")]
	[IteratorStateMachine(typeof(global::IOBEMCEJKJD<, >.ONAINMHKHNN))]
	private IEnumerable<TNode> KPOEHELOKNH(TNode INEBGLFHPPK, TNode NMJJIOLIMGA, bool KNNDDCFNJIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x180B520", Offset = "0x180A120", VA = "0x18180B520")]
	private BEFGDHKFLFP PLIEHKHKPGO(TNode BAIMHJNEKGI, TNode GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x180AF10", Offset = "0x1809B10", VA = "0x18180AF10")]
	private BEFGDHKFLFP NDPAEFBBOFI(TNode BAIMHJNEKGI, TNode GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x180AA90", Offset = "0x1809690", VA = "0x18180AA90")]
	private void JINLFLNNMGP(BEFGDHKFLFP CJPPBPILFFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class OFNFJFAMGLI<T> : IEnumerable<global::OFNFJFAMGLI<T>.NNOPJMODPBD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct NNOPJMODPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T GKFICKKHACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int BNNEENLPEFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class IOCELGNLCMI : IEnumerator<NNOPJMODPBD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::OFNFJFAMGLI<T> FAEKHNNILJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int BNNEENLPEFO;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1336DC0", Offset = "0x13359C0", VA = "0x181336DC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public NNOPJMODPBD FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x180BAC0", Offset = "0x180A6C0", VA = "0x18180BAC0", Slot = "4")]
			get
			{
				return default(NNOPJMODPBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x67B060", Offset = "0x679C60", VA = "0x18067B060")]
		public IOCELGNLCMI(global::OFNFJFAMGLI<T> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x180B980", Offset = "0x180A580", VA = "0x18180B980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x67B050", Offset = "0x679C50", VA = "0x18067B050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x89DBC0", Offset = "0x89C7C0", VA = "0x18089DBC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct MCPKPHPKGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool ENEDPCBFNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T GKFICKKHACC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int FLBIADGCNEO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> IIFBEDDFCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private MCPKPHPKGGD[] DLGFELIHEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int IJPNNNJJAKL;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int MLBAMNKHLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x697D90", Offset = "0x696990", VA = "0x180697D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x849EB0", Offset = "0x848AB0", VA = "0x180849EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x27EFC60", Offset = "0x27EE860", VA = "0x1827EFC60")]
	public OFNFJFAMGLI(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x27EFD40", Offset = "0x27EE940", VA = "0x1827EFD40")]
	public OFNFJFAMGLI(NNOPJMODPBD[] NGBDNOPFIDJ, bool POGPOIGBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x27EFB70", Offset = "0x27EE770", VA = "0x1827EFB70")]
	public int PHOGHPMHIFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x27EEA00", Offset = "0x27ED600", VA = "0x1827EEA00")]
	private int EDGFEOOLLML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x27EEE90", Offset = "0x27EDA90", VA = "0x1827EEE90", Slot = "6")]
	protected virtual uint GEDFFPAJIBB(uint IAIMPBMLKHB, T GKFICKKHACC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x27EE7C0", Offset = "0x27ED3C0", VA = "0x1827EE7C0")]
	public bool CDFGHPMMOEJ(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x27EEDF0", Offset = "0x27ED9F0", VA = "0x1827EEDF0")]
	public bool FGAIHHMOIFD(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x27EF3B0", Offset = "0x27EDFB0", VA = "0x1827EF3B0")]
	public bool KOOJGAMNGBI(Func<T, bool> DEKNKGENFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x27EF350", Offset = "0x27EDF50", VA = "0x1827EF350")]
	public int KKJPAIFINAF(T GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x27EE830", Offset = "0x27ED430", VA = "0x1827EE830")]
	public T DKHIEHMEGIE(int BNNEENLPEFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x27EEEE0", Offset = "0x27EDAE0", VA = "0x1827EEEE0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x27EF960", Offset = "0x27EE560", VA = "0x1827EF960")]
	public bool NKDBGPNCFBD(T GKFICKKHACC, bool LOCNBDHDOKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x27EF530", Offset = "0x27EE130", VA = "0x1827EF530")]
	public bool NKDBGPNCFBD(T GKFICKKHACC, int BNNEENLPEFO, bool LOCNBDHDOKH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x27EE8F0", Offset = "0x27ED4F0", VA = "0x1827EE8F0")]
	public bool DOHHNJJEEIG(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x27EF210", Offset = "0x27EDE10", VA = "0x1827EF210")]
	public bool IFFLOFKJNLP(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x27EF9A0", Offset = "0x27EE5A0", VA = "0x1827EF9A0")]
	private void NPHFNODOKBI(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x27EEF60", Offset = "0x27EDB60", VA = "0x1827EEF60")]
	public NNOPJMODPBD[] HCHCDCPPAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x27EF2B0", Offset = "0x27EDEB0", VA = "0x1827EF2B0")]
	private int KFLGAPDFLCK(int IOGAMBOBGAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x27EFBE0", Offset = "0x27EE7E0", VA = "0x1827EFBE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x27EFBE0", Offset = "0x27EE7E0", VA = "0x1827EFBE0", Slot = "4")]
	private IEnumerator<NNOPJMODPBD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct OKBAHLBKAOF<Handle> where Handle : MKBPDIMFNJC, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct HANACJOLAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::OKBAHLBKAOF<Handle> BECLDAPDMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int BNNEENLPEFO;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int AOLCBEFGBJN
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3D56CE0", Offset = "0x3D558E0", VA = "0x183D56CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle BKPKGIKLMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x3D566E0", Offset = "0x3D552E0", VA = "0x183D566E0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3D574A0", Offset = "0x3D560A0", VA = "0x183D574A0")]
		public HANACJOLAPF(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3D56A40", Offset = "0x3D55640", VA = "0x183D56A40")]
		public GAJEEOELMJD KCNAIILPDFM(in GAJEEOELMJD KBICBGPAOHG)
		{
			return default(GAJEEOELMJD);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3D569A0", Offset = "0x3D555A0", VA = "0x183D569A0")]
		public DDJOPJJJIED KCNAIILPDFM(in DDJOPJJJIED KBICBGPAOHG)
		{
			return default(DDJOPJJJIED);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3D57380", Offset = "0x3D55F80", VA = "0x183D57380")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3D56EE0", Offset = "0x3D55AE0", VA = "0x183D56EE0")]
		private int OMBFBBFADFP(string HDKJDEIGPPL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3D56330", Offset = "0x3D54F30", VA = "0x183D56330")]
		private Handle AENLMFCPFAB(string HDKJDEIGPPL)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct GAJEEOELMJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private HANACJOLAPF CAJJHPFKALI;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x347B790", Offset = "0x347A390", VA = "0x18347B790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B2B0", Offset = "0x2F19EB0", VA = "0x182F1B2B0")]
		public GAJEEOELMJD(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B1B0", Offset = "0x2F19DB0", VA = "0x182F1B1B0")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x347B6D0", Offset = "0x347A2D0", VA = "0x18347B6D0")]
		public GAJEEOELMJD EMHOENNLHOC()
		{
			return default(GAJEEOELMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct DDJOPJJJIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private HANACJOLAPF CAJJHPFKALI;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x2F1B130", Offset = "0x2F19D30", VA = "0x182F1B130")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B2B0", Offset = "0x2F19EB0", VA = "0x182F1B2B0")]
		public DDJOPJJJIED(global::OKBAHLBKAOF<Handle> BECLDAPDMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B1B0", Offset = "0x2F19DB0", VA = "0x182F1B1B0")]
		public bool PEKEHBIABGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B030", Offset = "0x2F19C30", VA = "0x182F1B030")]
		public DDJOPJJJIED EMHOENNLHOC()
		{
			return default(DDJOPJJJIED);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> INHIOKLHGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> FKDOLFPKFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int JLHJOLIFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int HJLKDMKALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool OCBDKMNEAFG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2758D10", Offset = "0x2757910", VA = "0x182758D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int CHAJMBNPIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int PHGCIEGENED
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GAJEEOELMJD GBIDMFHFNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x27597C0", Offset = "0x27583C0", VA = "0x1827597C0")]
		get
		{
			return default(GAJEEOELMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DDJOPJJJIED CPBGMPOEDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2759860", Offset = "0x2758460", VA = "0x182759860")]
		get
		{
			return default(DDJOPJJJIED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x275CDB0", Offset = "0x275B9B0", VA = "0x18275CDB0")]
	public OKBAHLBKAOF(int FLELPJPPFKB, Allocator PBEDBDBGIPF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x275C8B0", Offset = "0x275B4B0", VA = "0x18275C8B0")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CAF0", Offset = "0x1E1B6F0", VA = "0x181E1CAF0")]
	public static int FEMMPEMHNOB(int MINMGIMIPFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2758AF0", Offset = "0x27576F0", VA = "0x182758AF0")]
	public static bool BNMHFOJIFBI(int MINMGIMIPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2759210", Offset = "0x2757E10", VA = "0x182759210")]
	public static bool DBEHPAPBGEH(int MINMGIMIPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2758EB0", Offset = "0x2757AB0", VA = "0x182758EB0")]
	public bool CLAGDKKDHAG(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x275C550", Offset = "0x275B150", VA = "0x18275C550")]
	public bool MHKNPKKNMIH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2759BA0", Offset = "0x27587A0", VA = "0x182759BA0")]
	public bool INFANEMMJPA(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x275B870", Offset = "0x275A470", VA = "0x18275B870")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void KDLCLEODLOK(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x275BF80", Offset = "0x275AB80", VA = "0x18275BF80")]
	public Handle LMEPPNCNPIJ()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2759DC0", Offset = "0x27589C0", VA = "0x182759DC0")]
	public void JENIFGNKCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x27588F0", Offset = "0x27574F0", VA = "0x1827588F0")]
	public void ALDPJIEJDJP(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x275B060", Offset = "0x2759C60", VA = "0x18275B060")]
	public bool KALGAPNFMKB(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80")]
	private bool AIGKMNFLIJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x27587D0", Offset = "0x27573D0", VA = "0x1827587D0")]
	private bool AGFOJCNPBAP(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x275A9F0", Offset = "0x27595F0", VA = "0x18275A9F0")]
	private void JMGKABCCGBE(out int BNNEENLPEFO, out int OPAPEIICLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2759420", Offset = "0x2758020", VA = "0x182759420")]
	private void FFLGIIEIBPF(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2759770", Offset = "0x2758370", VA = "0x182759770")]
	private void FMDNLHFMONK(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x275CAD0", Offset = "0x275B6D0", VA = "0x18275CAD0")]
	private bool PNNPBFANFOO(out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2758B00", Offset = "0x2757700", VA = "0x182758B00")]
	private static Handle CDOLJNFCBPB(int BNNEENLPEFO, int OPAPEIICLLC)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct FIGNPHGKAHK<Handle, T> where Handle : MKBPDIMFNJC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::OKBAHLBKAOF<Handle> DPHBIPDBJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] NCPMIIEIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> FPOKHGDMJOI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2896E10", Offset = "0x2895A10", VA = "0x182896E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2896DD0", Offset = "0x28959D0", VA = "0x182896DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2896E40", Offset = "0x2895A40", VA = "0x182896E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2897960", Offset = "0x2896560", VA = "0x182897960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x28998C0", Offset = "0x28984C0", VA = "0x1828998C0")]
	public FIGNPHGKAHK(int FLELPJPPFKB, [Optional] Action<T> FPOKHGDMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x28993B0", Offset = "0x2897FB0", VA = "0x1828993B0")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2898810", Offset = "0x2897410", VA = "0x182898810")]
	public bool INFANEMMJPA(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void KDLCLEODLOK(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2898600", Offset = "0x2897200", VA = "0x182898600")]
	public T HMFHOBMDMGG(Handle DKBLPJPHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2898310", Offset = "0x2896F10", VA = "0x182898310")]
	public bool GIGGJMBFKKD(Handle DKBLPJPHEMF, out T KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2898FD0", Offset = "0x2897BD0", VA = "0x182898FD0")]
	public void NMFBOCJEJOB(Handle DKBLPJPHEMF, T EHMHICCFGJB, out T AHEJPDNJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x28991C0", Offset = "0x2897DC0", VA = "0x1828991C0")]
	public void NMFBOCJEJOB(Handle DKBLPJPHEMF, T EHMHICCFGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2898860", Offset = "0x2897460", VA = "0x182898860")]
	public bool JKMJNDCPNKA(Handle DKBLPJPHEMF, T EHMHICCFGJB, out T AHEJPDNJEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2898EF0", Offset = "0x2897AF0", VA = "0x182898EF0")]
	public bool JKMJNDCPNKA(Handle DKBLPJPHEMF, T EHMHICCFGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2897730", Offset = "0x2896330", VA = "0x182897730")]
	public Handle ELGBPIMHCCH(T KMFLGGMLFJA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x28980E0", Offset = "0x2896CE0", VA = "0x1828980E0")]
	public void GFIDMAHEEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2896F80", Offset = "0x2895B80", VA = "0x182896F80")]
	public void DOHHNJJEEIG(Handle DKBLPJPHEMF, out T AHEJPDNJEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2897050", Offset = "0x2895C50", VA = "0x182897050")]
	public void DOHHNJJEEIG(Handle DKBLPJPHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x28968B0", Offset = "0x28954B0", VA = "0x1828968B0")]
	public bool BMFJIOLJJLM(Handle DKBLPJPHEMF, out T AHEJPDNJEKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2896990", Offset = "0x2895590", VA = "0x182896990")]
	public bool BMFJIOLJJLM(Handle DKBLPJPHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x28986C0", Offset = "0x28972C0", VA = "0x1828986C0")]
	private T IFFLOFKJNLP(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x28995F0", Offset = "0x28981F0", VA = "0x1828995F0")]
	private void PHCHFJPBPOA(int ALPHMDODPNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class CDPICIPLBFE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> BECLDAPDMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> NIMLILLCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int HDOBBNLPABL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int JEEBGGHKPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x22814B0", Offset = "0x22800B0", VA = "0x1822814B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int FPGEFCKABAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2FACC90", Offset = "0x2FAB890", VA = "0x182FACC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3097670", Offset = "0x3096270", VA = "0x183097670")]
	public static global::CDPICIPLBFE<T> APMLAIJBDNB(int BPGPHKEJPBF = 0, int HDOBBNLPABL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3097D90", Offset = "0x3096990", VA = "0x183097D90")]
	public static global::CDPICIPLBFE<T> MHHFJAEKMEE(int BPGPHKEJPBF = 0, int HDOBBNLPABL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3097FF0", Offset = "0x3096BF0", VA = "0x183097FF0")]
	public CDPICIPLBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3097E60", Offset = "0x3096A60", VA = "0x183097E60")]
	public CDPICIPLBFE(int BPGPHKEJPBF, int HDOBBNLPABL = int.MaxValue, bool DDAPCHIGGBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3097C80", Offset = "0x3096880", VA = "0x183097C80")]
	public T KEJBKBEBENC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3097740", Offset = "0x3096340", VA = "0x183097740")]
	public void CGILPHFOCHO(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3097BB0", Offset = "0x30967B0", VA = "0x183097BB0")]
	private void KCCFADECGJJ(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3097B00", Offset = "0x3096700", VA = "0x183097B00")]
	private void ECIIMHKFHLI(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x30977F0", Offset = "0x30963F0", VA = "0x1830977F0")]
	[Conditional("DEBUG_BUILD")]
	private void CHGPNKBPNLF(T JDIEBGBFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3097B20", Offset = "0x3096720", VA = "0x183097B20")]
	[Conditional("DEBUG_BUILD")]
	private void JOPEBMAANIF(T JDIEBGBFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3097A10", Offset = "0x3096610", VA = "0x183097A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3097870", Offset = "0x3096470", VA = "0x183097870")]
	private void DCMNHFKNOGM(IEnumerable<T> BLHNHHMKNAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GFMKOPEAAJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T NPNPEFMILOC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KFFBHGPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3490410", Offset = "0x348F010", VA = "0x183490410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3490450", Offset = "0x348F050", VA = "0x183490450")]
	public bool KBFHBLDHILI(T GKFICKKHACC, int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3490320", Offset = "0x348EF20", VA = "0x183490320")]
	public bool GBACKLPKCJF(int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3490510", Offset = "0x348F110", VA = "0x183490510")]
	public T OHPPGJGLHII(int ODMDLJHJIEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x34903B0", Offset = "0x348EFB0", VA = "0x1834903B0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x3490180", Offset = "0x348ED80", VA = "0x183490180")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3490380", Offset = "0x348EF80", VA = "0x183490380")]
	public bool GINCMLLPDOD(int KFNPPICHBLJ, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3490900", Offset = "0x348F500", VA = "0x183490900")]
	public GFMKOPEAAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class HLDPKMBNLHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct OAAKFOHIOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int EGHNEAEEKBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<OAAKFOHIOFE> PAACEHPKNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T GIHJHGMKCAA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3310", Offset = "0x1FC1F10", VA = "0x181FC3310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB650", Offset = "0x2BBA250", VA = "0x182BBB650")]
	public bool KOOJGAMNGBI(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB320", Offset = "0x2BB9F20", VA = "0x182BBB320")]
	public void ELGBPIMHCCH(T GKFICKKHACC, int KFNPPICHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB200", Offset = "0x2BB9E00", VA = "0x182BBB200")]
	public bool DOHHNJJEEIG(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB430", Offset = "0x2BBA030", VA = "0x182BBB430")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB3C0", Offset = "0x2BB9FC0", VA = "0x182BBB3C0")]
	public T ENELLOKJHEM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB190", Offset = "0x2BB9D90", VA = "0x182BBB190")]
	public T DMODAANMPLG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB490", Offset = "0x2BBA090", VA = "0x182BBB490")]
	private void HHNGFNAFBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB860", Offset = "0x2BBA460", VA = "0x182BBB860")]
	public HLDPKMBNLHF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[CKCNFJDLOHN(ALDDFIJCEMJ.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5F54440", Offset = "0x5F53040", VA = "0x185F54440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5F547D0", Offset = "0x5F533D0", VA = "0x185F547D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5F54650", Offset = "0x5F53250", VA = "0x185F54650")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F54930", Offset = "0x5F53530", VA = "0x185F54930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F54360", Offset = "0x5F52F60", VA = "0x185F54360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5F546F0", Offset = "0x5F532F0", VA = "0x185F546F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5F54570", Offset = "0x5F53170", VA = "0x185F54570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F54310", Offset = "0x5F52F10", VA = "0x185F54310")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface AGLJDBGPKDB
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : AGLJDBGPKDB where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F3B2F0", Offset = "0x2F39EF0", VA = "0x182F3B2F0", Slot = "4")]
		public virtual T JOJAOALDBJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class JACGLMMOHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, JGFNKHMNKMP> FLEDBEDAPDP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JGFNKHMNKMP KOOAFCAJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 HGBLIKAMFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F3EF40", Offset = "0x1F3DB40", VA = "0x181F3EF40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CD0", Offset = "0x6BF8D0", VA = "0x1806C0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 KGIGPFNKIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1F610F0", Offset = "0x1F5FCF0", VA = "0x181F610F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x1A5FE90", Offset = "0x1A5EA90", VA = "0x181A5FE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 DLOOLBKDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F51470", Offset = "0x5F50070", VA = "0x185F51470")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D75170", Offset = "0x1D73D70", VA = "0x181D75170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int EBKFGAKJDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6770E0", Offset = "0x675CE0", VA = "0x1806770E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DE640", Offset = "0x6DD240", VA = "0x1806DE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F51A70", Offset = "0x5F50670", VA = "0x185F51A70")]
	public JACGLMMOHGH(Bounds DCCFOLANGLD, Vector2[] BGDPCEPNNII, int FNPFDNFFKPK, byte IOGAMBOBGAL, float IGJOFBAIEMC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F51490", Offset = "0x5F50090", VA = "0x185F51490")]
	public JGFNKHMNKMP GECDMJHBIDM(byte BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F51370", Offset = "0x5F4FF70", VA = "0x185F51370")]
	public void AHINOACJPJK(Vector3 DKGAADMNOOM, float BHHKNALNFCA, float PBMGFJJBJBF, ref List<byte> JEPPJNGKBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5F51A50", Offset = "0x5F50650", VA = "0x185F51A50")]
	public void OBPABGNEJPG(JGFNKHMNKMP.DJPLOIHNNIJ AMPFPJBJFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5F518F0", Offset = "0x5F504F0", VA = "0x185F518F0")]
	private JGFNKHMNKMP LFANGECEJGC(byte BNNEENLPEFO, JGFNKHMNKMP.NHCMKDJGCBI MIMKDMNPKAF, JGFNKHMNKMP GEOFAMNLJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F514F0", Offset = "0x5F500F0", VA = "0x185F514F0")]
	private void ICCAJJBBFHM(JGFNKHMNKMP GEOFAMNLJNK, Vector2[] BGDPCEPNNII, int HLBIBEOOLIF, int AGMNPKJPHNM, int NPONBKMMMGC, int EDGOHKKDCPA, float IGJOFBAIEMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class JGFNKHMNKMP
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum NHCMKDJGCBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum DJPLOIHNNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public byte KNHOMHPCCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 GDBDBLCPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 PEPLKIOHEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 CJEJLMCHEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 PNDIONKDMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NHCMKDJGCBI LFDKNDJGOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public JGFNKHMNKMP MJECJCHPAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<JGFNKHMNKMP> LEIDDLPHAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool LKNBGMABGMB;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F522D0", Offset = "0x5F50ED0", VA = "0x185F522D0")]
	public JGFNKHMNKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F522F0", Offset = "0x5F50EF0", VA = "0x185F522F0")]
	public JGFNKHMNKMP(byte GLGEGPNMJGF, NHCMKDJGCBI MIMKDMNPKAF, JGFNKHMNKMP GEOFAMNLJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F52180", Offset = "0x5F50D80", VA = "0x185F52180")]
	public void JDFBMCLFMDD(JGFNKHMNKMP DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public void OBPABGNEJPG(int HLMHGDMGFOJ, DJPLOIHNNIJ AMPFPJBJFDB, int LNDLJLEHLKC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F51ED0", Offset = "0x5F50AD0", VA = "0x185F51ED0")]
	public void AHINOACJPJK(List<byte> JEPPJNGKBEF, Vector3 DKGAADMNOOM, float BHHKNALNFCA, float PBMGFJJBJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F52280", Offset = "0x5F50E80", VA = "0x185F52280")]
	public bool MDILIEJNDDG(Vector3 DEDMBANHEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F52240", Offset = "0x5F50E40", VA = "0x185F52240")]
	public bool KFNMECIBEGB(Vector3 DEDMBANHEDJ, float EPCFDGHEGAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class NBMJBDIHEEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> KPCEMGJGILM;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x200AC20", Offset = "0x2009820", VA = "0x18200AC20")]
	public bool LNELCNECDOP(T MADNKELMDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2687CF0", Offset = "0x26868F0", VA = "0x182687CF0")]
	public bool LNELCNECDOP(T MADNKELMDPN, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2687D30", Offset = "0x2686930", VA = "0x182687D30")]
	public bool LNELCNECDOP(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2687BF0", Offset = "0x26867F0", VA = "0x182687BF0")]
	public bool EGFGPOINFCO(T MADNKELMDPN, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2687BB0", Offset = "0x26867B0", VA = "0x182687BB0")]
	public bool BMEDLPDOFIK(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2687C30", Offset = "0x2686830", VA = "0x182687C30")]
	public bool EGFGPOINFCO(T MADNKELMDPN, object JJFHDFJGCDG, out object MDMJMGPIBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2687CC0", Offset = "0x26868C0", VA = "0x182687CC0")]
	public void LDCJNFGHLJL(T MADNKELMDPN, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2687D90", Offset = "0x2686990", VA = "0x182687D90")]
	public void MFCMHPAGLPA(T MADNKELMDPN, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2687E30", Offset = "0x2686A30", VA = "0x182687E30")]
	public NBMJBDIHEEN()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct HMFLOEJNGMD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool KLPLMOPDDFM;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D7970", Offset = "0x8D6570", VA = "0x1808D7970")]
			public HMFLOEJNGMD(List<Component> LENGKEKMOEB, bool KLPLMOPDDFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE550", Offset = "0x2BBD150", VA = "0x182BBE550")]
			public NDEMIAICFID<T> EMHOENNLHOC()
			{
				return default(NDEMIAICFID<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5C0", Offset = "0x2BBD1C0", VA = "0x182BBE5C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE5C0", Offset = "0x2BBD1C0", VA = "0x182BBE5C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct NDEMIAICFID<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool KLPLMOPDDFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int BNNEENLPEFO;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T FPPIFCEMCLH
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x26896B0", Offset = "0x26882B0", VA = "0x1826896B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x2689640", Offset = "0x2688240", VA = "0x182689640", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2689680", Offset = "0x2688280", VA = "0x182689680")]
			public NDEMIAICFID(List<Component> LENGKEKMOEB, bool KLPLMOPDDFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2689570", Offset = "0x2688170", VA = "0x182689570", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2689580", Offset = "0x2688180", VA = "0x182689580", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2689630", Offset = "0x2688230", VA = "0x182689630", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x5F56680", Offset = "0x5F55280", VA = "0x185F56680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5F56640", Offset = "0x5F55240", VA = "0x185F56640")]
		public ToolHierarchyCache(GameObject HCKEHDIEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5F55FD0", Offset = "0x5F54BD0", VA = "0x185F55FD0")]
		private void FNJOFAEFPIL(GameObject HCKEHDIEAIK, bool JOGFOOOHGFG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5F55F40", Offset = "0x5F54B40", VA = "0x185F55F40")]
		public static void FNJOFAEFPIL(GameObject HCKEHDIEAIK, ref ToolHierarchyCache MJPGKNPOLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F56130", Offset = "0x5F54D30", VA = "0x185F56130")]
		public void GPEKBHCJHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5F56570", Offset = "0x5F55170", VA = "0x185F56570")]
		public void KMMNMEDFOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x4058240", Offset = "0x4056E40", VA = "0x184058240")]
		public void ABELFGODJOI<T>(Action<T> KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5F55DF0", Offset = "0x5F549F0", VA = "0x185F55DF0")]
		public Component BNEIEOPFJAC(Type BIEGICDMJCM, bool KLPLMOPDDFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x40584D0", Offset = "0x40570D0", VA = "0x1840584D0")]
		public T BNEIEOPFJAC<T>(bool KLPLMOPDDFM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F564F0", Offset = "0x5F550F0", VA = "0x185F564F0")]
		public HMFLOEJNGMD<Component> KMGDJNJLPDE(Type BIEGICDMJCM, bool KLPLMOPDDFM = false)
		{
			return default(HMFLOEJNGMD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x4058550", Offset = "0x4057150", VA = "0x184058550")]
		public HMFLOEJNGMD<T> KMGDJNJLPDE<T>(bool KLPLMOPDDFM = false) where T : class
		{
			return default(HMFLOEJNGMD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F561C0", Offset = "0x5F54DC0", VA = "0x185F561C0")]
		public List<Component> HHOFMFMGOHB(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F55EC0", Offset = "0x5F54AC0", VA = "0x185F55EC0", Slot = "4")]
		public bool Equals(ToolHierarchyCache IODEOJKDCNL, ToolHierarchyCache FNMMGECGLAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F56140", Offset = "0x5F54D40", VA = "0x185F56140", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KMFLGGMLFJA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class BCHIBBAKHAD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int BPGPHKEJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int OKGNJAMMHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> CKIGFGIEPDP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x22814B0", Offset = "0x22800B0", VA = "0x1822814B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T BIAGFGAGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x286EC30", Offset = "0x286D830", VA = "0x18286EC30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T OIKFEMOBNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x286EAC0", Offset = "0x286D6C0", VA = "0x18286EAC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T GDKMPKAOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x286EF60", Offset = "0x286DB60", VA = "0x18286EF60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x286F010", Offset = "0x286DC10", VA = "0x18286F010")]
	public BCHIBBAKHAD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x286ED90", Offset = "0x286D990", VA = "0x18286ED90")]
	public void ELGBPIMHCCH(T PNKHOKKGIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x286EE70", Offset = "0x286DA70", VA = "0x18286EE70")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x286EEC0", Offset = "0x286DAC0", VA = "0x18286EEC0")]
	public void KLOGDENDLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x286EB60", Offset = "0x286D760", VA = "0x18286EB60")]
	public void AEKICGFADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x286EEB0", Offset = "0x286DAB0", VA = "0x18286EEB0")]
	public void IGIGGBPOLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class NOAIEIOEOML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool OGEFKLPIOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action KDJGJCHCIKK;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static NOAIEIOEOML NKPGLBOKJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F53960", Offset = "0x5F52560", VA = "0x185F53960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LBEMKJJMHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679E50", VA = "0x18067B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82C810", Offset = "0x82B410", VA = "0x18082C810")]
	public NOAIEIOEOML(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5F53940", Offset = "0x5F52540", VA = "0x185F53940")]
	public void DNAKJMIBDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5F53940", Offset = "0x5F52540", VA = "0x185F53940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class DPMKPHIADEM
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D5A0", Offset = "0x5F4C1A0", VA = "0x185F4D5A0")]
	public static void KFGBHPFBMEK(IKNDPBBFNFG CNKPBJAPJCK, string GGBECJHHNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	public static void KFGBHPFBMEK(IEnumerable<object> MPPBBBHMGNE, string GGBECJHHNEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BNCNMNBCFPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct IPPKLMFLGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int EGHNEAEEKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T AMPEKKPGHLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, IPPKLMFLGDE> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> MOKACFGFHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T NPNPEFMILOC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KFFBHGPIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xCD1120", Offset = "0xCCFD20", VA = "0x180CD1120", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x23D3210", Offset = "0x23D1E10", VA = "0x1823D3210", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x23D3290", Offset = "0x23D1E90", VA = "0x1823D3290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object AOLAIDPNCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x23D36C0", Offset = "0x23D22C0", VA = "0x1823D36C0")]
	public bool KBFHBLDHILI(T GKFICKKHACC, object JJFHDFJGCDG, int KFNPPICHBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x23D2B70", Offset = "0x23D1770", VA = "0x1823D2B70")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x23D2F30", Offset = "0x23D1B30", VA = "0x1823D2F30")]
	public bool GINCMLLPDOD(object JJFHDFJGCDG, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x180C580", Offset = "0x180B180", VA = "0x18180C580")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x23CFC10", Offset = "0x23CE810", VA = "0x1823CFC10")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x23D3B30", Offset = "0x23D2730", VA = "0x1823D3B30")]
	public BNCNMNBCFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class BBCILEFDEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> AJHGDECFBDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float POLBONMDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x11A6200", Offset = "0x11A4E00", VA = "0x1811A6200")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xF02340", Offset = "0xF00F40", VA = "0x180F02340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CC90", Offset = "0x5F4B890", VA = "0x185F4CC90")]
	public void KBFHBLDHILI(float GKFICKKHACC, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CC20", Offset = "0x5F4B820", VA = "0x185F4CC20")]
	public void GBACKLPKCJF(object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CB00", Offset = "0x5F4B700", VA = "0x185F4CB00")]
	private void ECAENPNAFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5F4CD00", Offset = "0x5F4B900", VA = "0x185F4CD00")]
	public BBCILEFDEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class GHFMFMDNJJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string NKLJPCMLPBB;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	public GHFMFMDNJJE(string GMMJLPGEKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ED30", Offset = "0x5F4D930", VA = "0x185F4ED30")]
	public GHFMFMDNJJE(UnityEngine.Object NNPKBOLAHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5F4ECE0", Offset = "0x5F4D8E0", VA = "0x185F4ECE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IKNDPBBFNFG
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class FODEKPBKMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public FODEKPBKMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5F4EBF0", Offset = "0x5F4D7F0", VA = "0x185F4EBF0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> MPPBBBHMGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int ECPGKBHIMEB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> IGNFIMPCACH
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5F50F10", Offset = "0x5F4FB10", VA = "0x185F50F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool NEPGOCILDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F51140", Offset = "0x5F4FD40", VA = "0x185F51140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5F50FE0", Offset = "0x5F4FBE0", VA = "0x185F50FE0")]
	public bool ELGBPIMHCCH(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5F50E70", Offset = "0x5F4FA70", VA = "0x185F50E70")]
	public bool DOHHNJJEEIG(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5F51150", Offset = "0x5F4FD50", VA = "0x185F51150")]
	public bool KOOJGAMNGBI(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5F510D0", Offset = "0x5F4FCD0", VA = "0x185F510D0")]
	public void FBPAFOLJDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5F511B0", Offset = "0x5F4FDB0", VA = "0x185F511B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IKNDPBBFNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class EAKOBEGKCJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct DHCCMCMANPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float FCLPAKFBGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T AMPEKKPGHLN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, DHCCMCMANPN> AJHGDECFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T NOPJMGEANPN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T PCCKJHEFJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x166B1A0", Offset = "0x1669DA0", VA = "0x18166B1A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x166A940", Offset = "0x1669540", VA = "0x18166A940", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object ENBICPKHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool EECCOPMALHC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3411210", Offset = "0x340FE10", VA = "0x183411210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3411530", Offset = "0x3410130", VA = "0x183411530")]
	public bool KBFHBLDHILI(T GKFICKKHACC, object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3410F40", Offset = "0x340FB40", VA = "0x183410F40")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x180C580", Offset = "0x180B180", VA = "0x18180C580")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x34110D0", Offset = "0x340FCD0", VA = "0x1834110D0")]
	public bool GINCMLLPDOD(object JJFHDFJGCDG, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x340FF90", Offset = "0x340EB90", VA = "0x18340FF90")]
	private bool BLHFPJABNLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3411820", Offset = "0x3410420", VA = "0x183411820")]
	public EAKOBEGKCJB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5F52AC0", Offset = "0x5F516C0", VA = "0x185F52AC0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5F52BD0", Offset = "0x5F517D0", VA = "0x185F52BD0")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
