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
public class FGOBHLBDKAN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	public FGOBHLBDKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, PHCEFBJKCFG, PPFHFHJJFGO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash GKJFFLLHHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01C80", VA = "0x180F02880")]
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
	[MGLMIFDCHNF]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[MGLMIFDCHNF]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED85A0", Offset = "0x5ED79A0", VA = "0x185ED85A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8560", Offset = "0x5ED7960", VA = "0x185ED8560")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED85E0", Offset = "0x5ED79E0", VA = "0x185ED85E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED87B0", Offset = "0x5ED7BB0", VA = "0x185ED87B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8720", Offset = "0x5ED7B20", VA = "0x185ED8720")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x116A3A0", Offset = "0x11697A0", VA = "0x18116A3A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10F7D10", Offset = "0x10F7110", VA = "0x1810F7D10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8520", Offset = "0x5ED7920", VA = "0x185ED8520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8690", Offset = "0x5ED7A90", VA = "0x185ED8690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8020", Offset = "0x5ED7420", VA = "0x185ED8020")]
	public void CopyBounds(SavedExtents BKBGGIICJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8480", Offset = "0x5ED7880", VA = "0x185ED8480")]
	public void SetLocalSpaceBounds(Bounds HJMOFKMEPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x12075A0", Offset = "0x12069A0", VA = "0x1812075A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8280", Offset = "0x5ED7680", VA = "0x185ED8280")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8290", Offset = "0x5ED7690", VA = "0x185ED8290")]
	private void PJLFBGKJECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ED8050", Offset = "0x5ED7450", VA = "0x185ED8050")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED79E0", Offset = "0x5ED6DE0", VA = "0x185ED79E0")]
	public static void CalculateLocalBoundsFor(GameObject MGDBDEJKIMA, out Bounds HJMOFKMEPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7920", Offset = "0x5ED6D20", VA = "0x185ED7920")]
	private static void CBBGIAAHKGK(Bounds ABBMKKCGFBG, Color CMLILENOEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED84A0", Offset = "0x5ED78A0", VA = "0x185ED84A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68DF30", Offset = "0x68D330", VA = "0x18068DF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x109D960", Offset = "0x109CD60", VA = "0x18109D960")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAFFD30", Offset = "0xAFF130", VA = "0x180AFFD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public virtual void FNGLLNCICKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
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
	[FGOBHLBDKAN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3456880", Offset = "0x3455C80", VA = "0x183456880", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3455FB0", Offset = "0x34553B0", VA = "0x183455FB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3456DC0", Offset = "0x34561C0", VA = "0x183456DC0")]
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
	private sealed class ECAHOMDEEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public ECAHOMDEEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28B84A0", Offset = "0x28B78A0", VA = "0x1828B84A0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[FGOBHLBDKAN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1129080", Offset = "0x1128480", VA = "0x181129080", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x11290B0", Offset = "0x11284B0", VA = "0x1811290B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1128FD0", Offset = "0x11283D0", VA = "0x181128FD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey MPIADBGKNBD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1129030", Offset = "0x1128430", VA = "0x181129030", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1128ED0", Offset = "0x11282D0", VA = "0x181128ED0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1128990", Offset = "0x1127D90", VA = "0x181128990", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x11281B0", Offset = "0x11275B0", VA = "0x1811281B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1128D60", Offset = "0x1128160", VA = "0x181128D60", Slot = "14")]
	protected virtual string PJIONFAKFKJ(TKeyVal POGGJIEPAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1127DD0", Offset = "0x11271D0", VA = "0x181127DD0", Slot = "4")]
	public bool ContainsKey(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1128DC0", Offset = "0x11281C0", VA = "0x181128DC0", Slot = "5")]
	public bool TryGetValue(TKey MPIADBGKNBD, out TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1127E00", Offset = "0x1127200", VA = "0x181127E00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1127E00", Offset = "0x1127200", VA = "0x181127E00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1128DF0", Offset = "0x11281F0", VA = "0x181128DF0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CLIFIOBHBNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NEFNLNLJLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public NEFNLNLJLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CC10", Offset = "0x2D4C010", VA = "0x182D4CC10")]
		internal bool <GetSamples>b__0(global::GIIIFALNEPI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float HMPADAICOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BGDKAHOFABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::GIIIFALNEPI<float, T>> CHKOHJKACAE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int PJDCDEDJNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27659C0", Offset = "0x2764DC0", VA = "0x1827659C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2765D80", Offset = "0x2765180", VA = "0x182765D80")]
	public CLIFIOBHBNK(float LMLMJAPALLI, float FJHEBKGKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2765C20", Offset = "0x2765020", VA = "0x182765C20")]
	public bool OAHBKEGBEIP(float GLMKPPDOKMC, T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2765220", Offset = "0x2764620", VA = "0x182765220")]
	public int IEICKBGMPEC(float GLMKPPDOKMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2765340", Offset = "0x2764740", VA = "0x182765340")]
	public IEnumerable<T> NIKPLLOIPNF(float GLMKPPDOKMC, [Optional] float? FAAHAABGGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27651F0", Offset = "0x27645F0", VA = "0x1827651F0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2765280", Offset = "0x2764680", VA = "0x182765280")]
	private void LBBLBHBMJFH(float GLMKPPDOKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MJDFJNPMDDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CNMOPKDEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ECFALLCDCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FHDIANDBDGO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NDJBFAIHFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> BOANFHGCEPF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int KCOBFKNOGJO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CNMOPKDEHAJ[] CCKHAOABLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int DCAEEENJKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float FBKGDGLALJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEC19C0", Offset = "0xEC0DC0", VA = "0x180EC19C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEC19D0", Offset = "0xEC0DD0", VA = "0x180EC19D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x231C130", Offset = "0x231B530", VA = "0x18231C130")]
	public MJDFJNPMDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x231C050", Offset = "0x231B450", VA = "0x18231C050")]
	public MJDFJNPMDDD(int FOADGJOOFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x231B750", Offset = "0x231AB50", VA = "0x18231B750")]
	public void EIPAABBBFMM(float GLMKPPDOKMC, T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x231BBA0", Offset = "0x231AFA0", VA = "0x18231BBA0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x231B240", Offset = "0x231A640", VA = "0x18231B240")]
	public bool DLAFEJLENON(float JPHLHMKHHAI, float DHMCJGJOIDI, out T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x231AEB0", Offset = "0x231A2B0", VA = "0x18231AEB0")]
	public bool CFOGHECDOME(float JPHLHMKHHAI, float DHMCJGJOIDI, out T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x231B830", Offset = "0x231AC30", VA = "0x18231B830")]
	public void EMLLJGHPOED(float JPHLHMKHHAI, float DHMCJGJOIDI, List<T> BPMIJGKONLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x231BF90", Offset = "0x231B390", VA = "0x18231BF90")]
	private int KGDPCMIPEIP(int OAHOFFDDDFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x231BFC0", Offset = "0x231B3C0", VA = "0x18231BFC0")]
	private void KLGDFGPHDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BIAIIGCABEN();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PIGBBLCOGNK(T EIPBHONBEOF, T KHDOHMLGMCL, float PMFPAMNENCI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HKFOPEENMND(T PKODKJLGOIN, float PMFPAMNENCI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EHENHDBJOLI(T EIPBHONBEOF, T KHDOHMLGMCL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JJFAHIBOJMI(T EIPBHONBEOF, T KHDOHMLGMCL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PDKFJECKHMK : global::MJDFJNPMDDD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x113CD70", Offset = "0x113C170", VA = "0x18113CD70", Slot = "4")]
	protected override Vector3 BIAIIGCABEN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x174A840", Offset = "0x1749C40", VA = "0x18174A840", Slot = "5")]
	protected override Vector3 PIGBBLCOGNK(Vector3 EIPBHONBEOF, Vector3 KHDOHMLGMCL, float PMFPAMNENCI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED70B0", Offset = "0x5ED64B0", VA = "0x185ED70B0", Slot = "6")]
	protected override Vector3 HKFOPEENMND(Vector3 PKODKJLGOIN, float PMFPAMNENCI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7030", Offset = "0x5ED6430", VA = "0x185ED7030", Slot = "7")]
	protected override Vector3 EHENHDBJOLI(Vector3 EIPBHONBEOF, Vector3 KHDOHMLGMCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7110", Offset = "0x5ED6510", VA = "0x185ED7110", Slot = "8")]
	protected override Vector3 JJFAHIBOJMI(Vector3 EIPBHONBEOF, Vector3 KHDOHMLGMCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED7180", Offset = "0x5ED6580", VA = "0x185ED7180")]
	public PDKFJECKHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CECEEJENABH : global::MJDFJNPMDDD<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0AD0", Offset = "0x5ECFED0", VA = "0x185ED0AD0")]
	public CECEEJENABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0B40", Offset = "0x5ECFF40", VA = "0x185ED0B40")]
	public CECEEJENABH(int FOADGJOOFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "4")]
	protected override float BIAIIGCABEN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37FA0A0", Offset = "0x37F94A0", VA = "0x1837FA0A0", Slot = "5")]
	protected override float PIGBBLCOGNK(float EIPBHONBEOF, float KHDOHMLGMCL, float PMFPAMNENCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D040", Offset = "0x4F2C440", VA = "0x184F2D040", Slot = "6")]
	protected override float HKFOPEENMND(float PKODKJLGOIN, float PMFPAMNENCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x213E210", Offset = "0x213D610", VA = "0x18213E210", Slot = "7")]
	protected override float EHENHDBJOLI(float EIPBHONBEOF, float KHDOHMLGMCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0AC0", Offset = "0x5ECFEC0", VA = "0x185ED0AC0", Slot = "8")]
	protected override float JJFAHIBOJMI(float EIPBHONBEOF, float KHDOHMLGMCL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DCBLFMKKIHN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x23B87E0", Offset = "0x23B7BE0", VA = "0x1823B87E0")]
	public static global::KDCNJKFMIOG<T1> GEGOECOOINK<T1>(T1 HBKBEKDPALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x23C3BD0", Offset = "0x23C2FD0", VA = "0x1823C3BD0")]
	public static global::GIIIFALNEPI<T1, T2> GEGOECOOINK<T1, T2>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x23C3C40", Offset = "0x23C3040", VA = "0x1823C3C40")]
	public static global::OGLLHJPGLCL<T1, T2, T3> GEGOECOOINK<T1, T2, T3>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21F43A0", Offset = "0x21F37A0", VA = "0x1821F43A0")]
	public static global::CGLKFHFPLKO<T1, T2, T3, T4> GEGOECOOINK<T1, T2, T3, T4>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23C3F10", Offset = "0x23C3310", VA = "0x1823C3F10")]
	public static global::HKNBPILIOMA<T1, T2, T3, T4, T5> GEGOECOOINK<T1, T2, T3, T4, T5>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x23C3E60", Offset = "0x23C3260", VA = "0x1823C3E60")]
	public static global::GBKMGCNGPDI<T1, T2, T3, T4, T5, T6> GEGOECOOINK<T1, T2, T3, T4, T5, T6>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x23C3DA0", Offset = "0x23C31A0", VA = "0x1823C3DA0")]
	public static global::GODPLKJIDDF<T1, T2, T3, T4, T5, T6, T7> GEGOECOOINK<T1, T2, T3, T4, T5, T6, T7>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD, T7 OCMHJOACDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x23C3CD0", Offset = "0x23C30D0", VA = "0x1823C3CD0")]
	public static global::KCOEPMMPNHP<T1, T2, T3, T4, T5, T6, T7, T8> GEGOECOOINK<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD, T7 OCMHJOACDHH, T8 FBEPOLHCAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1C270B0", Offset = "0x1C264B0", VA = "0x181C270B0")]
	[IteratorStateMachine(typeof(LIBIFHFNOHJ))]
	public static IEnumerable<global::GIIIFALNEPI<T1, T2>> JLEIOMLIBOM<T1, T2>(IEnumerable<T1> ANJGLCCJFPO, IEnumerable<T2> ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1C27290", Offset = "0x1C26690", VA = "0x181C27290")]
	[IteratorStateMachine(typeof(OIJJFGCDGMA))]
	public static IEnumerable<global::OGLLHJPGLCL<T1, T2, T3>> JLEIOMLIBOM<T1, T2, T3>(IEnumerable<T1> ANJGLCCJFPO, IEnumerable<T2> ABBMKKCGFBG, IEnumerable<T3> CMLILENOEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x843040", Offset = "0x842440", VA = "0x180843040")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x843030", Offset = "0x842430", VA = "0x180843030")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x843010", Offset = "0x842410", VA = "0x180843010")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF, int OGAJHHNJLKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1320", Offset = "0x5ED0720", VA = "0x185ED1320")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF, int OGAJHHNJLKF, int AOLCGHCANOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5ED12A0", Offset = "0x5ED06A0", VA = "0x185ED12A0")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF, int OGAJHHNJLKF, int AOLCGHCANOL, int LGBPNEHBMOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5ED12C0", Offset = "0x5ED06C0", VA = "0x185ED12C0")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF, int OGAJHHNJLKF, int AOLCGHCANOL, int LGBPNEHBMOF, int IPDHHAOPCOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5ED12F0", Offset = "0x5ED06F0", VA = "0x185ED12F0")]
	internal static int EDNAKLNHPCH(int HMFGNLIDONG, int CPBABGJCJPE, int MFKEHHCMDPF, int OGAJHHNJLKF, int AOLCGHCANOL, int LGBPNEHBMOF, int IPDHHAOPCOE, int MMAAOBMCGKO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KDCNJKFMIOG<T1> : IComparable<global::KDCNJKFMIOG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2180DB0", Offset = "0x21801B0", VA = "0x182180DB0")]
	public KDCNJKFMIOG(T1 HBKBEKDPALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42DF6B0", Offset = "0x42DEAB0", VA = "0x1842DF6B0", Slot = "4")]
	public int CompareTo(global::KDCNJKFMIOG<T1> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x42DF720", Offset = "0x42DEB20", VA = "0x1842DF720", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x94BD80", Offset = "0x94B180", VA = "0x18094BD80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42DF7C0", Offset = "0x42DEBC0", VA = "0x1842DF7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GIIIFALNEPI<T1, T2> : IComparable<global::GIIIFALNEPI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27AB2A0", Offset = "0x27AA6A0", VA = "0x1827AB2A0")]
	public GIIIFALNEPI(T1 HBKBEKDPALI, T2 PNLCFOOMMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27A92B0", Offset = "0x27A86B0", VA = "0x1827A92B0", Slot = "4")]
	public int CompareTo(global::GIIIFALNEPI<T1, T2> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27A9B00", Offset = "0x27A8F00", VA = "0x1827A9B00", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x27AA350", Offset = "0x27A9750", VA = "0x1827AA350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27AA790", Offset = "0x27A9B90", VA = "0x1827AA790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OGLLHJPGLCL<T1, T2, T3> : IComparable<global::OGLLHJPGLCL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28D6BA0", Offset = "0x28D5FA0", VA = "0x1828D6BA0")]
	public OGLLHJPGLCL(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28D6490", Offset = "0x28D5890", VA = "0x1828D6490", Slot = "4")]
	public int CompareTo(global::OGLLHJPGLCL<T1, T2, T3> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28D6590", Offset = "0x28D5990", VA = "0x1828D6590", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28D6880", Offset = "0x28D5C80", VA = "0x1828D6880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28D68E0", Offset = "0x28D5CE0", VA = "0x1828D68E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CGLKFHFPLKO<T1, T2, T3, T4> : IComparable<global::CGLKFHFPLKO<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 MFMLBOOEEMA;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC9A0", Offset = "0x1ECBDA0", VA = "0x181ECC9A0")]
	public CGLKFHFPLKO(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x275EEF0", Offset = "0x275E2F0", VA = "0x18275EEF0", Slot = "4")]
	public int CompareTo(global::CGLKFHFPLKO<T1, T2, T3, T4> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x275F030", Offset = "0x275E430", VA = "0x18275F030", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x275F150", Offset = "0x275E550", VA = "0x18275F150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x275F210", Offset = "0x275E610", VA = "0x18275F210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HKNBPILIOMA<T1, T2, T3, T4, T5> : IComparable<global::HKNBPILIOMA<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 MFMLBOOEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 JAHLNAIKNOA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x275F780", Offset = "0x275EB80", VA = "0x18275F780")]
	public HKNBPILIOMA(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38E2220", Offset = "0x38E1620", VA = "0x1838E2220", Slot = "4")]
	public int CompareTo(global::HKNBPILIOMA<T1, T2, T3, T4, T5> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x38E23A0", Offset = "0x38E17A0", VA = "0x1838E23A0", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38E24E0", Offset = "0x38E18E0", VA = "0x1838E24E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38E25E0", Offset = "0x38E19E0", VA = "0x1838E25E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GBKMGCNGPDI<T1, T2, T3, T4, T5, T6> : IComparable<global::GBKMGCNGPDI<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 MFMLBOOEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 JAHLNAIKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 APIPKOGKJHP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x323E800", Offset = "0x323DC00", VA = "0x18323E800")]
	public GBKMGCNGPDI(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x323E240", Offset = "0x323D640", VA = "0x18323E240", Slot = "4")]
	public int CompareTo(global::GBKMGCNGPDI<T1, T2, T3, T4, T5, T6> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x323E400", Offset = "0x323D800", VA = "0x18323E400", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x323E570", Offset = "0x323D970", VA = "0x18323E570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x323E690", Offset = "0x323DA90", VA = "0x18323E690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GODPLKJIDDF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::GODPLKJIDDF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 MFMLBOOEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 JAHLNAIKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 APIPKOGKJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 EMPDLDEBJOD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A220", Offset = "0x3C09620", VA = "0x183C0A220")]
	public GODPLKJIDDF(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD, T7 OCMHJOACDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C09BA0", Offset = "0x3C08FA0", VA = "0x183C09BA0", Slot = "4")]
	public int CompareTo(global::GODPLKJIDDF<T1, T2, T3, T4, T5, T6, T7> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C09DA0", Offset = "0x3C091A0", VA = "0x183C09DA0", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C09F40", Offset = "0x3C09340", VA = "0x183C09F40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C0A090", Offset = "0x3C09490", VA = "0x183C0A090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KCOEPMMPNHP<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::KCOEPMMPNHP<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 GMNNNPCGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 GCNEICOPIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 DGPDFCAAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 MFMLBOOEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 JAHLNAIKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 APIPKOGKJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 EMPDLDEBJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 DIGLICPIHCO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42DD1F0", Offset = "0x42DC5F0", VA = "0x1842DD1F0")]
	public KCOEPMMPNHP(T1 HBKBEKDPALI, T2 PNLCFOOMMEG, T3 CEHILFMHDCF, T4 CNKBNHGOBHD, T5 NJPMKDJABBB, T6 NFLFOCNFEHD, T7 OCMHJOACDHH, T8 FBEPOLHCAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42DCAC0", Offset = "0x42DBEC0", VA = "0x1842DCAC0", Slot = "4")]
	public int CompareTo(global::KCOEPMMPNHP<T1, T2, T3, T4, T5, T6, T7, T8> BKBGGIICJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42DCD10", Offset = "0x42DC110", VA = "0x1842DCD10", Slot = "0")]
	public override bool Equals(object BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42DCED0", Offset = "0x42DC2D0", VA = "0x1842DCED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42DD040", Offset = "0x42DC440", VA = "0x1842DD040", Slot = "3")]
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
	public T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x19942F0", Offset = "0x19936F0", VA = "0x1819942F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E49B50", Offset = "0x3E48F50", VA = "0x183E49B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float MGFKNAFGKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1048310", Offset = "0x1047710", VA = "0x181048310")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E49770", Offset = "0x3E48B70", VA = "0x183E49770")]
	public T EELAGAGFDKF(float PMFPAMNENCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E499C0", Offset = "0x3E48DC0", VA = "0x183E499C0")]
	public T HDHPNEAJBMA(float PMFPAMNENCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PIGBBLCOGNK(T EIPBHONBEOF, T KHDOHMLGMCL, float PMFPAMNENCI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37FA0A0", Offset = "0x37F94A0", VA = "0x1837FA0A0", Slot = "4")]
	protected override float PIGBBLCOGNK(float EIPBHONBEOF, float KHDOHMLGMCL, float PMFPAMNENCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2BA0", Offset = "0x5ED1FA0", VA = "0x185ED2BA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x174A840", Offset = "0x1749C40", VA = "0x18174A840", Slot = "4")]
	protected override Vector3 PIGBBLCOGNK(Vector3 EIPBHONBEOF, Vector3 KHDOHMLGMCL, float PMFPAMNENCI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9740", Offset = "0x5ED8B40", VA = "0x185ED9740")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1210", Offset = "0x5ED0610", VA = "0x185ED1210", Slot = "4")]
	protected override Color PIGBBLCOGNK(Color EIPBHONBEOF, Color KHDOHMLGMCL, float PMFPAMNENCI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1260", Offset = "0x5ED0660", VA = "0x185ED1260")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JNPMMBJDAPC : global::MABIIAEMKAG<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5630", Offset = "0x5ED4A30", VA = "0x185ED5630")]
	public JNPMMBJDAPC(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5680", Offset = "0x5ED4A80", VA = "0x185ED5680")]
	public JNPMMBJDAPC(DFAKJHHJBDC[] GIADFAEDDFF, bool IBJNOIALHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED55C0", Offset = "0x5ED49C0", VA = "0x185ED55C0", Slot = "6")]
	protected override uint EPMJLGCCDOI(uint GKJFFLLHHJJ, string PKODKJLGOIN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PAMNJPGMBGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable PNBICMAKACI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PAMNJPGMBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CHKDKMLMOKM
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BICMACLMNPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<KMBCDIKKHFF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BICMACLMNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0080", Offset = "0x5ECF480", VA = "0x185ED0080")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<KMBCDIKKHFF>> MFFICKPIGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HFCIAFOGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int NLGMDBEICLK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCE2360", Offset = "0xCE1760", VA = "0x180CE2360")]
	private CHKDKMLMOKM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<KMBCDIKKHFF>> AAFNALDKDHC, int INCENHCPFLC, int LADEHDCBEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0BB0", Offset = "0x5ECFFB0", VA = "0x185ED0BB0")]
	public static CHKDKMLMOKM AJMCJLMMDDK()
	{
		return default(CHKDKMLMOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0C30", Offset = "0x5ED0030", VA = "0x185ED0C30")]
	public (int, int, Task) ELABEMKFILB(int KOLHFJMEBIH, [Optional] CancellationToken BJBDGBAHFDE)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1020", Offset = "0x5ED0420", VA = "0x185ED1020")]
	public void NCPLDLKEAHD(int KOLHFJMEBIH, int LADEHDCBEKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class OJAACGOOBAP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> MKLDCPHMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> NFHFKAAOKBP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JIGODMPOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28DB2D0", Offset = "0x28DA6D0", VA = "0x1828DB2D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> IJFFLJLOEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1410320", Offset = "0x140F720", VA = "0x181410320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x27B11D0", Offset = "0x27B05D0", VA = "0x1827B11D0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28DB300", Offset = "0x28DA700", VA = "0x1828DB300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28DA5B0", Offset = "0x28D99B0", VA = "0x1828DA5B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28DAFE0", Offset = "0x28DA3E0", VA = "0x1828DAFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28DA5E0", Offset = "0x28D99E0", VA = "0x1828DA5E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28DB150", Offset = "0x28DA550", VA = "0x1828DB150", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x231C8B0", Offset = "0x231BCB0", VA = "0x18231C8B0", Slot = "9")]
	public void Add(TKey MPIADBGKNBD, TVal PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28DA550", Offset = "0x28D9950", VA = "0x1828DA550", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28DA640", Offset = "0x28D9A40", VA = "0x1828DA640", Slot = "8")]
	public bool ContainsKey(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28DA6A0", Offset = "0x28D9AA0", VA = "0x1828DA6A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x28DB120", Offset = "0x28DA520", VA = "0x1828DB120", Slot = "10")]
	public bool Remove(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x28DB120", Offset = "0x28DA520", VA = "0x1828DB120", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2766370", Offset = "0x2765770", VA = "0x182766370", Slot = "11")]
	public bool TryGetValue(TKey MPIADBGKNBD, out TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x28DAB80", Offset = "0x28D9F80", VA = "0x1828DAB80", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28DA6D0", Offset = "0x28D9AD0", VA = "0x1828DA6D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28DA7E0", Offset = "0x28D9BE0", VA = "0x1828DA7E0")]
	public void EIPAABBBFMM(TVal IACKENKPPHN, TKey MPIADBGKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28DA730", Offset = "0x28D9B30", VA = "0x1828DA730")]
	public void EIPAABBBFMM(KeyValuePair<TVal, TKey> MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x28DAEA0", Offset = "0x28DA2A0", VA = "0x1828DAEA0")]
	public bool KMDCFNOHDOO(TVal MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28DB0C0", Offset = "0x28DA4C0", VA = "0x1828DB0C0")]
	public bool OOGLABKJNAC(KeyValuePair<TVal, TKey> MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28DAB20", Offset = "0x28D9F20", VA = "0x1828DAB20")]
	public bool GMLJNDAKNDK(TVal MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28DAB20", Offset = "0x28D9F20", VA = "0x1828DAB20")]
	public bool GMLJNDAKNDK(KeyValuePair<TVal, TKey> MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28DB060", Offset = "0x28DA460", VA = "0x1828DB060")]
	public bool MLNCJCFKCNK(TVal MPIADBGKNBD, out TKey PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28DAE20", Offset = "0x28DA220", VA = "0x1828DAE20")]
	public IEnumerator<KeyValuePair<TVal, TKey>> KLJCOKFNIPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x28DAC80", Offset = "0x28DA080", VA = "0x1828DAC80")]
	private void JPPHOFOBPOP(TKey MPIADBGKNBD, TVal IACKENKPPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x28DAF60", Offset = "0x28DA360", VA = "0x1828DAF60")]
	private void LGKLBHMALHA(TKey MPIADBGKNBD, TVal IACKENKPPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28DA9A0", Offset = "0x28D9DA0", VA = "0x1828DA9A0")]
	private bool EOGFIOIPDJL(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28DAA60", Offset = "0x28D9E60", VA = "0x1828DAA60")]
	private bool EOGFIOIPDJL(TVal IACKENKPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28DB1F0", Offset = "0x28DA5F0", VA = "0x1828DB1F0")]
	public OJAACGOOBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class HGLIMFIDHNM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::HGLIMFIDHNM<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7EE0", Offset = "0x2DD72E0", VA = "0x182DD7EE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB4B0", Offset = "0x2DDA8B0", VA = "0x182DDB4B0")]
		public Enumerator(global::HGLIMFIDHNM<T> BPMIJGKONLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3670", Offset = "0x2DD2A70", VA = "0x182DD3670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6A60", Offset = "0x2DD5E60", VA = "0x182DD6A60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6540", Offset = "0x2DD5940", VA = "0x182DD6540")]
		private void OCNOKCMPDEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] BJLNKAOCJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int CBFHONBGCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int CGIFLKCPGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int CELCPLLAAGH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CCA0", Offset = "0x2D9C0A0", VA = "0x182D9CCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C830", Offset = "0x2D9BC30", VA = "0x182D9C830")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D1A0", Offset = "0x2D9C5A0", VA = "0x182D9D1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E6E0", Offset = "0x2D9DAE0", VA = "0x182D9E6E0")]
	public HGLIMFIDHNM(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C9B0", Offset = "0x2D9BDB0", VA = "0x182D9C9B0")]
	public void EIPAABBBFMM(T PMFPAMNENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D710", Offset = "0x2D9CB10", VA = "0x182D9D710")]
	public void MNIBHCAMCCO(IEnumerable<T> AKDMMFBJFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CCE0", Offset = "0x2D9C0E0", VA = "0x182D9CCE0")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C7A0", Offset = "0x2D9BBA0", VA = "0x182D9C7A0")]
	public void AEBCKEEKBOK(int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D390", Offset = "0x2D9C790", VA = "0x182D9D390")]
	public void MMBPDCEOFDB(int EFJDLDLIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E170", Offset = "0x2D9D570", VA = "0x182D9E170")]
	public void NOMDGCOBCEN(T[] CCKHAOABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CD00", Offset = "0x2D9C100", VA = "0x182D9CD00")]
	public Enumerator IEHFBKOKLDF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E560", Offset = "0x2D9D960", VA = "0x182D9E560", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E560", Offset = "0x2D9D960", VA = "0x182D9E560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CED0", Offset = "0x2D9C2D0", VA = "0x182D9CED0")]
	private int LBLIADPBPBB(int PGFOAHEHPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CDB0", Offset = "0x2D9C1B0", VA = "0x182D9CDB0")]
	private int JHBKJHLMAMF(int PGFOAHEHPOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class HKBJOGHFLPL<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> EJKEAFJJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> LFKHGOFDOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x727170", Offset = "0x726570", VA = "0x180727170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x38E1AA0", Offset = "0x38E0EA0", VA = "0x1838E1AA0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x38E1B40", Offset = "0x38E0F40", VA = "0x1838E1B40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x38E1A40", Offset = "0x38E0E40", VA = "0x1838E1A40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38E19B0", Offset = "0x38E0DB0", VA = "0x1838E19B0")]
	public HKBJOGHFLPL(Func<Internal, External> OGMBHJLBFEE, Func<External, Internal> EJKEAFJJOCB, bool CNDIMEFFGEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38E1730", Offset = "0x38E0B30", VA = "0x1838E1730", Slot = "6")]
	public int IndexOf(External MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x38E13B0", Offset = "0x38E07B0", VA = "0x1838E13B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x38E1410", Offset = "0x38E0810", VA = "0x1838E1410", Slot = "13")]
	public bool Contains(External MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x38E14A0", Offset = "0x38E08A0", VA = "0x1838E14A0", Slot = "14")]
	public void CopyTo(External[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x38E12C0", Offset = "0x38E06C0", VA = "0x1838E12C0", Slot = "11")]
	public void Add(External MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x38E17C0", Offset = "0x38E0BC0", VA = "0x1838E17C0", Slot = "7")]
	public void Insert(int PGFOAHEHPOH, External MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38E1920", Offset = "0x38E0D20", VA = "0x1838E1920", Slot = "15")]
	public bool Remove(External MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38E1860", Offset = "0x38E0C60", VA = "0x1838E1860", Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38E16C0", Offset = "0x38E0AC0", VA = "0x1838E16C0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x217B600", Offset = "0x217AA00", VA = "0x18217B600", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class KOONGMFGENH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> OGMBHJLBFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> LFKHGOFDOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x398D1C0", Offset = "0x398C5C0", VA = "0x18398D1C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x398D160", Offset = "0x398C560", VA = "0x18398D160", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2180DB0", Offset = "0x21801B0", VA = "0x182180DB0")]
	public KOONGMFGENH(Func<Internal, External> OGMBHJLBFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x398D110", Offset = "0x398C510", VA = "0x18398D110")]
	public KOONGMFGENH(IReadOnlyList<Internal> BEOMDPHLMGK, Func<Internal, External> OGMBHJLBFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x398CEF0", Offset = "0x398C2F0", VA = "0x18398CEF0")]
	public void NOMDGCOBCEN(External[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x398CE80", Offset = "0x398C280", VA = "0x18398CE80", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1428FE0", Offset = "0x14283E0", VA = "0x181428FE0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HNMNBIDPJAO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> BEOMDPHLMGK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> LFKHGOFDOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD49D0", Offset = "0x3FD3DD0", VA = "0x183FD49D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4970", Offset = "0x3FD3D70", VA = "0x183FD4970", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2180DB0", Offset = "0x21801B0", VA = "0x182180DB0")]
	public HNMNBIDPJAO(IReadOnlyList<Internal> BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD48D0", Offset = "0x3FD3CD0", VA = "0x183FD48D0")]
	public bool OOGLABKJNAC(External MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3FD46A0", Offset = "0x3FD3AA0", VA = "0x183FD46A0")]
	public void NOMDGCOBCEN(External[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3FD4630", Offset = "0x3FD3A30", VA = "0x183FD4630", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x217B600", Offset = "0x217AA00", VA = "0x18217B600", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CDLAOOBMCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LIENGIODNNC(object[] LBFFDNKPEBE);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected CDLAOOBMCJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class MFOECNPMGGB<T> : CDLAOOBMCJB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct KHJBNBMBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum DNBNLNMJDLP
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
		public DNBNLNMJDLP NLAFPPIOFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T PADKGNIPPLI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int BJFCDLDGBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool JEMLBNBKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool MMPHJFFHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MFNNEECJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<KHJBNBMBFMJ> EFGFJJFFKCG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EJNOFOLKBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x306EEB0", Offset = "0x306E2B0", VA = "0x18306EEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x306EEF0", Offset = "0x306E2F0", VA = "0x18306EEF0")]
	protected MFOECNPMGGB(bool MMPHJFFHHKD, bool JEMLBNBKAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x306EBE0", Offset = "0x306DFE0", VA = "0x18306EBE0")]
	protected bool GKALHONBNJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x306E9C0", Offset = "0x306DDC0", VA = "0x18306E9C0")]
	protected void ECKGFIBGAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x306E810", Offset = "0x306DC10", VA = "0x18306E810")]
	protected void AKOIPNBBJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D310", Offset = "0x1E2C710", VA = "0x181E2D310")]
	private static void APHKENCPNKM<U>(ref List<U> BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x306EA80", Offset = "0x306DE80", VA = "0x18306EA80", Slot = "5")]
	public void EIPAABBBFMM(T PADKGNIPPLI, bool INJGJKPDMOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x306EC60", Offset = "0x306E060", VA = "0x18306EC60", Slot = "6")]
	public void GMLJNDAKNDK(T PADKGNIPPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x306EDA0", Offset = "0x306E1A0", VA = "0x18306EDA0")]
	public void HLOEIBCGJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NMBOJGGHODL
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OMGHCAFPMEP : global::MFOECNPMGGB<Action>, NMBOJGGHODL
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6DE0", Offset = "0x5ED61E0", VA = "0x185ED6DE0")]
	public OMGHCAFPMEP(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6AA0", Offset = "0x5ED5EA0", VA = "0x185ED6AA0")]
	public void JANNCPKLNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6CB0", Offset = "0x5ED60B0", VA = "0x185ED6CB0", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6D20", Offset = "0x5ED6120", VA = "0x185ED6D20")]
	public static OMGHCAFPMEP NEHMMEEOCFG(OMGHCAFPMEP EGHLJLGLPGL, Action PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6D80", Offset = "0x5ED6180", VA = "0x185ED6D80")]
	public static OMGHCAFPMEP PFEKAIAMIFN(OMGHCAFPMEP EGHLJLGLPGL, Action PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FGJGNFAJEPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class OJJKGOKAKMH<T> : global::MFOECNPMGGB<Action<T>>, global::FGJGNFAJEPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public OJJKGOKAKMH(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x28E0910", Offset = "0x28DFD10", VA = "0x1828E0910")]
	public void JANNCPKLNPH(T PMFPAMNENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x28E3390", Offset = "0x28E2790", VA = "0x1828E3390", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x28E3B90", Offset = "0x28E2F90", VA = "0x1828E3B90")]
	public static global::OJJKGOKAKMH<T> NEHMMEEOCFG(global::OJJKGOKAKMH<T> EGHLJLGLPGL, Action<T> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x28E3C30", Offset = "0x28E3030", VA = "0x1828E3C30")]
	public static global::OJJKGOKAKMH<T> PFEKAIAMIFN(global::OJJKGOKAKMH<T> EGHLJLGLPGL, Action<T> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EEOOJAECHIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T, U> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T, U> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EOJOLPHLMNN<T, U> : global::MFOECNPMGGB<Action<T, U>>, global::EEOOJAECHIL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public EOJOLPHLMNN(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x40C4250", Offset = "0x40C3650", VA = "0x1840C4250")]
	public void JANNCPKLNPH(T PMFPAMNENCI, U BFFKJIHCFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x40C7240", Offset = "0x40C6640", VA = "0x1840C7240", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x111E7E0", Offset = "0x111DBE0", VA = "0x18111E7E0")]
	public static global::EOJOLPHLMNN<T, U> NEHMMEEOCFG(global::EOJOLPHLMNN<T, U> EGHLJLGLPGL, Action<T, U> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x111E880", Offset = "0x111DC80", VA = "0x18111E880")]
	public static global::EOJOLPHLMNN<T, U> PFEKAIAMIFN(global::EOJOLPHLMNN<T, U> EGHLJLGLPGL, Action<T, U> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FLNLKEDCBJP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T, U, V> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T, U, V> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class NBPCEGEPNGN<T, U, V> : global::MFOECNPMGGB<Action<T, U, V>>, global::FLNLKEDCBJP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public NBPCEGEPNGN(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2D3BEA0", Offset = "0x2D3B2A0", VA = "0x182D3BEA0")]
	public void JANNCPKLNPH(T PMFPAMNENCI, U BFFKJIHCFNC, V CJJLCOOAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2D3DF20", Offset = "0x2D3D320", VA = "0x182D3DF20", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E130", Offset = "0x2D3D530", VA = "0x182D3E130")]
	public static global::NBPCEGEPNGN<T, U, V> NEHMMEEOCFG(global::NBPCEGEPNGN<T, U, V> EGHLJLGLPGL, Action<T, U, V> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E1D0", Offset = "0x2D3D5D0", VA = "0x182D3E1D0")]
	public static global::NBPCEGEPNGN<T, U, V> PFEKAIAMIFN(global::NBPCEGEPNGN<T, U, V> EGHLJLGLPGL, Action<T, U, V> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EHGEBHNDGLI<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T, U, V, W> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T, U, V, W> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class HBKOJADCNBC<T, U, V, W> : global::MFOECNPMGGB<Action<T, U, V, W>>, global::EHGEBHNDGLI<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public HBKOJADCNBC(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2D91580", Offset = "0x2D90980", VA = "0x182D91580")]
	public void JANNCPKLNPH(T PMFPAMNENCI, U BFFKJIHCFNC, V CJJLCOOAFHD, W CIBKDAIJBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2D920A0", Offset = "0x2D914A0", VA = "0x182D920A0", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2D93510", Offset = "0x2D92910", VA = "0x182D93510")]
	public static global::HBKOJADCNBC<T, U, V, W> NEHMMEEOCFG(global::HBKOJADCNBC<T, U, V, W> EGHLJLGLPGL, Action<T, U, V, W> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2D935B0", Offset = "0x2D929B0", VA = "0x182D935B0")]
	public static global::HBKOJADCNBC<T, U, V, W> PFEKAIAMIFN(global::HBKOJADCNBC<T, U, V, W> EGHLJLGLPGL, Action<T, U, V, W> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NNIFEIEELAK<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T, U, V, W, X> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T, U, V, W, X> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class KFALCILKAKN<T, U, V, W, X> : global::MFOECNPMGGB<Action<T, U, V, W, X>>, global::NNIFEIEELAK<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public KFALCILKAKN(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x350F3D0", Offset = "0x350E7D0", VA = "0x18350F3D0")]
	public void JANNCPKLNPH(T PMFPAMNENCI, U BFFKJIHCFNC, V CJJLCOOAFHD, W CIBKDAIJBIH, X HHAEMEGNPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x350F990", Offset = "0x350ED90", VA = "0x18350F990", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x350FFA0", Offset = "0x350F3A0", VA = "0x18350FFA0")]
	public static global::KFALCILKAKN<T, U, V, W, X> NEHMMEEOCFG(global::KFALCILKAKN<T, U, V, W, X> EGHLJLGLPGL, Action<T, U, V, W, X> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3510040", Offset = "0x350F440", VA = "0x183510040")]
	public static global::KFALCILKAKN<T, U, V, W, X> PFEKAIAMIFN(global::KFALCILKAKN<T, U, V, W, X> EGHLJLGLPGL, Action<T, U, V, W, X> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FNKOJCBPHJF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIPAABBBFMM(Action<T, U, V, W, X, Y> PADKGNIPPLI, bool INJGJKPDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLJNDAKNDK(Action<T, U, V, W, X, Y> PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GMGMDLKJALB<T, U, V, W, X, Y> : global::MFOECNPMGGB<Action<T, U, V, W, X, Y>>, global::FNKOJCBPHJF<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x111E920", Offset = "0x111DD20", VA = "0x18111E920")]
	public GMGMDLKJALB(bool MMPHJFFHHKD = false, bool JEMLBNBKAFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x27B7B20", Offset = "0x27B6F20", VA = "0x1827B7B20")]
	public void JANNCPKLNPH(T PMFPAMNENCI, U BFFKJIHCFNC, V CJJLCOOAFHD, W CIBKDAIJBIH, X HHAEMEGNPGJ, Y ACCHMFPFGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x27B8740", Offset = "0x27B7B40", VA = "0x1827B8740", Slot = "4")]
	public override void LIENGIODNNC(object[] LBFFDNKPEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A80", Offset = "0x27B7E80", VA = "0x1827B8A80")]
	public static global::GMGMDLKJALB<T, U, V, W, X, Y> NEHMMEEOCFG(global::GMGMDLKJALB<T, U, V, W, X, Y> EGHLJLGLPGL, Action<T, U, V, W, X, Y> PADKGNIPPLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x27B8B20", Offset = "0x27B7F20", VA = "0x1827B8B20")]
	public static global::GMGMDLKJALB<T, U, V, W, X, Y> PFEKAIAMIFN(global::GMGMDLKJALB<T, U, V, W, X, Y> EGHLJLGLPGL, Action<T, U, V, W, X, Y> PADKGNIPPLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JABBHHMLPFK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct HPFPPIKELBB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::JABBHHMLPFK<T> HEFABFIIGNF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T ECFALLCDCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3FD5CE0", Offset = "0x3FD50E0", VA = "0x183FD5CE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5D00", Offset = "0x3FD5100", VA = "0x183FD5D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
		public HPFPPIKELBB(global::JABBHHMLPFK<T> HEFABFIIGNF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ABMDKDMIILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<HPFPPIKELBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::JABBHHMLPFK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BBE0", Offset = "0x2C8AFE0", VA = "0x182C8BBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2018770", Offset = "0x2017B70", VA = "0x182018770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GKCLMDBHCKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<HPFPPIKELBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::JABBHHMLPFK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x27B26B0", Offset = "0x27B1AB0", VA = "0x1827B26B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2018770", Offset = "0x2017B70", VA = "0x182018770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim AHMBEBCPEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T HFCELNLELJB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NMGKHOEPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x29AA730", Offset = "0x29A9B30", VA = "0x1829AA730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x29AA780", Offset = "0x29A9B80", VA = "0x1829AA780")]
	public JABBHHMLPFK(in T HFCELNLELJB, int OJOOMAKFJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x29AA750", Offset = "0x29A9B50", VA = "0x1829AA750")]
	public JABBHHMLPFK(in T HFCELNLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x29AA6B0", Offset = "0x29A9AB0", VA = "0x1829AA6B0")]
	public HPFPPIKELBB HFOCPDOAGGC()
	{
		return default(HPFPPIKELBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x29AA6F0", Offset = "0x29A9AF0", VA = "0x1829AA6F0")]
	public HPFPPIKELBB HFOCPDOAGGC(CancellationToken BJBDGBAHFDE)
	{
		return default(HPFPPIKELBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x29AA110", Offset = "0x29A9510", VA = "0x1829AA110")]
	[AsyncStateMachine(typeof(global::JABBHHMLPFK<>.ABMDKDMIILD))]
	public Task<HPFPPIKELBB> APENFBPFCAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x29AA540", Offset = "0x29A9940", VA = "0x1829AA540")]
	[AsyncStateMachine(typeof(global::JABBHHMLPFK<>.GKCLMDBHCKD))]
	public Task<HPFPPIKELBB> APENFBPFCAD(CancellationToken BJBDGBAHFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FFLAKDKAIPE
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2120", Offset = "0x5ED1520", VA = "0x185ED2120")]
	public static global::JABBHHMLPFK<KMBCDIKKHFF> AJMCJLMMDDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2180", Offset = "0x5ED1580", VA = "0x185ED2180")]
	public static global::JABBHHMLPFK<KMBCDIKKHFF> AJMCJLMMDDK(int OJOOMAKFJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x23B87E0", Offset = "0x23B7BE0", VA = "0x1823B87E0")]
	public static global::JABBHHMLPFK<T> AJMCJLMMDDK<T>(in T HFCELNLELJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x27CC100", Offset = "0x27CB500", VA = "0x1827CC100")]
	public static global::JABBHHMLPFK<T> AJMCJLMMDDK<T>(in T HFCELNLELJB, int OJOOMAKFJNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HEENDAAJDNM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> NPEOMEKKJJN(TRequest DKKNMPCNGDF, CancellationToken BJBDGBAHFDE);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum GEJMIEAKEHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class HBCPJEDLNJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float OHFECPKHDIC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan BDDIIMPHNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int FCJMGMJLILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public GEJMIEAKEHE FMOMEHLAEKK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HBCPJEDLNJP MGJBOLMPFNF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float DIJPCHIELFO
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2D8E050", Offset = "0x2D8D450", VA = "0x182D8E050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DDABNGKLLEG
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E130", Offset = "0x2D8D530", VA = "0x182D8E130")]
		public HBCPJEDLNJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct LJPJLFIBFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest DKKNMPCNGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken BJBDGBAHFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> GLEELMEFJCE;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x23E2110", Offset = "0x23E1510", VA = "0x1823E2110")]
		public LJPJLFIBFFM(TRequest DKKNMPCNGDF, TaskCompletionSource<TResult> GLEELMEFJCE, CancellationToken BJBDGBAHFDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BJAKOFPHBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public BJAKOFPHBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FFCAGMDEKEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::HEENDAAJDNM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x329D4E0", Offset = "0x329C8E0", VA = "0x18329D4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BCDNAFINEFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::HEENDAAJDNM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private LJPJLFIBFFM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAD80", Offset = "0x2CAA180", VA = "0x182CAAD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource EHPCGILMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<LJPJLFIBFFM> KCCHKJAGGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HBCPJEDLNJP LMBNIEEDPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NPEOMEKKJJN MLMHAAFMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task CEPPNKAHMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GCBCEJEJBGH;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2D988D0", Offset = "0x2D97CD0", VA = "0x182D988D0")]
	public HEENDAAJDNM(NPEOMEKKJJN MLMHAAFMDCF, [Optional] HBCPJEDLNJP LMBNIEEDPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2D976A0", Offset = "0x2D96AA0", VA = "0x182D976A0")]
	public Task<TResult> NJFIHFAPNAG(TRequest DKKNMPCNGDF, CancellationToken BJBDGBAHFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2D96F20", Offset = "0x2D96320", VA = "0x182D96F20")]
	private void IOEJFLEOEFB(LJPJLFIBFFM DOCDBOENBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2D975A0", Offset = "0x2D969A0", VA = "0x182D975A0")]
	[AsyncStateMachine(typeof(global::HEENDAAJDNM<, >.FFCAGMDEKEJ))]
	private Task JHOFKBDEIDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2D98020", Offset = "0x2D97420", VA = "0x182D98020")]
	private LJPJLFIBFFM ODJGJPBKGGF()
	{
		return default(LJPJLFIBFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2D97280", Offset = "0x2D96680", VA = "0x182D97280")]
	[AsyncStateMachine(typeof(global::HEENDAAJDNM<, >.BCDNAFINEFL))]
	private Task JDKGLGNJOHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2D984B0", Offset = "0x2D978B0", VA = "0x182D984B0")]
	private void OHJDKFPLMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D96E30", Offset = "0x2D96230", VA = "0x182D96E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LNBEKHAHAIK<TKey, TVal> : global::BILPELMLBHE<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int JLGENEHCPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> ONJNHIOFDMO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int JHKENBOHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x23E8FA0", Offset = "0x23E83A0", VA = "0x1823E8FA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int BLOKJDOCDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x23E8D80", Offset = "0x23E8180", VA = "0x1823E8D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x23E8DB0", Offset = "0x23E81B0", VA = "0x1823E8DB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x23E9430", Offset = "0x23E8830", VA = "0x1823E9430")]
	public LNBEKHAHAIK(int OIKPPNLJGJL, [Optional] HINKHBGKIHJ MGCIMMMCEKP, [Optional] IEqualityComparer<TKey> KOJODEKHLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x23E8F00", Offset = "0x23E8300", VA = "0x1823E8F00")]
	public void LHOIPLOBANA(TKey MPIADBGKNBD, TVal PKODKJLGOIN, bool GFPJEHHAAHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x23E8E10", Offset = "0x23E8210", VA = "0x1823E8E10")]
	public bool HCIJCECGBHK(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x23E91E0", Offset = "0x23E85E0", VA = "0x1823E91E0", Slot = "6")]
	public override bool MLNCJCFKCNK(TKey LPHGPLFBFPL, out TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x23E8FD0", Offset = "0x23E83D0", VA = "0x1823E8FD0")]
	public bool MHLILILNFCP(TKey MPIADBGKNBD, TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x23E9320", Offset = "0x23E8720", VA = "0x1823E9320")]
	public bool NCBJIPPBBKK(TKey MPIADBGKNBD, TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x23E8E90", Offset = "0x23E8290", VA = "0x1823E8E90", Slot = "7")]
	public override void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x23E9280", Offset = "0x23E8680", VA = "0x1823E9280")]
	private bool NBAIIODOIPD(TKey MPIADBGKNBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class BILPELMLBHE<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int HINKHBGKIHJ(TKey MPIADBGKNBD, TVal PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CPIFCKPPMHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey CPJKOGHACEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal ECFALLCDCAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int OOCCNILBMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x68F1B0", Offset = "0x68E5B0", VA = "0x18068F1B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x822DE0", Offset = "0x8221E0", VA = "0x180822DE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime LONEGFHCCAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE95A20", Offset = "0xE94E20", VA = "0x180E95A20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x27688A0", Offset = "0x2767CA0", VA = "0x1827688A0")]
		public CPIFCKPPMHM(TKey MPIADBGKNBD, TVal IACKENKPPHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int OOKMPPGEKHE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CPIFCKPPMHM>> FOCCIIOLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CPIFCKPPMHM> PGHGECDDNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly HINKHBGKIHJ MGCIMMMCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan FLMEHHCADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly OMLEGHHLBGK HBNFNCAIGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IMOKBMBOCKN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BOODKFKIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x66D020", Offset = "0x66C420", VA = "0x18066D020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool FBGBOABNMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC3F0", Offset = "0x2CBB7F0", VA = "0x182CBC3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int JHKENBOHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x955870", Offset = "0x954C70", VA = "0x180955870", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int EFJDLDLIAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2768E50", Offset = "0x2768250", VA = "0x182768E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1ECCC00", Offset = "0x1ECC000", VA = "0x181ECCC00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> JIGODMPOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA5A0", Offset = "0x2CB99A0", VA = "0x182CBA5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB100", Offset = "0x2CBA500", VA = "0x182CBB100")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCAD0", Offset = "0x2CBBED0", VA = "0x182CBCAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDB20", Offset = "0x2CBCF20", VA = "0x182CBDB20")]
	public BILPELMLBHE(int OIKPPNLJGJL, [Optional] HINKHBGKIHJ MGCIMMMCEKP, [Optional] IEqualityComparer<TKey> KOJODEKHLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD500", Offset = "0x2CBC900", VA = "0x182CBD500")]
	public BILPELMLBHE(TimeSpan FLMEHHCADFP, [Optional] IEqualityComparer<TKey> KOJODEKHLML, [Optional] OMLEGHHLBGK HBNFNCAIGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD3E0", Offset = "0x2CBC7E0", VA = "0x182CBD3E0")]
	public BILPELMLBHE(int OIKPPNLJGJL, TimeSpan FLMEHHCADFP, [Optional] IEqualityComparer<TKey> KOJODEKHLML, [Optional] OMLEGHHLBGK HBNFNCAIGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD550", Offset = "0x2CBC950", VA = "0x182CBD550")]
	public BILPELMLBHE(int OIKPPNLJGJL, HINKHBGKIHJ MGCIMMMCEKP, TimeSpan FLMEHHCADFP, [Optional] IEqualityComparer<TKey> KOJODEKHLML, [Optional] OMLEGHHLBGK HBNFNCAIGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC270", Offset = "0x2CBB670", VA = "0x182CBC270")]
	public void IEIOBIHHDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC900", Offset = "0x2CBBD00", VA = "0x182CBC900")]
	public void JKDFMHKJMMK(TKey MPIADBGKNBD, TVal PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB5C0", Offset = "0x2CBA9C0", VA = "0x182CBB5C0")]
	public bool GMLJNDAKNDK(TKey MPIADBGKNBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB370", Offset = "0x2CBA770", VA = "0x182CBB370")]
	private TVal DPALGOGEJPD(TKey LPHGPLFBFPL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCDC0", Offset = "0x2CBC1C0", VA = "0x182CBCDC0", Slot = "6")]
	public virtual bool MLNCJCFKCNK(TKey LPHGPLFBFPL, out TVal PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBF20", Offset = "0x2CBB320", VA = "0x182CBBF20", Slot = "7")]
	public virtual void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC600", Offset = "0x2CBBA00", VA = "0x182CBC600")]
	private bool JFFNPKPLMHE(CPIFCKPPMHM CMAEAIILIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CBAC40", Offset = "0x2CBA040", VA = "0x182CBAC40")]
	private void AHBPMILKGAO(LinkedListNode<CPIFCKPPMHM> PFNGLONBEII, TVal NKLJAHJEFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CB9DF0", Offset = "0x2CB91F0", VA = "0x182CB9DF0")]
	private void ADHCGEPJHIK(TKey MPIADBGKNBD, TVal PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBBE0", Offset = "0x2CBAFE0", VA = "0x182CBBBE0")]
	private void HJPOOANDDLG(CPIFCKPPMHM CMAEAIILIMD, TVal NKLJAHJEFHB, int BHDCAGDFAAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class GJILEOGNGEB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> BEOMDPHLMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> GKGAMENNBGI;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DJBJNAECNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1120660", Offset = "0x111FA60", VA = "0x181120660", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x27B1960", Offset = "0x27B0D60", VA = "0x1827B1960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x27B10E0", Offset = "0x27B04E0", VA = "0x1827B10E0", Slot = "11")]
	public void Add(T MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x27B13C0", Offset = "0x27B07C0", VA = "0x1827B13C0")]
	public bool LOFLBGEPPLP(T MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x27B1740", Offset = "0x27B0B40", VA = "0x1827B1740", Slot = "15")]
	public bool Remove(T MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x27662B0", Offset = "0x27656B0", VA = "0x1827662B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x23DB230", Offset = "0x23DA630", VA = "0x1823DB230", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x27B1110", Offset = "0x27B0510", VA = "0x1827B1110", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27B1170", Offset = "0x27B0570", VA = "0x1827B1170", Slot = "13")]
	public bool Contains(T MCHONOPAOMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x27B11A0", Offset = "0x27B05A0", VA = "0x1827B11A0", Slot = "14")]
	public void CopyTo(T[] CCKHAOABLMF, int EFDMFNHPCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27B11D0", Offset = "0x27B05D0", VA = "0x1827B11D0", Slot = "6")]
	public int IndexOf(T MCHONOPAOMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27B1200", Offset = "0x27B0600", VA = "0x1827B1200", Slot = "7")]
	public void Insert(int PGFOAHEHPOH, T MCHONOPAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27B15E0", Offset = "0x27B09E0", VA = "0x1827B15E0", Slot = "8")]
	public void RemoveAt(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27B0F40", Offset = "0x27B0340", VA = "0x1827B0F40")]
	public void AEMHLDLFBJN(Predicate<T> PEABICLHBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27B1390", Offset = "0x27B0790", VA = "0x1827B1390")]
	public void KAADNOLIHIH(Comparison<T> CMJBJGPADFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27B17C0", Offset = "0x27B0BC0", VA = "0x1827B17C0")]
	public GJILEOGNGEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EDOILKBFNOK
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1340", Offset = "0x5ED0740", VA = "0x185ED1340")]
	public static Vector3 NJHEAHGJDJK(this GameObject MGDBDEJKIMA, float JIGPHPPCAOL)
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
			[Cpp2IlInjected.Address(RVA = "0x1EE5BB0", Offset = "0x1EE4FB0", VA = "0x181EE5BB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D20", Offset = "0x5ED8120", VA = "0x185ED8D20")]
		public SerializedGuid(in Guid KIDLKIGCBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8AA0", Offset = "0x5ED7EA0", VA = "0x185ED8AA0")]
		public static SerializedGuid JJKDCNJNABN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8C90", Offset = "0x5ED8090", VA = "0x185ED8C90")]
		public static SerializedGuid PGGNENKBNIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8840", Offset = "0x5ED7C40", VA = "0x185ED8840")]
		public bool CAOBGEHCFAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8C60", Offset = "0x5ED8060", VA = "0x185ED8C60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8BC0", Offset = "0x5ED7FC0", VA = "0x185ED8BC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8B30", Offset = "0x5ED7F30", VA = "0x185ED8B30")]
		public bool KPLPCHPLAID(in Guid KIDLKIGCBDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8900", Offset = "0x5ED7D00", VA = "0x185ED8900", Slot = "7")]
		public bool Equals(SerializedGuid BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED89B0", Offset = "0x5ED7DB0", VA = "0x185ED89B0", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8A90", Offset = "0x5ED7E90", VA = "0x185ED8A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5ED88D0", Offset = "0x5ED7CD0", VA = "0x185ED88D0", Slot = "6")]
		public int CompareTo(SerializedGuid BKBGGIICJOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GAIOJINAEHO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type GKGDOGCJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string ACDMFLMFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool FLOAANNNHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool DNDLJPAGDPB;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2BE0", Offset = "0x5ED1FE0", VA = "0x185ED2BE0")]
	public GAIOJINAEHO(Type PFBHKKNEHJJ, string GGINEAAPBEE, bool DCIGDFAIAIJ = false, bool OKIHADCJLGG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CPJAKKIGPJF
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface DGGJGNJIBJA<T> : CPJAKKIGPJF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool LAGILNNCNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string AKHJALNGCBB
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
	global::DGGJGNJIBJA<T> MFJCAMPGJGB(Action<T> HDNLOGIPGFM);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DGGJGNJIBJA<T> IDGIJJFLJNL(Action<T> HDNLOGIPGFM);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DGGJGNJIBJA<T> EKLMKGLKKDG(Action<T, T> LPKMIGJIGBH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DGGJGNJIBJA<T> MIPJCFHHNFO(Action<T, T> LPKMIGJIGBH);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DGGJGNJIBJA<T> HPDAJPMFBBI(Action<string> BLOOOFDIGNG);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DGGJGNJIBJA<T> KHGFIIBLJME(Action<string> BLOOOFDIGNG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LKGPDFMIGKG<T> : global::DGGJGNJIBJA<T>, CPJAKKIGPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::EOJOLPHLMNN<T, T> IHBAELHAGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::OJJKGOKAKMH<T> CJHDBODFNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::OJJKGOKAKMH<string> MAIMNGPNCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string DNNOOMDNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T HNCBGLIPCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BKLECILHJIL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x23E2E60", Offset = "0x23E2260", VA = "0x1823E2E60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LAGILNNCNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x738540", Offset = "0x737940", VA = "0x180738540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string AKHJALNGCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1705530", Offset = "0x1704930", VA = "0x181705530", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x23E2B60", Offset = "0x23E1F60", VA = "0x1823E2B60")]
	private void BBOCDHNDFJI(T EGDJKJOHALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x23E2C50", Offset = "0x23E2050", VA = "0x1823E2C50")]
	private void HKDPPNHBDKF(string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x23E2AB0", Offset = "0x23E1EB0", VA = "0x1823E2AB0")]
	public void ACEKBINJHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x23E2C00", Offset = "0x23E2000", VA = "0x1823E2C00", Slot = "6")]
	public global::DGGJGNJIBJA<T> EKLMKGLKKDG(Action<T, T> LPKMIGJIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x23E2F20", Offset = "0x23E2320", VA = "0x1823E2F20", Slot = "7")]
	public global::DGGJGNJIBJA<T> MIPJCFHHNFO(Action<T, T> LPKMIGJIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x23E2E90", Offset = "0x23E2290", VA = "0x1823E2E90", Slot = "4")]
	public global::DGGJGNJIBJA<T> MFJCAMPGJGB(Action<T> LPKMIGJIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x23E2DA0", Offset = "0x23E21A0", VA = "0x1823E2DA0", Slot = "5")]
	public global::DGGJGNJIBJA<T> IDGIJJFLJNL(Action<T> HDNLOGIPGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x23E2D00", Offset = "0x23E2100", VA = "0x1823E2D00", Slot = "8")]
	public global::DGGJGNJIBJA<T> HPDAJPMFBBI(Action<string> BLOOOFDIGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x23E2DF0", Offset = "0x23E21F0", VA = "0x1823E2DF0", Slot = "9")]
	public global::DGGJGNJIBJA<T> KHGFIIBLJME(Action<string> BLOOOFDIGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x23E2F70", Offset = "0x23E2370", VA = "0x1823E2F70")]
	public LKGPDFMIGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KIMOMCCOHPM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PNKICPPHAPG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::DGGJGNJIBJA<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::CABNICEFBOO<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public PNKICPPHAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x41F2FF0", Offset = "0x41F23F0", VA = "0x1841F2FF0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3690", Offset = "0x2BB2A90", VA = "0x182BB3690")]
	public static global::BHPNOFOGFAO<T> DKOCCOGEFLF<T>(this global::DGGJGNJIBJA<T> DELEKBDNIMK, Action<T> EGLKIOCIBPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HLIIJDKEIIJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct GHONPNKPJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long CLNJAKCJEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long CBCFAPIOKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int LHKNONGHEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int LDGHLMBPNLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool DIDMEHODLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string MDDKIDOLLHB;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x27A8F80", Offset = "0x27A8380", VA = "0x1827A8F80")]
		public GHONPNKPJDK(long CLNJAKCJEKA, int LHKNONGHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x27A8F50", Offset = "0x27A8350", VA = "0x1827A8F50")]
		public GHONPNKPJDK(long CLNJAKCJEKA, long CBCFAPIOKAD, int LHKNONGHEID, int LDGHLMBPNLA, bool DIDMEHODLFF, string MDDKIDOLLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x27A8E00", Offset = "0x27A8200", VA = "0x1827A8E00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void KHGAFBJNHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x27A8E70", Offset = "0x27A8270", VA = "0x1827A8E70")]
		public int KHKHJOFBBOA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x27A8D70", Offset = "0x27A8170", VA = "0x1827A8D70")]
		public int EHKGHNBECJJ(int CGJDEMAHKHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x27A8D90", Offset = "0x27A8190", VA = "0x1827A8D90")]
		public double JMNKPNFBAFD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x27A8EC0", Offset = "0x27A82C0", VA = "0x1827A8EC0")]
		public GHONPNKPJDK PBDAAMMEONM(long CBCFAPIOKAD, int LDGHLMBPNLA)
		{
			return default(GHONPNKPJDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class LHKKDNHCKDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey CPJKOGHACEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::HLIIJDKEIIJ<TKey> PPFBACEKDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<LHKKDNHCKDD> DAMEJHANCEP;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string LCLKHNOCCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2177FC0", Offset = "0x21773C0", VA = "0x182177FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x23DC5E0", Offset = "0x23DB9E0", VA = "0x1823DC5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<LHKKDNHCKDD> MMKJCMJHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x23DC800", Offset = "0x23DBC00", VA = "0x1823DC800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public GHONPNKPJDK OIENCLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16BD090", Offset = "0x16BC490", VA = "0x1816BD090")]
			[CompilerGenerated]
			get
			{
				return default(GHONPNKPJDK);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x23DC400", Offset = "0x23DB800", VA = "0x1823DC400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x23DC820", Offset = "0x23DBC20", VA = "0x1823DC820")]
		internal LHKKDNHCKDD(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, TKey MPIADBGKNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x23DC610", Offset = "0x23DBA10", VA = "0x1823DC610")]
		public LHKKDNHCKDD FKDMBBACHNF(TKey MPIADBGKNBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x23DC720", Offset = "0x23DBB20", VA = "0x1823DC720")]
		public void GCMJCJGJFNB(TKey MPIADBGKNBD, Action<LHKKDNHCKDD> PADKGNIPPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1E28D20", Offset = "0x1E28120", VA = "0x181E28D20")]
		public T GCMJCJGJFNB<T>(TKey MPIADBGKNBD, Func<LHKKDNHCKDD, T> JCBJENNJFGO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1E28BB0", Offset = "0x1E27FB0", VA = "0x181E28BB0")]
		[AsyncStateMachine(typeof(GOGCIIJEGHP))]
		public Task<T> COGMCHKDGGB<T>(TKey MPIADBGKNBD, Func<LHKKDNHCKDD, Task<T>> JCBJENNJFGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x23DC430", Offset = "0x23DB830", VA = "0x1823DC430", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OACHNCNMGOB : IEnumerable<(TKey, List<TKey>, GHONPNKPJDK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GHONPNKPJDK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, GHONPNKPJDK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::HLIIJDKEIIJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, GHONPNKPJDK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, GHONPNKPJDK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2766EE0", Offset = "0x27662E0", VA = "0x182766EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GHONPNKPJDK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x28C36C0", Offset = "0x28C2AC0", VA = "0x1828C36C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2767140", Offset = "0x2766540", VA = "0x182767140")]
		[DebuggerHidden]
		public OACHNCNMGOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x142F080", Offset = "0x142E480", VA = "0x18142F080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x28C32E0", Offset = "0x28C26E0", VA = "0x1828C32E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x28C3720", Offset = "0x28C2B20", VA = "0x1828C3720")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x28C3680", Offset = "0x28C2A80", VA = "0x1828C3680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x28C3590", Offset = "0x28C2990", VA = "0x1828C3590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GHONPNKPJDK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x28C3650", Offset = "0x28C2A50", VA = "0x1828C3650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class COAJAKBDCDJ : IEnumerable<(TKey, List<TKey>, GHONPNKPJDK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GHONPNKPJDK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, GHONPNKPJDK timerEntry) <>2__current;

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
		private LHKKDNHCKDD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public LHKKDNHCKDD <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::HLIIJDKEIIJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<LHKKDNHCKDD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, GHONPNKPJDK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, GHONPNKPJDK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2766EE0", Offset = "0x27662E0", VA = "0x182766EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GHONPNKPJDK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2766F80", Offset = "0x2766380", VA = "0x182766F80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2767140", Offset = "0x2766540", VA = "0x182767140")]
		[DebuggerHidden]
		public COAJAKBDCDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2766FE0", Offset = "0x27663E0", VA = "0x182766FE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2766860", Offset = "0x2765C60", VA = "0x182766860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2767080", Offset = "0x2766480", VA = "0x182767080")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x27670E0", Offset = "0x27664E0", VA = "0x1827670E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2766F40", Offset = "0x2766340", VA = "0x182766F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2766E00", Offset = "0x2766200", VA = "0x182766E00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GHONPNKPJDK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2766F10", Offset = "0x2766310", VA = "0x182766F10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, GHONPNKPJDK> BAIMBHBJCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, GHONPNKPJDK> FFEFKAABMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::HLIIJDKEIIJ<TKey>> OFMMJNBCKHA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string GJBCGIKPMID = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly LHKKDNHCKDD FJHPMGAPKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool KHABLLHIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int OJFKPGKEHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch OJJMKLKNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int HLDJPMOKKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string FPAHCGIDDCN;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LHKKDNHCKDD LGFKMNLPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string LCLKHNOCCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x38E28A0", Offset = "0x38E1CA0", VA = "0x1838E28A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long PILFBGNAIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x38E2B00", Offset = "0x38E1F00", VA = "0x1838E2B00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int DMKMLKIDIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x38E27E0", Offset = "0x38E1BE0", VA = "0x1838E27E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x38E2B20", Offset = "0x38E1F20", VA = "0x1838E2B20")]
	public HLIIJDKEIIJ(TKey EBLIOPAJGJI, [Optional] int? LHKNONGHEID, [Optional][CanBeNull] Stopwatch OJJMKLKNPBD, [Optional] Action<TKey, GHONPNKPJDK> BAIMBHBJCMD, [Optional] Action<TKey, GHONPNKPJDK> FFEFKAABMPF, [Optional] Action<global::HLIIJDKEIIJ<TKey>> OFMMJNBCKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x38E2810", Offset = "0x38E1C10", VA = "0x1838E2810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x38E27C0", Offset = "0x38E1BC0", VA = "0x1838E27C0")]
	public void BLODPGNFADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x38E2A60", Offset = "0x38E1E60", VA = "0x1838E2A60")]
	public void JBBMENMJMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x38E29D0", Offset = "0x38E1DD0", VA = "0x1838E29D0")]
	[IteratorStateMachine(typeof(global::HLIIJDKEIIJ<>.OACHNCNMGOB))]
	public IEnumerable<(TKey, List<TKey>, GHONPNKPJDK)> ILFAGJAFBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x38E2900", Offset = "0x38E1D00", VA = "0x1838E2900")]
	[IteratorStateMachine(typeof(global::HLIIJDKEIIJ<>.COAJAKBDCDJ))]
	private IEnumerable<(TKey, List<TKey>, GHONPNKPJDK)> ILFAGJAFBHI(List<TKey> BABJIPJIPPC, LHKKDNHCKDD NAGJJMNCMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x38E2A80", Offset = "0x38E1E80", VA = "0x1838E2A80")]
	private (long, int) JPNAEDCOHBJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class IAGPABPKHIM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GOACMFBJNGK(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
	protected IAGPABPKHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LOIANMPMKKA<TKey> : global::IAGPABPKHIM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string KJFKNJAONML(TKey MPIADBGKNBD);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA270", Offset = "0x3DA9670", VA = "0x183DAA270")]
	protected string OINLAPABODI(double EKCDEOAEBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA1D0", Offset = "0x3DA95D0", VA = "0x183DAA1D0")]
	protected string KEOFMDPGEFK(int NGBJKBNJHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA230", Offset = "0x3DA9630", VA = "0x183DAA230")]
	private static string OGJMEPDKOFN(TKey MPIADBGKNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA120", Offset = "0x3DA9520", VA = "0x183DAA120", Slot = "4")]
	public override string GOACMFBJNGK(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3DA9FF0", Offset = "0x3DA93F0", VA = "0x183DA9FF0")]
	public string GOACMFBJNGK(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, [NotNull] KJFKNJAONML EBHLPIDJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GNKEMLDLNPN(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, [NotNull] KJFKNJAONML EBHLPIDJAIA);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x217B600", Offset = "0x217AA00", VA = "0x18217B600")]
	protected LOIANMPMKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HCJJHLEJCBE<TKey> : global::IAGPABPKHIM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string DIEFOFHLADF(TKey MPIADBGKNBD);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int LGNDALBOPOP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string KACNKFIFIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double PLENHPHEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool DHNNPBPELGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int IJDJGJNFAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> ALMJNKBPCNF;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2D95210", Offset = "0x2D94610", VA = "0x182D95210")]
	private static string OGJMEPDKOFN(TKey MPIADBGKNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2D95250", Offset = "0x2D94650", VA = "0x182D95250")]
	public HCJJHLEJCBE(string KACNKFIFIFM = "F2", double PLENHPHEAGL = double.MaxValue, bool DHNNPBPELGG = false, int IJDJGJNFAPI = int.MaxValue, [Optional] ISet<string> ALMJNKBPCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2D94880", Offset = "0x2D93C80", VA = "0x182D94880", Slot = "4")]
	public override Dictionary<string, string> GOACMFBJNGK(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2D951A0", Offset = "0x2D945A0", VA = "0x182D951A0")]
	private bool NEODBFLPHBA(string FDFLHPDIHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2D94930", Offset = "0x2D93D30", VA = "0x182D94930")]
	public Dictionary<string, string> GOACMFBJNGK(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, DIEFOFHLADF EBHLPIDJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2D94FF0", Offset = "0x2D943F0", VA = "0x182D94FF0")]
	private string KOCIDCPCIFL(StringBuilder IHOJDKNNMNM, List<TKey> CBCJPHAHDCO, DIEFOFHLADF EBHLPIDJAIA, bool ENKONJMLAEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2D94E70", Offset = "0x2D94270", VA = "0x182D94E70")]
	private static void HNFBADAABOP(StringBuilder MNKMPKEPNME, string CHIALCECBKN, bool GMHIOGADHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FGDIDCIICLE<TKey> : global::LOIANMPMKKA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct GNLEMJKBDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public KJFKNJAONML keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::FGDIDCIICLE<TKey> PNBICMAKACI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int KBKMCJHPECM = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] KCHFKOFPMJG;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x329F200", Offset = "0x329E600", VA = "0x18329F200")]
	private FGDIDCIICLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x329E120", Offset = "0x329D520", VA = "0x18329E120", Slot = "5")]
	protected override string GNKEMLDLNPN(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, KJFKNJAONML EBHLPIDJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x329F010", Offset = "0x329E410", VA = "0x18329F010")]
	[CompilerGenerated]
	internal static string PEMEHEJJPFE(string EJCFPFBMCGM, TKey MPIADBGKNBD, ref GNLEMJKBDIB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class ECBJKBLHNIO<TKey> : global::LOIANMPMKKA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class MDHEGJNJEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KJFKNJAONML keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public MDHEGJNJEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x23DD410", Offset = "0x23DC810", VA = "0x1823DD410")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x28B8540", Offset = "0x28B7940", VA = "0x1828B8540", Slot = "5")]
	protected override string GNKEMLDLNPN(global::HLIIJDKEIIJ<TKey> PPFBACEKDKI, KJFKNJAONML EBHLPIDJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2766460", Offset = "0x2765860", VA = "0x182766460")]
	public ECBJKBLHNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class CCIKMMGLFKI : global::HLIIJDKEIIJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IJLACFEDMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<CCIKMMGLFKI> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public IJLACFEDMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4C80", Offset = "0x5ED4080", VA = "0x185ED4C80")]
		internal void <Wrap>b__0(global::HLIIJDKEIIJ<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0970", Offset = "0x5ECFD70", VA = "0x185ED0970")]
	public CCIKMMGLFKI([Optional] string CCPKECIFNDJ, [Optional] int? LHKNONGHEID, [Optional] Stopwatch OJJMKLKNPBD, [Optional] Action<string, GHONPNKPJDK> BAIMBHBJCMD, [Optional] Action<string, GHONPNKPJDK> FFEFKAABMPF, [Optional] Action<CCIKMMGLFKI> OFMMJNBCKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0890", Offset = "0x5ECFC90", VA = "0x185ED0890")]
	private static Action<global::HLIIJDKEIIJ<string>> GCMJCJGJFNB(Action<CCIKMMGLFKI> EGLKIOCIBPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class OMLEGHHLBGK
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class GMMMLFHGOCJ : OMLEGHHLBGK
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static OMLEGHHLBGK PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5ED2CA0", Offset = "0x5ED20A0", VA = "0x185ED2CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime IMKFHPHKHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5ED2C50", Offset = "0x5ED2050", VA = "0x185ED2C50", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float PCCEFHEFKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5ED2D00", Offset = "0x5ED2100", VA = "0x185ED2D00", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2DB0", Offset = "0x5ED21B0", VA = "0x185ED2DB0")]
		public GMMMLFHGOCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static OMLEGHHLBGK HJCHKCPHNPF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static OMLEGHHLBGK MGJBOLMPFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6E40", Offset = "0x5ED6240", VA = "0x185ED6E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime IMKFHPHKHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float PCCEFHEFKON
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	protected OMLEGHHLBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KONKGLPJBMB : global::ONNPBDGGLIJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6600", Offset = "0x5ED5A00", VA = "0x185ED6600")]
	public KONKGLPJBMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class ONNPBDGGLIJ<T> : global::JGJKJEIENGF<T>, DLFAOEGEACP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> AABIHEKNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task FDBINEGOAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1125B70", Offset = "0x1124F70", VA = "0x181125B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::BHPNOFOGFAO<T> FMPBKGHLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private EEBBFEJKFOP ADMOEIEIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1704A00", Offset = "0x1703E00", VA = "0x181704A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4341F50", Offset = "0x4341350", VA = "0x184341F50")]
	public ONNPBDGGLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NPOLMMIFOLA : global::EIJIHNMLILI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED69A0", Offset = "0x5ED5DA0", VA = "0x185ED69A0")]
	public NPOLMMIFOLA(Exception CLHMIOKIOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EIJIHNMLILI<T> : global::JGJKJEIENGF<T>, DLFAOEGEACP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> AABIHEKNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task FDBINEGOAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1125B70", Offset = "0x1124F70", VA = "0x181125B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::BHPNOFOGFAO<T> FMPBKGHLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private EEBBFEJKFOP ADMOEIEIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1704A00", Offset = "0x1703E00", VA = "0x181704A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7110", Offset = "0x2FC6510", VA = "0x182FC7110")]
	public EIJIHNMLILI(Exception CLHMIOKIOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface DLFAOEGEACP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task AABIHEKNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	EEBBFEJKFOP FMPBKGHLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface JGJKJEIENGF<T> : DLFAOEGEACP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> AABIHEKNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::BHPNOFOGFAO<T> FMPBKGHLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class NFFCGBNOHJK<TTask, T> : global::JGJKJEIENGF<T>, DLFAOEGEACP, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class EJONEPBDIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::NFFCGBNOHJK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public EJONEPBDIIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool NHIKKANJOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> NNCIDDBLNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource EKAOFHIFMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool KHABLLHIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext EONAHPAMIHI;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> AABIHEKNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task FDBINEGOAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::BHPNOFOGFAO<T> FMPBKGHLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private EEBBFEJKFOP ADMOEIEIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1712A10", Offset = "0x1711E10", VA = "0x181712A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2D54880", Offset = "0x2D53C80", VA = "0x182D54880")]
	static NFFCGBNOHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2D54B60", Offset = "0x2D53F60", VA = "0x182D54B60")]
	protected NFFCGBNOHJK(TTask NNCIDDBLNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2D54810", Offset = "0x2D53C10", VA = "0x182D54810", Slot = "1")]
	~NFFCGBNOHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2D547E0", Offset = "0x2D53BE0", VA = "0x182D547E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2D54620", Offset = "0x2D53A20", VA = "0x182D54620")]
	private void ANGPDPCFPPL(bool MELHPHBBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T KGCAHIPIFEJ(TTask KFJJFIPEAGP);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FEEIGGJCPMC();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2D54790", Offset = "0x2D53B90", VA = "0x182D54790")]
	[CompilerGenerated]
	private void BHCBOOHKJMB(object FMOFDIPGIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface INBEDPJAMNF
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float DCAMLIOEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PKNOODLOHGF AKNFCFMMGDA;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EJPBBGLKCLE : INBEDPJAMNF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct FGDLCHAOFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float KIFBCELFNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float KDFFADPKBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool COOCIDMCJJO;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float OOCCNILBMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5ED21F0", Offset = "0x5ED15F0", VA = "0x185ED21F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2380", Offset = "0x5ED1780", VA = "0x185ED2380")]
		public FGDLCHAOFPG(float BOIMPMGFDJM, float NBODAMBMIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2200", Offset = "0x5ED1600", VA = "0x185ED2200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class HBFILIPIHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public EJPBBGLKCLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HBFILIPIHCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int OIKPPNLJGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int GAFOKAOJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly INBEDPJAMNF[] LKMIDJNEJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PKNOODLOHGF[] OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly FGDLCHAOFPG[] CDCBKKCHFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FGDLCHAOFPG OEAODIJIKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly FNGBJBALFEM IFJHCOPFPFL;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FGDLCHAOFPG LAPIHAACBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2FD6520", Offset = "0x2FD5920", VA = "0x182FD6520")]
		get
		{
			return default(FGDLCHAOFPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float DCAMLIOEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1D00", Offset = "0x5ED1100", VA = "0x185ED1D00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PKNOODLOHGF AKNFCFMMGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1E00", Offset = "0x5ED1200", VA = "0x185ED1E00", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1C40", Offset = "0x5ED1040", VA = "0x185ED1C40", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1EC0", Offset = "0x5ED12C0", VA = "0x185ED1EC0")]
	public EJPBBGLKCLE(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1D20", Offset = "0x5ED1120", VA = "0x185ED1D20")]
	public FNGBJBALFEM KEKGEANOKIN(FGDLCHAOFPG AKDMMFBJFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1660", Offset = "0x5ED0A60", VA = "0x185ED1660")]
	public void CNAOLNDMAIB(INBEDPJAMNF KJBGJINKNEP, [Optional] FGDLCHAOFPG ILFPEHMDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1DB0", Offset = "0x5ED11B0", VA = "0x185ED1DB0")]
	internal int LPHHEGFFIAL(INBEDPJAMNF DNGKFHKKDKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1610", Offset = "0x5ED0A10", VA = "0x185ED1610")]
	internal FGDLCHAOFPG CEJOCPMEGFF(int PGFOAHEHPOH)
	{
		return default(FGDLCHAOFPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1AB0", Offset = "0x5ED0EB0", VA = "0x185ED1AB0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void PKNOODLOHGF(float EOMJAOEKNIN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class DDHPLCOIMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float AJJFFPAOFON = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class BPPJAPKOMGC
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class BLCHLACMIHA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly INBEDPJAMNF DNGKFHKKDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly PKNOODLOHGF EGLKIOCIBPB;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0120", Offset = "0x5ECF520", VA = "0x185ED0120")]
		public BLCHLACMIHA(INBEDPJAMNF DNGKFHKKDKK, PKNOODLOHGF EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5ED00D0", Offset = "0x5ECF4D0", VA = "0x185ED00D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0750", Offset = "0x5ECFB50", VA = "0x185ED0750")]
	internal static bool BDANFBDMFHM(float ANJGLCCJFPO, float ABBMKKCGFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4ABB240", Offset = "0x4ABA640", VA = "0x184ABB240")]
	internal static float OAGJHAMIPIO(float ANJGLCCJFPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5ED07D0", Offset = "0x5ECFBD0", VA = "0x185ED07D0")]
	public static IDisposable IAIJLPGEFDP(this INBEDPJAMNF DNGKFHKKDKK, PKNOODLOHGF EGLKIOCIBPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class FNGBJBALFEM : INBEDPJAMNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float EOMJAOEKNIN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float DCAMLIOEDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x116A3A0", Offset = "0x11697A0", VA = "0x18116A3A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED25C0", Offset = "0x5ED19C0", VA = "0x185ED25C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PKNOODLOHGF AKNFCFMMGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2680", Offset = "0x5ED1A80", VA = "0x185ED2680", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2520", Offset = "0x5ED1920", VA = "0x185ED2520", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FNGBJBALFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class AKHPNPEECCO
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF970", Offset = "0x5ECED70", VA = "0x185ECF970")]
	[NotNull]
	public static byte[] FFIDEGEGPEJ(this PHCEFBJKCFG AFCAOBGBALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF900", Offset = "0x5ECED00", VA = "0x185ECF900")]
	[NotNull]
	public static byte[] FFIDEGEGPEJ(this PHCEFBJKCFG AFCAOBGBALN, HashAlgorithmName DFKFJNBOBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBF0", Offset = "0x5ECEFF0", VA = "0x185ECFBF0")]
	public static bool KPOEGGJODHA([CanBeNull] this PHCEFBJKCFG AFCAOBGBALN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA50", Offset = "0x5ECEE50", VA = "0x185ECFA50")]
	public static bool KPOEGGJODHA([CanBeNull] this PHCEFBJKCFG AFCAOBGBALN, out string DNNOOMDNIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF9E0", Offset = "0x5ECEDE0", VA = "0x185ECF9E0")]
	private static string JKCMCFMFENP([CanBeNull] byte[] OGILIIFBKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD80", Offset = "0x5ECF180", VA = "0x185ECFD80")]
	private static bool OHNLNPACPJL([NotNull] PHCEFBJKCFG AFCAOBGBALN, [CanBeNull] out byte[] DMEPEHHJAMC, [CanBeNull] out byte[] MEMOCAONPHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class LONCFFPELKB
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6640", Offset = "0x5ED5A40", VA = "0x185ED6640")]
	[NotNull]
	public static byte[] FFIDEGEGPEJ(this PPFHFHJJFGO DCEJFGKKCEN, byte[] JLAAKGNEOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6680", Offset = "0x5ED5A80", VA = "0x185ED6680")]
	[NotNull]
	public static byte[] FFIDEGEGPEJ(this PPFHFHJJFGO DCEJFGKKCEN, HashAlgorithmName DFKFJNBOBBD, byte[] JLAAKGNEOEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface PPFHFHJJFGO
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash GKJFFLLHHJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface PHCEFBJKCFG : PPFHFHJJFGO
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] NGIBNCOEIIH
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
	byte[] FIAMCLDKNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object FFCPGCKDEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class GNPOJCLKOJA
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class FEGBAIGLCNK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED20A0", Offset = "0x5ED14A0", VA = "0x185ED20A0")]
		public FEGBAIGLCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2040", Offset = "0x5ED1440", VA = "0x185ED2040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte LDFDMGKGELE = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte EFCMKKLCILE = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> IHABPPEDIJN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool MOFCMJGNFJO;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3919A80", Offset = "0x3918E80", VA = "0x183919A80")]
	[Conditional("UNITY_EDITOR")]
	private static void HKBJKHBEOAH<T>(params T[] AAJKIEPLNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED38E0", Offset = "0x5ED2CE0", VA = "0x185ED38E0")]
	public static IDisposable LNMJKJINFDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3200", Offset = "0x5ED2600", VA = "0x185ED3200")]
	public static void IBJHMDOFIMK(this IncrementalHash GDMNCPGDMLE, [CanBeNull] GameObject MGDBDEJKIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3919D70", Offset = "0x3919170", VA = "0x183919D70")]
	public static void IBJHMDOFIMK<T>(this IncrementalHash GDMNCPGDMLE, [CanBeNull] T NDJEINDKPBB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x391A530", Offset = "0x3919930", VA = "0x18391A530")]
	public static void MEEEPBLNBIM<T>(this IncrementalHash GDMNCPGDMLE, [CanBeNull] T DCEJFGKKCEN) where T : PPFHFHJJFGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3919620", Offset = "0x3918A20", VA = "0x183919620")]
	public static void BKNMODOIEAL<T>(this IncrementalHash GDMNCPGDMLE, [CanBeNull] IList<T> BJJFAHCNLKA) where T : PPFHFHJJFGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED39E0", Offset = "0x5ED2DE0", VA = "0x185ED39E0")]
	private static bool OFNNDFIDFCC([CanBeNull] PPFHFHJJFGO DCEJFGKKCEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3980", Offset = "0x5ED2D80", VA = "0x185ED3980")]
	public static void NBAMFEBPPCB(this IncrementalHash GKJFFLLHHJJ, [CanBeNull] string LNIPHNBPIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3A70", Offset = "0x5ED2E70", VA = "0x185ED3A70")]
	public static void OIIKLOMEKFA(this IncrementalHash GKJFFLLHHJJ, long FGDALFOFJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED34D0", Offset = "0x5ED28D0", VA = "0x185ED34D0")]
	public static void JKHHNLHMOHK(this IncrementalHash GKJFFLLHHJJ, int HKFDKHLEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3710", Offset = "0x5ED2B10", VA = "0x185ED3710")]
	public static void LJMKIKJCIKC(this IncrementalHash GKJFFLLHHJJ, short BNDOLGDJOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3030", Offset = "0x5ED2430", VA = "0x185ED3030")]
	public static void EOAEMIPPEBK(this IncrementalHash GKJFFLLHHJJ, byte IMGOBKKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3C40", Offset = "0x5ED3040", VA = "0x185ED3C40")]
	public static void PJANJALGEHB(this IncrementalHash GKJFFLLHHJJ, bool NEOOPEGCAPL, bool PLNCLDOPFBN = false, bool NIHICLMAJGJ = false, bool NBOIDKBJBOG = false, bool IFKIOPHBKJH = false, bool HFPHPLLCCKH = false, bool KJKIGHAHBON = false, bool PJHLLFPKHOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3919E40", Offset = "0x3919240", VA = "0x183919E40")]
	public static void LEPDHCNNMAE<T>(this IncrementalHash GKJFFLLHHJJ, T LAPOGAFLENL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED31A0", Offset = "0x5ED25A0", VA = "0x185ED31A0")]
	public static void FOJKGIODKPI(this IncrementalHash GKJFFLLHHJJ, float FHGOPPPMMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3E10", Offset = "0x5ED3210", VA = "0x185ED3E10")]
	public static void PJCFLCLPDCM(this IncrementalHash GKJFFLLHHJJ, double NIAPAKMACEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3460", Offset = "0x5ED2860", VA = "0x185ED3460")]
	public static void JAJJENLDDBA(this IncrementalHash GKJFFLLHHJJ, ulong PFDALAENMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2E10", Offset = "0x5ED2210", VA = "0x185ED2E10")]
	public static void DEBHHCIKEGB(this IncrementalHash GKJFFLLHHJJ, uint FOGKEDGIKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED36A0", Offset = "0x5ED2AA0", VA = "0x185ED36A0")]
	public static void LDIMGBHDDPM(this IncrementalHash GKJFFLLHHJJ, ushort AJNCIAAMGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED32F0", Offset = "0x5ED26F0", VA = "0x185ED32F0")]
	public static void IGBDFOJFENF(this IncrementalHash GKJFFLLHHJJ, Vector3 AKHGDLCGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2E70", Offset = "0x5ED2270", VA = "0x185ED2E70")]
	public static void DEIJADLLNBK(this IncrementalHash GKJFFLLHHJJ, Quaternion CCPEOECILMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FKFGDBANHHG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type GKGDOGCJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string ACDMFLMFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool FLOAANNNHEA;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED24C0", Offset = "0x5ED18C0", VA = "0x185ED24C0")]
	public FKFGDBANHHG(Type PFBHKKNEHJJ, string GGINEAAPBEE, bool DCIGDFAIAIJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class MMPLABMHFKN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED68B0", Offset = "0x5ED5CB0", VA = "0x185ED68B0")]
	public MMPLABMHFKN(string HKDHNKHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6920", Offset = "0x5ED5D20", VA = "0x185ED6920")]
	public MMPLABMHFKN(string HKDHNKHPGDP, Exception LMCHKJEEINM)
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
			[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x683790", Offset = "0x682B90", VA = "0x180683790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int BBOINFMIBOM, int JHCEMKMKLLA]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x36B09C0", Offset = "0x36AFDC0", VA = "0x1836B09C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x36B0A60", Offset = "0x36AFE60", VA = "0x1836B0A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x36B0930", Offset = "0x36AFD30", VA = "0x1836B0930")]
		public Array2D(uint ILNHJCKAKCL, uint LGPCJCBIAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x36B08B0", Offset = "0x36AFCB0", VA = "0x1836B08B0")]
		public void HLOEIBCGJID()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFEA0", Offset = "0x5ECF2A0", VA = "0x185ECFEA0")]
		public Array2DVector3(uint ILNHJCKAKCL, uint LGPCJCBIAHN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class PHEIBDMEIBP
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int KBGGPLJFIEL = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int PKLIKBJDOHB = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class HNGCIAJIBBM<THandle, TValue> : IDisposable where THandle : struct, JHCFGCJIHGF where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> DPAEBOCAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> IHAEBNBEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> GMNHEKOLGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> KNGANDHAAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int MDPBMOEIOHG;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x28DAB20", Offset = "0x28D9F20", VA = "0x1828DAB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x38F4650", Offset = "0x38F3A50", VA = "0x1838F4650")]
	public HNGCIAJIBBM(Action<TValue> KNGANDHAAKJ, [Optional] Func<TValue> GMNHEKOLGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x38F3F00", Offset = "0x38F3300", VA = "0x1838F3F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x38F4170", Offset = "0x38F3570", VA = "0x1838F4170")]
	public THandle GEGOECOOINK()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x38F3F80", Offset = "0x38F3380", VA = "0x1838F3F80")]
	public THandle EIPAABBBFMM(TValue PKODKJLGOIN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x38F4210", Offset = "0x38F3610", VA = "0x1838F4210")]
	public bool GMLJNDAKNDK(THandle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x38F3AD0", Offset = "0x38F2ED0", VA = "0x1838F3AD0")]
	public bool AFFPDBIGLLL(THandle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x38F3E60", Offset = "0x38F3260", VA = "0x1838F3E60")]
	public bool DPPKACEDDDN(THandle IICPGPKAIEH, out TValue PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x38F3E10", Offset = "0x38F3210", VA = "0x1838F3E10")]
	public TValue DPALGOGEJPD(THandle IICPGPKAIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x38F4520", Offset = "0x38F3920", VA = "0x1838F4520")]
	public bool NNJMHAAKOAN(THandle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x38F3CA0", Offset = "0x38F30A0", VA = "0x1838F3CA0")]
	private THandle CFFDOINPPBF(int PGFOAHEHPOH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x38F3DE0", Offset = "0x38F31E0", VA = "0x1838F3DE0")]
	private TValue DKOCCOGEFLF(int PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x38F3FF0", Offset = "0x38F33F0", VA = "0x1838F3FF0")]
	private void FENPFGCINIO(int PGFOAHEHPOH, in THandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x38F3C50", Offset = "0x38F3050", VA = "0x1838F3C50")]
	private void BBOCDHNDFJI(int PGFOAHEHPOH, in TValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x38F3CD0", Offset = "0x38F30D0", VA = "0x1838F3CD0")]
	private THandle CMIFABEBKGC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x38F3BA0", Offset = "0x38F2FA0", VA = "0x1838F3BA0")]
	private void BAHCMAIBHJD(THandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x38F3C90", Offset = "0x38F3090", VA = "0x1838F3C90")]
	private int BFKMNFCGPCG(int CELCPLLAAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x38F42C0", Offset = "0x38F36C0", VA = "0x1838F42C0")]
	private bool JBGNIEPEDKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6D4640", Offset = "0x6D3A40", VA = "0x1806D4640")]
	private void JCFDHIKFLNI(THandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x38F45D0", Offset = "0x38F39D0", VA = "0x1838F45D0")]
	private bool PBGLCBAFGCC(out THandle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x38F4330", Offset = "0x38F3730", VA = "0x1838F4330")]
	private bool MANFHIPPDFN(out THandle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x38F42D0", Offset = "0x38F36D0", VA = "0x1838F42D0")]
	private void JPJPCOPMMJE(THandle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x38F4400", Offset = "0x38F3800", VA = "0x1838F4400")]
	private void MFCBEHBLJBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface JHCFGCJIHGF
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int JPEBDLEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int JHIGGPANBBG
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
public interface EFNHAFHOKBP<T> : JHCFGCJIHGF, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CMDIECDKPDK
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xDB3370", Offset = "0xDB2770", VA = "0x180DB3370")]
	public static bool JDKFEMAJJBM<T>(this T IICPGPKAIEH, T BKBGGIICJOJ) where T : struct, JHCFGCJIHGF
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B500", Offset = "0x2E8A900", VA = "0x182E8B500")]
	public static bool COOCIDMCJJO<T>(this T IICPGPKAIEH) where T : struct, JHCFGCJIHGF
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1100", Offset = "0x5ED0500", VA = "0x185ED1100")]
	public static string PFIGCNMHIEP(this JHCFGCJIHGF IICPGPKAIEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KCNCOMINPKI
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum NKHLMFBLEAK : byte
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
	private int GKJFFLLHHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool CNJBKOBODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NKHLMFBLEAK AGOKAPGFDDL;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool FJPLBIJBIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED56E0", Offset = "0x5ED4AE0", VA = "0x185ED56E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool DJPKPMKFOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6470", Offset = "0x5ED5870", VA = "0x185ED6470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED65D0", Offset = "0x5ED59D0", VA = "0x185ED65D0")]
	public KCNCOMINPKI(bool CNJBKOBODBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5C10", Offset = "0x5ED5010", VA = "0x185ED5C10")]
	public void GCOEOHDDCDA(object HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6290", Offset = "0x5ED5690", VA = "0x185ED6290")]
	public void GJINFEJLGEA(int PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED65C0", Offset = "0x5ED59C0", VA = "0x185ED65C0")]
	public void OEEJPIMLELC(uint NMBDFKMJNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED65A0", Offset = "0x5ED59A0", VA = "0x185ED65A0")]
	public void MJJMMOBONNO(bool LGMHBLDEIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED56F0", Offset = "0x5ED4AF0", VA = "0x185ED56F0")]
	public void BCEOFMHKIGC(long CGOHGLIFLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6560", Offset = "0x5ED5960", VA = "0x185ED6560")]
	public void MGBFOJPODOM(ulong LAGPNFIKLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5730", Offset = "0x5ED4B30", VA = "0x185ED5730")]
	public void BICIGMLMFCG(string HOBHCCLLCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED57A0", Offset = "0x5ED4BA0", VA = "0x185ED57A0")]
	public void DFDOAACOCCP(Enum CLHMIOKIOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6340", Offset = "0x5ED5740", VA = "0x185ED6340")]
	public void IPIOKGHMEGH(IList BEOMDPHLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB0150", Offset = "0x2BAF550", VA = "0x182BB0150")]
	public void NINKFIKFFPK<T, U>(Dictionary<T, U> PLKNHFPBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED58A0", Offset = "0x5ED4CA0", VA = "0x185ED58A0")]
	private void EMBIOAEEIFA(IDictionary PLKNHFPBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6480", Offset = "0x5ED5880", VA = "0x185ED6480")]
	public int LLGCEIACMID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED64F0", Offset = "0x5ED58F0", VA = "0x185ED64F0")]
	public short LPAIBBAOPDC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6330", Offset = "0x5ED5730", VA = "0x185ED6330")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5830", Offset = "0x5ED4C30", VA = "0x185ED5830")]
	private void EJFOJHMCLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class KOBONDGPBFD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class OMDJDNKDKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode DMBAJFNFPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode BLENCGKHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public KMJGADINBFI GKBALKCFPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<KMJGADINBFI> CINENCJCDEF;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public OMDJDNKDKAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct KMJGADINBFI : IComparable<KMJGADINBFI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int EEEKCOJKIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant KNLJKDKEPEL;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6980B0", Offset = "0x6974B0", VA = "0x1806980B0")]
		public KMJGADINBFI(int EEEKCOJKIFK, TClaimant KNLJKDKEPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x373BD00", Offset = "0x373B100", VA = "0x18373BD00")]
		public bool FIGKHIPAGJK(in KMJGADINBFI BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x373BD60", Offset = "0x373B160", VA = "0x18373BD60")]
		public bool NMONELJHIJO(in KMJGADINBFI BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x373BCF0", Offset = "0x373B0F0", VA = "0x18373BCF0", Slot = "4")]
		public int CompareTo(KMJGADINBFI BKBGGIICJOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x373BD70", Offset = "0x373B170", VA = "0x18373BD70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum BONGHHKGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EAEBPELEEOE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public global::KOBONDGPBFD<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1429050", Offset = "0x1428450", VA = "0x181429050")]
		[DebuggerHidden]
		public EAEBPELEEOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x28B52E0", Offset = "0x28B46E0", VA = "0x1828B52E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x28B54A0", Offset = "0x28B48A0", VA = "0x1828B54A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x28B53C0", Offset = "0x28B47C0", VA = "0x1828B53C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1412E90", Offset = "0x1412290", VA = "0x181412E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::BPGICHFOONO<OMDJDNKDKAG> JPIKGFPEGEH;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::BPGICHFOONO<List<KMJGADINBFI>> JAKKNJLCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int JEMJABAILMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> EDJDFGBBBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, OMDJDNKDKAG> FOKDBPKBALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private BONGHHKGHFA PNIPPNPIENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LKJHOOBEPGJ(TNode GIGDHNFIFBE);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MMIJJFJIOKI(TNode GIGDHNFIFBE, TClaimant PDOKBPPBDGI, TClaimant NLDOGLCHPCC);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3748A70", Offset = "0x3747E70", VA = "0x183748A70")]
	public KOBONDGPBFD(BONGHHKGHFA PNIPPNPIENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3748420", Offset = "0x3747820", VA = "0x183748420")]
	public void KFPLEHNIPME(TNode GIGDHNFIFBE, TNode GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3747920", Offset = "0x3746D20", VA = "0x183747920")]
	public void COJEPBMNDOO(TClaimant KNLJKDKEPEL, TNode ELMLLFKMNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3747A20", Offset = "0x3746E20", VA = "0x183747A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x37484A0", Offset = "0x37478A0", VA = "0x1837484A0")]
	private void KNCEPGEGHNH(TClaimant KNLJKDKEPEL, TNode MONAOFGCLFC, TNode ELMLLFKMNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3747FA0", Offset = "0x37473A0", VA = "0x183747FA0")]
	private int GBNCLEONIBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3747310", Offset = "0x3746710", VA = "0x183747310")]
	private void BCEIHJPDLCJ(TClaimant KNLJKDKEPEL, TNode KHCCGEJAHHN, TNode IJPMBDNEJAG, int AJFGHNEJODN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3748390", Offset = "0x3747790", VA = "0x183748390")]
	private void JAKKPCDCEDP(KMJGADINBFI LOGEBPJEJGB, OMDJDNKDKAG DOHEFJFBJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3747C80", Offset = "0x3747080", VA = "0x183747C80")]
	private void EEKJALAKHGK(TClaimant KNLJKDKEPEL, TNode KHCCGEJAHHN, TNode IJPMBDNEJAG, int AJFGHNEJODN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3748700", Offset = "0x3747B00", VA = "0x183748700")]
	private void LKDDECKBAAF(KMJGADINBFI LOGEBPJEJGB, TNode GIGDHNFIFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3748810", Offset = "0x3747C10", VA = "0x183748810")]
	private void PLEBKLIDOMJ(KMJGADINBFI LOGEBPJEJGB, OMDJDNKDKAG DOHEFJFBJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3748000", Offset = "0x3747400", VA = "0x183748000")]
	private void GEPKPHEHJKI(OMDJDNKDKAG DOHEFJFBJHP, bool PDEADGFHDGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x37475B0", Offset = "0x37469B0", VA = "0x1837475B0")]
	private void CGMCGOOEMOH(OMDJDNKDKAG DOHEFJFBJHP, TNode GIJFJALMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3747ED0", Offset = "0x37472D0", VA = "0x183747ED0")]
	[IteratorStateMachine(typeof(global::KOBONDGPBFD<, >.EAEBPELEEOE))]
	private IEnumerable<TNode> EPKKMDNMPPL(TNode KHCCGEJAHHN, TNode IJPMBDNEJAG, bool INAEKGOLPBC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x37482D0", Offset = "0x37476D0", VA = "0x1837482D0")]
	private OMDJDNKDKAG IKNIMNCNIBB(TNode GIGDHNFIFBE, TNode BLENCGKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3748140", Offset = "0x3747540", VA = "0x183748140")]
	private OMDJDNKDKAG HMPBAHFIBMI(TNode GIGDHNFIFBE, TNode BLENCGKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3748540", Offset = "0x3747940", VA = "0x183748540")]
	private void LDMFGCEOAHA(OMDJDNKDKAG DOHEFJFBJHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class MABIIAEMKAG<T> : IEnumerable<global::MABIIAEMKAG<T>.DFAKJHHJBDC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct DFAKJHHJBDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T PKODKJLGOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int PGFOAHEHPOH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class JBBABKFCDDB : IEnumerator<DFAKJHHJBDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::MABIIAEMKAG<T> NACECODOGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int PGFOAHEHPOH;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x11295B0", Offset = "0x11289B0", VA = "0x1811295B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public DFAKJHHJBDC GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x29ACF10", Offset = "0x29AC310", VA = "0x1829ACF10", Slot = "4")]
			get
			{
				return default(DFAKJHHJBDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x671060", Offset = "0x670460", VA = "0x180671060")]
		public JBBABKFCDDB(global::MABIIAEMKAG<T> NACECODOGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x29ACDD0", Offset = "0x29AC1D0", VA = "0x1829ACDD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x671050", Offset = "0x670450", VA = "0x180671050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x893BC0", Offset = "0x892FC0", VA = "0x180893BC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct JIJEDIFPLHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool NKHGHKNJBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T PKODKJLGOIN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int MLJMJAEEHIE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> HLCHJIIOOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private JIJEDIFPLHO[] JKEGDCCDFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int FHAGBPJOEDC;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int OBJNKKDPPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x68DD90", Offset = "0x68D190", VA = "0x18068DD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x83FEB0", Offset = "0x83F2B0", VA = "0x18083FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3EEEDC0", Offset = "0x3EEE1C0", VA = "0x183EEEDC0")]
	public MABIIAEMKAG(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3EEEEA0", Offset = "0x3EEE2A0", VA = "0x183EEEEA0")]
	public MABIIAEMKAG(DFAKJHHJBDC[] GIADFAEDDFF, bool IBJNOIALHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDDB0", Offset = "0x3EED1B0", VA = "0x183EEDDB0")]
	public int GNOGFIMBELD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE000", Offset = "0x3EED400", VA = "0x183EEE000")]
	private int JAOECMHBLCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDC50", Offset = "0x3EED050", VA = "0x183EEDC50", Slot = "6")]
	protected virtual uint EPMJLGCCDOI(uint GKJFFLLHHJJ, T PKODKJLGOIN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDF90", Offset = "0x3EED390", VA = "0x183EEDF90")]
	public bool HOPHPGLOGLK(T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3EED920", Offset = "0x3EECD20", VA = "0x183EED920")]
	public bool AKNEIINGFJH(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3EEEBC0", Offset = "0x3EEDFC0", VA = "0x183EEEBC0")]
	public bool OOGLABKJNAC(Func<T, bool> BIGIMFNMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEEC90", Offset = "0x3EEE090", VA = "0x183EEEC90")]
	public int PHAHDKGGEAC(T PKODKJLGOIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3EED9C0", Offset = "0x3EECDC0", VA = "0x183EED9C0")]
	public T DKOCCOGEFLF(int PGFOAHEHPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDF10", Offset = "0x3EED310", VA = "0x183EEDF10")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE7F0", Offset = "0x3EEDBF0", VA = "0x183EEE7F0")]
	public bool LOFLBGEPPLP(T PKODKJLGOIN, bool JOFFNMECHBC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE3F0", Offset = "0x3EED7F0", VA = "0x183EEE3F0")]
	public bool LOFLBGEPPLP(T PKODKJLGOIN, int PGFOAHEHPOH, bool JOFFNMECHBC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDCA0", Offset = "0x3EED0A0", VA = "0x183EEDCA0")]
	public bool GMLJNDAKNDK(T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDE20", Offset = "0x3EED220", VA = "0x183EEDE20")]
	public bool GOBFDDIOGIM(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDA80", Offset = "0x3EECE80", VA = "0x183EEDA80")]
	private void EOGFIOIPDJL(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE9D0", Offset = "0x3EEDDD0", VA = "0x183EEE9D0")]
	public DFAKJHHJBDC[] MFPKPKDLKNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDEC0", Offset = "0x3EED2C0", VA = "0x183EEDEC0")]
	private int HAIEOFKNBMD(int CBFHONBGCKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3EEED40", Offset = "0x3EEE140", VA = "0x183EEED40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEED40", Offset = "0x3EEE140", VA = "0x183EEED40", Slot = "4")]
	private IEnumerator<DFAKJHHJBDC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HHNPIEMJHGK<Handle> where Handle : JHCFGCJIHGF, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct OJHHEKBELDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly global::HHNPIEMJHGK<Handle> EDEGACMIJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int PGFOAHEHPOH;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int MDDEJHNIFNO
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x28DC2F0", Offset = "0x28DB6F0", VA = "0x1828DC2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle MCHIOKKILNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x28DB470", Offset = "0x28DA870", VA = "0x1828DB470")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x28DC4F0", Offset = "0x28DB8F0", VA = "0x1828DC4F0")]
		public OJHHEKBELDK(global::HHNPIEMJHGK<Handle> EDEGACMIJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x28DB3D0", Offset = "0x28DA7D0", VA = "0x1828DB3D0")]
		public JCEOPLJIBAE AJMCJLMMDDK(in JCEOPLJIBAE HOEKGJHOPIH)
		{
			return default(JCEOPLJIBAE);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x28DB330", Offset = "0x28DA730", VA = "0x1828DB330")]
		public IIDDMEDGCEL AJMCJLMMDDK(in IIDDMEDGCEL HOEKGJHOPIH)
		{
			return default(IIDDMEDGCEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x28DBC70", Offset = "0x28DB070", VA = "0x1828DBC70")]
		public bool LLFPOELOPGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x28DBB30", Offset = "0x28DAF30", VA = "0x1828DBB30")]
		private int HONMGPHFFKF(string HKDHNKHPGDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x28DBA40", Offset = "0x28DAE40", VA = "0x1828DBA40")]
		private Handle EGFHMAFDKAG(string HKDHNKHPGDP)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct JCEOPLJIBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private OJHHEKBELDK NJLFMOEGIBD;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x29AD570", Offset = "0x29AC970", VA = "0x1829AD570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1420A10", Offset = "0x141FE10", VA = "0x181420A10")]
		public JCEOPLJIBAE(global::HHNPIEMJHGK<Handle> EDEGACMIJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x14209D0", Offset = "0x141FDD0", VA = "0x1814209D0")]
		public bool LLFPOELOPGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x29AD5F0", Offset = "0x29AC9F0", VA = "0x1829AD5F0")]
		public JCEOPLJIBAE IEHFBKOKLDF()
		{
			return default(JCEOPLJIBAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct IIDDMEDGCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private OJHHEKBELDK NJLFMOEGIBD;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle GCHJDDAOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x14207D0", Offset = "0x141FBD0", VA = "0x1814207D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1420A10", Offset = "0x141FE10", VA = "0x181420A10")]
		public IIDDMEDGCEL(global::HHNPIEMJHGK<Handle> EDEGACMIJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x14209D0", Offset = "0x141FDD0", VA = "0x1814209D0")]
		public bool LLFPOELOPGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1420890", Offset = "0x141FC90", VA = "0x181420890")]
		public IIDDMEDGCEL IEHFBKOKLDF()
		{
			return default(IIDDMEDGCEL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> KMOIFIBHFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> PPNPHHCGJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int LPJNKGKCLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int IJAGPKJENPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool GGNKMEFFHGA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int BOODKFKIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3EC0", Offset = "0x2DA32C0", VA = "0x182DA3EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int BEHJBCPKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CMEDBHDAJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JCEOPLJIBAE LKJOKMFHFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1250", Offset = "0x2DA0650", VA = "0x182DA1250")]
		get
		{
			return default(JCEOPLJIBAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IIDDMEDGCEL NKLBHCLHCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2DA0CF0", Offset = "0x2DA00F0", VA = "0x182DA0CF0")]
		get
		{
			return default(IIDDMEDGCEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3F40", Offset = "0x2DA3340", VA = "0x182DA3F40")]
	public HHNPIEMJHGK(int LKKLMPINBBK, Allocator NHNCCHNPCJI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0AB0", Offset = "0x2D9FEB0", VA = "0x182DA0AB0")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1C7D9D0", Offset = "0x1C7CDD0", VA = "0x181C7D9D0")]
	public static int BFKMNFCGPCG(int CJJLCOOAFHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2BA0", Offset = "0x2DA1FA0", VA = "0x182DA2BA0")]
	public static bool MDPLBCOMFEF(int CJJLCOOAFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA15B0", Offset = "0x2DA09B0", VA = "0x182DA15B0")]
	public static bool FKCCKBNNKBP(int CJJLCOOAFHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1800", Offset = "0x2DA0C00", VA = "0x182DA1800")]
	public bool GGBPKMIFADK(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2160", Offset = "0x2DA1560", VA = "0x182DA2160")]
	public bool JJBDMAOCNBG(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2BB0", Offset = "0x2DA1FB0", VA = "0x182DA2BB0")]
	public bool MKFJOFCDGEM(Handle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA36B0", Offset = "0x2DA2AB0", VA = "0x182DA36B0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void ODJEFGMNAMH(Handle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA80", Offset = "0x2D9EE80", VA = "0x182D9FA80")]
	public Handle AAACHIKBEIL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FDC0", Offset = "0x2D9F1C0", VA = "0x182D9FDC0")]
	public void AEAPADHHFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0E10", Offset = "0x2DA0210", VA = "0x182DA0E10")]
	public void CJFGCAGMNBN(Handle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1EA0", Offset = "0x2DA12A0", VA = "0x182DA1EA0")]
	public bool INGKFOEFKPP(Handle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80")]
	private bool BCONFGDOMOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2DA14F0", Offset = "0x2DA08F0", VA = "0x182DA14F0")]
	private bool EGCGJFOHOIC(int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2DA25E0", Offset = "0x2DA19E0", VA = "0x182DA25E0")]
	private void LMAMGPNBMEP(out int PGFOAHEHPOH, out int CELCPLLAAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1CA0", Offset = "0x2DA10A0", VA = "0x182DA1CA0")]
	private void IMNNLFGEBKC(Handle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2DA13E0", Offset = "0x2DA07E0", VA = "0x182DA13E0")]
	private void DOCDICIJCBL(int PGFOAHEHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2DA10F0", Offset = "0x2DA04F0", VA = "0x182DA10F0")]
	private bool DAOANJKHLKJ(out int PGFOAHEHPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3DA0", Offset = "0x2DA31A0", VA = "0x182DA3DA0")]
	private static Handle PBONAKGPFJJ(int PGFOAHEHPOH, int CELCPLLAAGH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct PHGCLLNIMJB<Handle, T> where Handle : JHCFGCJIHGF, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private global::HHNPIEMJHGK<Handle> NNDFAMMODGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private T[] KBEEBIHEOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Action<T> HCKKLCMCLHB;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool EIEEJMIIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x35086F0", Offset = "0x3507AF0", VA = "0x1835086F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int BOODKFKIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x350AAE0", Offset = "0x3509EE0", VA = "0x18350AAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3509670", Offset = "0x3508A70", VA = "0x183509670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3508530", Offset = "0x3507930", VA = "0x183508530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x350AE20", Offset = "0x350A220", VA = "0x18350AE20")]
	public PHGCLLNIMJB(int LKKLMPINBBK, [Optional] Action<T> HCKKLCMCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3508410", Offset = "0x3507810", VA = "0x183508410")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x350A9D0", Offset = "0x3509DD0", VA = "0x18350A9D0")]
	public bool MKFJOFCDGEM(Handle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void ODJEFGMNAMH(Handle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3508720", Offset = "0x3507B20", VA = "0x183508720")]
	public T DPALGOGEJPD(Handle IICPGPKAIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3508890", Offset = "0x3507C90", VA = "0x183508890")]
	public bool DPPKACEDDDN(Handle IICPGPKAIEH, out T HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3509DC0", Offset = "0x35091C0", VA = "0x183509DC0")]
	public void JKDFMHKJMMK(Handle IICPGPKAIEH, T EBCEMLJOIBA, out T IBKNAIEDMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3509E60", Offset = "0x3509260", VA = "0x183509E60")]
	public void JKDFMHKJMMK(Handle IICPGPKAIEH, T EBCEMLJOIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x35090C0", Offset = "0x35084C0", VA = "0x1835090C0")]
	public bool FCLBPALBBFJ(Handle IICPGPKAIEH, T EBCEMLJOIBA, out T IBKNAIEDMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3509590", Offset = "0x3508990", VA = "0x183509590")]
	public bool FCLBPALBBFJ(Handle IICPGPKAIEH, T EBCEMLJOIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3508D00", Offset = "0x3508100", VA = "0x183508D00")]
	public Handle EIPAABBBFMM(T HKFNIHLBEHC)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3507C60", Offset = "0x3507060", VA = "0x183507C60")]
	public void AEMHLDLFBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x35097B0", Offset = "0x3508BB0", VA = "0x1835097B0")]
	public void GMLJNDAKNDK(Handle IICPGPKAIEH, out T IBKNAIEDMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3509C90", Offset = "0x3509090", VA = "0x183509C90")]
	public void GMLJNDAKNDK(Handle IICPGPKAIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x350A720", Offset = "0x3509B20", VA = "0x18350A720")]
	public bool LDNKNOBGMME(Handle IICPGPKAIEH, out T IBKNAIEDMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x350A640", Offset = "0x3509A40", VA = "0x18350A640")]
	public bool LDNKNOBGMME(Handle IICPGPKAIEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3509D60", Offset = "0x3509160", VA = "0x183509D60")]
	private T GOBFDDIOGIM(int PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3508620", Offset = "0x3507A20", VA = "0x183508620")]
	private void CKEMHCIPNNP(int DKLCIPBCDOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class BPGICHFOONO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<T> EDEGACMIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<T> CFJDPAEJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly int ICMNMCNDMLK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int AIHKIGDKAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2177FC0", Offset = "0x21773C0", VA = "0x182177FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int FELKPBADODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x21778D0", Offset = "0x2176CD0", VA = "0x1821778D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2177A80", Offset = "0x2176E80", VA = "0x182177A80")]
	public static global::BPGICHFOONO<T> ENDHAMMGHHH(int OIKPPNLJGJL = 0, int ICMNMCNDMLK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2177E20", Offset = "0x2177220", VA = "0x182177E20")]
	public static global::BPGICHFOONO<T> JBMAFMNJPMH(int OIKPPNLJGJL = 0, int ICMNMCNDMLK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2178200", Offset = "0x2177600", VA = "0x182178200")]
	public BPGICHFOONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2178070", Offset = "0x2177470", VA = "0x182178070")]
	public BPGICHFOONO(int OIKPPNLJGJL, int ICMNMCNDMLK = int.MaxValue, bool JMGLMIJNOMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2177D10", Offset = "0x2177110", VA = "0x182177D10")]
	public T JBFMKBNAENB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2177820", Offset = "0x2176C20", VA = "0x182177820")]
	public void AEPKJBPFIKJ(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2177EF0", Offset = "0x21772F0", VA = "0x182177EF0")]
	private void KNCNKAJIFMC(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2177B50", Offset = "0x2176F50", VA = "0x182177B50")]
	private void EPCIBCNMKJN(T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2177FF0", Offset = "0x21773F0", VA = "0x182177FF0")]
	[Conditional("DEBUG_BUILD")]
	private void PHCNFIALEDK(T MBLKPLEFKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2177900", Offset = "0x2176D00", VA = "0x182177900")]
	[Conditional("DEBUG_BUILD")]
	private void DJNJBIEKCPI(T MBLKPLEFKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2177990", Offset = "0x2176D90", VA = "0x182177990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2177B70", Offset = "0x2176F70", VA = "0x182177B70")]
	private void GDAJMKFDMJB(IEnumerable<T> IHAEBNBEECB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class ALJFGBKLLPL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private Dictionary<int, T> PDBGMNIGGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T MIHKJPEIGOM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T DGDEFANKNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x68D140", Offset = "0x68C540", VA = "0x18068D140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool CBHGBDBKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x30F4E80", Offset = "0x30F4280", VA = "0x1830F4E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x30F4EC0", Offset = "0x30F42C0", VA = "0x1830F4EC0")]
	public bool ADHCGEPJHIK(T PKODKJLGOIN, int EEEKCOJKIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x30F5370", Offset = "0x30F4770", VA = "0x1830F5370")]
	public bool BCFLENEHLCD(int EEEKCOJKIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x30F4F80", Offset = "0x30F4380", VA = "0x1830F4F80")]
	public T AGDDCJNPLBC(int ICDOKELMCNI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x30F5570", Offset = "0x30F4970", VA = "0x1830F5570")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x30F54E0", Offset = "0x30F48E0", VA = "0x1830F54E0")]
	private bool HCLCDPGCIHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x30F55D0", Offset = "0x30F49D0", VA = "0x1830F55D0")]
	public bool MLNCJCFKCNK(int EEEKCOJKIFK, out T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x30F5600", Offset = "0x30F4A00", VA = "0x1830F5600")]
	public ALJFGBKLLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class JICPCAJHANK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct HCEALHNOBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T ECFALLCDCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int DFAOABFOMNG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly List<HCEALHNOBEM> BJLNKAOCJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T AAOFGBBPALJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x141C1C0", Offset = "0x141B5C0", VA = "0x18141C1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F620", Offset = "0x2D1EA20", VA = "0x182D1F620")]
	public bool OOGLABKJNAC(T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F1D0", Offset = "0x2D1E5D0", VA = "0x182D1F1D0")]
	public void EIPAABBBFMM(T PKODKJLGOIN, int EEEKCOJKIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F270", Offset = "0x2D1E670", VA = "0x182D1F270")]
	public bool GMLJNDAKNDK(T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F390", Offset = "0x2D1E790", VA = "0x182D1F390")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F160", Offset = "0x2D1E560", VA = "0x182D1F160")]
	public T DDPOPKMMPMA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F5B0", Offset = "0x2D1E9B0", VA = "0x182D1F5B0")]
	public T ODJGJPBKGGF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F3F0", Offset = "0x2D1E7F0", VA = "0x182D1F3F0")]
	private void HMNJPLJKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F830", Offset = "0x2D1EC30", VA = "0x182D1F830")]
	public JICPCAJHANK()
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
		[GCACDPGGFIJ(HNCKKAEODPP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5ED73A0", Offset = "0x5ED67A0", VA = "0x185ED73A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7730", Offset = "0x5ED6B30", VA = "0x185ED7730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5ED75B0", Offset = "0x5ED69B0", VA = "0x185ED75B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7890", Offset = "0x5ED6C90", VA = "0x185ED7890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5ED72C0", Offset = "0x5ED66C0", VA = "0x185ED72C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7650", Offset = "0x5ED6A50", VA = "0x185ED7650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x5ED74D0", Offset = "0x5ED68D0", VA = "0x185ED74D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7270", Offset = "0x5ED6670", VA = "0x185ED7270")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface ACFCAKLDEOH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : ACFCAKLDEOH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B47810", Offset = "0x2B46C10", VA = "0x182B47810", Slot = "4")]
		public virtual T BDNMPFOCBOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class HCFBDNKNOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<byte, FOCOJJLJPBB> FPAKIGICJFA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FOCOJJLJPBB CHJNKBLFENL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GINAMEDFEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x21A5290", Offset = "0x21A4690", VA = "0x1821A5290")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6B6CD0", Offset = "0x6B60D0", VA = "0x1806B6CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 FNOEIIBAAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1803030", Offset = "0x1802430", VA = "0x181803030")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x15E0860", Offset = "0x15DFC60", VA = "0x1815E0860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 HFFMBILPKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4120", Offset = "0x5ED3520", VA = "0x185ED4120")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x14C5510", Offset = "0x14C4910", VA = "0x1814C5510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int JCKMJOLAPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x66D0E0", Offset = "0x66C4E0", VA = "0x18066D0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D4640", Offset = "0x6D3A40", VA = "0x1806D4640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4820", Offset = "0x5ED3C20", VA = "0x185ED4820")]
	public HCFBDNKNOOP(Bounds OFIIMMAJMGG, Vector2[] PGMEIJMJFDF, int FKOPDNHJMOD, byte CBFHONBGCKO, float NLKGPGNJCBM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED47A0", Offset = "0x5ED3BA0", VA = "0x185ED47A0")]
	public FOCOJJLJPBB NFCGFMFFLGO(byte PGFOAHEHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED46A0", Offset = "0x5ED3AA0", VA = "0x185ED46A0")]
	public void LKDBFDKNFOP(Vector3 IAMBOGDEHMB, float KBGJECCHOMA, float JFCKLFBAPED, ref List<byte> FHGAFPHPHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4800", Offset = "0x5ED3C00", VA = "0x185ED4800")]
	public void NIMPAOFAIEO(FOCOJJLJPBB.KFMNJOBGEGF LIDHNJOCGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4140", Offset = "0x5ED3540", VA = "0x185ED4140")]
	private FOCOJJLJPBB HIPDGLFNHMM(byte PGFOAHEHPOH, FOCOJJLJPBB.PMHFLHCPMMB DLJKIMJHLPB, FOCOJJLJPBB BLENCGKHIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED42A0", Offset = "0x5ED36A0", VA = "0x185ED42A0")]
	private void JIMGGLDCGPO(FOCOJJLJPBB BLENCGKHIJI, Vector2[] PGMEIJMJFDF, int JNBAJJBMFMA, int GNGCNDDGJDO, int NLHHOCJIMKL, int ILIMMKKMIAI, float NLKGPGNJCBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class FOCOJJLJPBB
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum PMHFLHCPMMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum KFMNJOBGEGF
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
	public byte GDGOIHPFNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 PKKNCAFFFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 OOCCNILBMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 CNONHAIBEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 OMKAIEHBCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public PMHFLHCPMMB ODDNMCPIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public FOCOJJLJPBB MPHEKDGOELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<FOCOJJLJPBB> GFJKLENHOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public bool HJLBHGCAKNJ;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2B20", Offset = "0x5ED1F20", VA = "0x185ED2B20")]
	public FOCOJJLJPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2B40", Offset = "0x5ED1F40", VA = "0x185ED2B40")]
	public FOCOJJLJPBB(byte FBDAFGPAOAL, PMHFLHCPMMB DLJKIMJHLPB, FOCOJJLJPBB BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2A60", Offset = "0x5ED1E60", VA = "0x185ED2A60")]
	public void MNJLDMDAPLM(FOCOJJLJPBB MIJGFFHMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public void NIMPAOFAIEO(int BIBLCKPNEFM, KFMNJOBGEGF LIDHNJOCGIO, int ENEPBIMGPMF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED27B0", Offset = "0x5ED1BB0", VA = "0x185ED27B0")]
	public void LKDBFDKNFOP(List<byte> FHGAFPHPHCE, Vector3 IAMBOGDEHMB, float KBGJECCHOMA, float JFCKLFBAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2760", Offset = "0x5ED1B60", VA = "0x185ED2760")]
	public bool LDDHHCEEBLO(Vector3 EKDILHNEMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2720", Offset = "0x5ED1B20", VA = "0x185ED2720")]
	public bool EKJFEAMFPEE(Vector3 EKDILHNEMKK, float NDLOHJOFJCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class ELHBPGFCAPC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly Dictionary<T, object> DLAEIHKBOLM;

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x23DD410", Offset = "0x23DC810", VA = "0x1823DD410")]
	public bool FANPDIHIOOA(T EKGGDBBOLJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2FCFF00", Offset = "0x2FCF300", VA = "0x182FCFF00")]
	public bool FANPDIHIOOA(T EKGGDBBOLJG, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FCFEA0", Offset = "0x2FCF2A0", VA = "0x182FCFEA0")]
	public bool FANPDIHIOOA(T EKGGDBBOLJG, object PFJMMABJIDH, out object LIMEAFOCKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2FCFFE0", Offset = "0x2FCF3E0", VA = "0x182FCFFE0")]
	public bool KHKMINJLNIH(T EKGGDBBOLJG, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2FD00E0", Offset = "0x2FCF4E0", VA = "0x182FD00E0")]
	public bool NIPKCFGCANH(T EKGGDBBOLJG, object PFJMMABJIDH, out object LIMEAFOCKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0020", Offset = "0x2FCF420", VA = "0x182FD0020")]
	public bool KHKMINJLNIH(T EKGGDBBOLJG, object PFJMMABJIDH, out object LIMEAFOCKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2FD00B0", Offset = "0x2FCF4B0", VA = "0x182FD00B0")]
	public void NEOMEDIKJAK(T EKGGDBBOLJG, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2FCFF40", Offset = "0x2FCF340", VA = "0x182FCFF40")]
	public void IMDGLKIGHFD(T EKGGDBBOLJG, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0120", Offset = "0x2FCF520", VA = "0x182FD0120")]
	public ELHBPGFCAPC()
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
		public struct BDBGKJGDEDL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> BEOMDPHLMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool EPMLKGCAHKP;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8CD970", Offset = "0x8CCD70", VA = "0x1808CD970")]
			public BDBGKJGDEDL(List<Component> BEOMDPHLMGK, bool EPMLKGCAHKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2CAB920", Offset = "0x2CAAD20", VA = "0x182CAB920")]
			public JPHBKCBBIHI<T> IEHFBKOKLDF()
			{
				return default(JPHBKCBBIHI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2CAB990", Offset = "0x2CAAD90", VA = "0x182CAB990", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2CAB990", Offset = "0x2CAAD90", VA = "0x182CAB990", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct JPHBKCBBIHI<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> BEOMDPHLMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool EPMLKGCAHKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private int PGFOAHEHPOH;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T GCHJDDAOGHB
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x2D2AE00", Offset = "0x2D2A200", VA = "0x182D2AE00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x2D2AD90", Offset = "0x2D2A190", VA = "0x182D2AD90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2D2ADD0", Offset = "0x2D2A1D0", VA = "0x182D2ADD0")]
			public JPHBKCBBIHI(List<Component> BEOMDPHLMGK, bool EPMLKGCAHKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x2D2ACC0", Offset = "0x2D2A0C0", VA = "0x182D2ACC0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2D2ACD0", Offset = "0x2D2A0D0", VA = "0x182D2ACD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x2D2AD80", Offset = "0x2D2A180", VA = "0x182D2AD80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5ED95E0", Offset = "0x5ED89E0", VA = "0x185ED95E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED95A0", Offset = "0x5ED89A0", VA = "0x185ED95A0")]
		public ToolHierarchyCache(GameObject LJDNPPGJLHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9000", Offset = "0x5ED8400", VA = "0x185ED9000")]
		private void PAICICMJOCE(GameObject LJDNPPGJLHN, bool LGPEEBCPBMM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9160", Offset = "0x5ED8560", VA = "0x185ED9160")]
		public static void PAICICMJOCE(GameObject LJDNPPGJLHN, ref ToolHierarchyCache PELJFJMLMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D50", Offset = "0x5ED8150", VA = "0x185ED8D50")]
		public void BJIBKFHGLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F30", Offset = "0x5ED8330", VA = "0x185ED8F30")]
		public void KGCIEDGGJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x24BE630", Offset = "0x24BDA30", VA = "0x1824BE630")]
		public void PCFEMFEBJPH<T>(Action<T> PADKGNIPPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8DE0", Offset = "0x5ED81E0", VA = "0x185ED8DE0")]
		public Component FDGJNAKGIIP(Type NLAFPPIOFPG, bool EPMLKGCAHKP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x24BE4E0", Offset = "0x24BD8E0", VA = "0x1824BE4E0")]
		public T FDGJNAKGIIP<T>(bool EPMLKGCAHKP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F80", Offset = "0x5ED8380", VA = "0x185ED8F80")]
		public BDBGKJGDEDL<Component> MIHANNICDEA(Type NLAFPPIOFPG, bool EPMLKGCAHKP = false)
		{
			return default(BDBGKJGDEDL<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x24BE560", Offset = "0x24BD960", VA = "0x1824BE560")]
		public BDBGKJGDEDL<T> MIHANNICDEA<T>(bool EPMLKGCAHKP = false) where T : class
		{
			return default(BDBGKJGDEDL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED91F0", Offset = "0x5ED85F0", VA = "0x185ED91F0")]
		public List<Component> PLKCBPODFMB(Type NLAFPPIOFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D60", Offset = "0x5ED8160", VA = "0x185ED8D60", Slot = "4")]
		public bool Equals(ToolHierarchyCache HHAEMEGNPGJ, ToolHierarchyCache ACCHMFPFGHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8EB0", Offset = "0x5ED82B0", VA = "0x185ED8EB0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HKFNIHLBEHC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class LIAJJBBAKLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int OIKPPNLJGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int GCFLMDHCFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private List<T> FAFJGGGCDPH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2177FC0", Offset = "0x21773C0", VA = "0x182177FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T OLBOBMFONMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x23DD040", Offset = "0x23DC440", VA = "0x1823DD040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T IFGFBAMHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x23DCB80", Offset = "0x23DBF80", VA = "0x1823DCB80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T LMJAEMKNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x23DCC70", Offset = "0x23DC070", VA = "0x1823DCC70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x23DD0D0", Offset = "0x23DC4D0", VA = "0x1823DD0D0")]
	public LIAJJBBAKLB(int OIKPPNLJGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x23DCCD0", Offset = "0x23DC0D0", VA = "0x1823DCCD0")]
	public void EIPAABBBFMM(T KHAIDOFCDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x23DCE80", Offset = "0x23DC280", VA = "0x1823DCE80")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x23DCF20", Offset = "0x23DC320", VA = "0x1823DCF20")]
	public void JJILHNCJPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x23DCEC0", Offset = "0x23DC2C0", VA = "0x1823DCEC0")]
	public void IEEPKOGMKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x23DCF10", Offset = "0x23DC310", VA = "0x1823DCF10")]
	public void JEJHCIBOPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class BNCJFNCAOHK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool GGFBNEDFJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Action PADKGNIPPLI;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static BNCJFNCAOHK KGMIMNHBLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED06D0", Offset = "0x5ECFAD0", VA = "0x185ED06D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ENFHMMFAACB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x822810", Offset = "0x821C10", VA = "0x180822810")]
	public BNCJFNCAOHK(Action PADKGNIPPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED06B0", Offset = "0x5ECFAB0", VA = "0x185ED06B0")]
	public void DACLICHPPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED06B0", Offset = "0x5ECFAB0", VA = "0x185ED06B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class BCMPNMBMMIH
{
	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFF00", Offset = "0x5ECF300", VA = "0x185ECFF00")]
	public static void COOBOJHINND(BMHJPGJHMEO CCENAAIKJJK, string NEPIBIGEODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public static void COOBOJHINND(IEnumerable<object> BDPOLJDOFBF, string NEPIBIGEODL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GDPDEPPBCBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct FPICABLCEMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int DFAOABFOMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public T ECFALLCDCAA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly Dictionary<object, FPICABLCEMI> PDBGMNIGGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly EqualityComparer<T> LHDJBJIDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private T MIHKJPEIGOM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T DGDEFANKNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xCC7120", Offset = "0xCC6520", VA = "0x180CC7120", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x24A4670", Offset = "0x24A3A70", VA = "0x1824A4670", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool CBHGBDBKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3244A20", Offset = "0x3243E20", VA = "0x183244A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object BCJCFBDOALK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3244A50", Offset = "0x3243E50", VA = "0x183244A50")]
	public bool ADHCGEPJHIK(T PKODKJLGOIN, object PFJMMABJIDH, int EEEKCOJKIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x32452C0", Offset = "0x32446C0", VA = "0x1832452C0")]
	public bool BCFLENEHLCD(object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x32497C0", Offset = "0x3248BC0", VA = "0x1832497C0")]
	public bool MLNCJCFKCNK(object PFJMMABJIDH, out T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2D90750", Offset = "0x2D8FB50", VA = "0x182D90750")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x3246C70", Offset = "0x3246070", VA = "0x183246C70")]
	private bool HCLCDPGCIHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3249A60", Offset = "0x3248E60", VA = "0x183249A60")]
	public GDPDEPPBCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class ILIOCLIHDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Dictionary<object, float> PDBGMNIGGFD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PIGGLAAPMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x116A3A0", Offset = "0x11697A0", VA = "0x18116A3A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xF3F260", Offset = "0xF3E660", VA = "0x180F3F260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4D10", Offset = "0x5ED4110", VA = "0x185ED4D10")]
	public void ADHCGEPJHIK(float PKODKJLGOIN, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4D80", Offset = "0x5ED4180", VA = "0x185ED4D80")]
	public void BCFLENEHLCD(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4DF0", Offset = "0x5ED41F0", VA = "0x185ED4DF0")]
	private void JOPCFNMMDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4F10", Offset = "0x5ED4310", VA = "0x185ED4F10")]
	public ILIOCLIHDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class HAPIHBLEHPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public readonly string PBBHHKEJOCD;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x66DF40", Offset = "0x66D340", VA = "0x18066DF40")]
	public HAPIHBLEHPF(string HMEMKPEGKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3FD0", Offset = "0x5ED33D0", VA = "0x185ED3FD0")]
	public HAPIHBLEHPF(UnityEngine.Object HJLDHFIECIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3F80", Offset = "0x5ED3380", VA = "0x185ED3F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class BMHJPGJHMEO
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OFCLGPBCLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public OFCLGPBCLMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5ED69F0", Offset = "0x5ED5DF0", VA = "0x185ED69F0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private HashSet<object> BDPOLJDOFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int CDDGFKFGAGG;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> GIMIFJJJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED03B0", Offset = "0x5ECF7B0", VA = "0x185ED03B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool FMEIEIMPHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0480", Offset = "0x5ECF880", VA = "0x185ED0480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0220", Offset = "0x5ECF620", VA = "0x185ED0220")]
	public bool EIPAABBBFMM(object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0310", Offset = "0x5ECF710", VA = "0x185ED0310")]
	public bool GMLJNDAKNDK(object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0490", Offset = "0x5ECF890", VA = "0x185ED0490")]
	public bool OOGLABKJNAC(object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5ED01B0", Offset = "0x5ECF5B0", VA = "0x185ED01B0")]
	public void DDFJMOEFNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5ED04F0", Offset = "0x5ECF8F0", VA = "0x185ED04F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public BMHJPGJHMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class HMOFNPFCBGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct BJFGBBLADDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float FHDIANDBDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public T ECFALLCDCAA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Dictionary<object, BJFGBBLADDB> PDBGMNIGGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private T HHGFIALMOBB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T ANCLAFDHNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x16AF1F0", Offset = "0x16AE5F0", VA = "0x1816AF1F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x16BDB70", Offset = "0x16BCF70", VA = "0x1816BDB70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object BKAGOHOPJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool CBHGBDBKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x38ED470", Offset = "0x38EC870", VA = "0x1838ED470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x38ED980", Offset = "0x38ECD80", VA = "0x1838ED980")]
	public bool ADHCGEPJHIK(T PKODKJLGOIN, object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x38EDA80", Offset = "0x38ECE80", VA = "0x1838EDA80")]
	public bool BCFLENEHLCD(object PFJMMABJIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2D90750", Offset = "0x2D8FB50", VA = "0x182D90750")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x38EF140", Offset = "0x38EE540", VA = "0x1838EF140")]
	public bool MLNCJCFKCNK(object PFJMMABJIDH, out T PKODKJLGOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x38EDE80", Offset = "0x38ED280", VA = "0x1838EDE80")]
	private bool HCLCDPGCIHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x38EF3B0", Offset = "0x38EE7B0", VA = "0x1838EF3B0")]
	public HMOFNPFCBGC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5ED52E0", Offset = "0x5ED46E0", VA = "0x185ED52E0")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4F90", Offset = "0x5ED4390", VA = "0x185ED4F90")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
