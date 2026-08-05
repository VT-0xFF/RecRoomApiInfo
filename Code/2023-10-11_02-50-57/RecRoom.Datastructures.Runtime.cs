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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class INBCFDPBPIN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public INBCFDPBPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, HOFAIGJKEJN, KOAIMJBJNBM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BOLKJAHMCHK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C4F0", VA = "0x18084D6F0")]
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
	[SerializeField]
	[EKIEDNKDMJF]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[EKIEDNKDMJF]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE460", Offset = "0x5CAD260", VA = "0x185CAE460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE420", Offset = "0x5CAD220", VA = "0x185CAE420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE4A0", Offset = "0x5CAD2A0", VA = "0x185CAE4A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE650", Offset = "0x5CAD450", VA = "0x185CAE650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE5C0", Offset = "0x5CAD3C0", VA = "0x185CAE5C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EE820", Offset = "0x7ED620", VA = "0x1807EE820")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86FE40", Offset = "0x86EC40", VA = "0x18086FE40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE3E0", Offset = "0x5CAD1E0", VA = "0x185CAE3E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE530", Offset = "0x5CAD330", VA = "0x185CAE530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE010", Offset = "0x5CACE10", VA = "0x185CAE010")]
	public void CopyBounds(SavedExtents MFMJJEFODHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE330", Offset = "0x5CAD130", VA = "0x185CAE330")]
	public void SetLocalSpaceBounds(Bounds LPPIDCEBFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A5AF0", Offset = "0x8A48F0", VA = "0x1808A5AF0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE320", Offset = "0x5CAD120", VA = "0x185CAE320")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD7E0", Offset = "0x5CAC5E0", VA = "0x185CAD7E0")]
	private void CPKKMEJHCMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE100", Offset = "0x5CACF00", VA = "0x185CAE100")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD9A0", Offset = "0x5CAC7A0", VA = "0x185CAD9A0")]
	public static void CalculateLocalBoundsFor(GameObject DEGGPBGPMDB, [Out] Bounds LPPIDCEBFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE040", Offset = "0x5CACE40", VA = "0x185CAE040")]
	private static void EILGPOMBHMJ(Bounds JHKDDIMPPGN, Color MFEFOKLBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE350", Offset = "0x5CAD150", VA = "0x185CAE350")]
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
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x761610", Offset = "0x760410", VA = "0x180761610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCBC8F0", Offset = "0xCBB6F0", VA = "0x180CBC8F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2C20", Offset = "0x3FF1A20", VA = "0x183FF2C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public virtual void OIDJPINKPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
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
	[INBCFDPBPIN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2800", Offset = "0x3FF1600", VA = "0x183FF2800", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FF14A0", Offset = "0x3FF02A0", VA = "0x183FF14A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2B50", Offset = "0x3FF1950", VA = "0x183FF2B50")]
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
	private sealed class GBLDCPEKIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GBLDCPEKIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34997B0", Offset = "0x34985B0", VA = "0x1834997B0")]
		internal int AMDHBEKDEOJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[INBCFDPBPIN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3091350", Offset = "0x3090150", VA = "0x183091350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30913A0", Offset = "0x30901A0", VA = "0x1830913A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3091250", Offset = "0x3090050", VA = "0x183091250", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey JLDFGFPAIIN]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30912F0", Offset = "0x30900F0", VA = "0x1830912F0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3091130", Offset = "0x308FF30", VA = "0x183091130", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3090E50", Offset = "0x308FC50", VA = "0x183090E50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30902F0", Offset = "0x308F0F0", VA = "0x1830902F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30901C0", Offset = "0x308EFC0", VA = "0x1830901C0", Slot = "14")]
	protected virtual string DJCLAELEDBP(TKeyVal OGKKGEMHHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3090170", Offset = "0x308EF70", VA = "0x183090170", Slot = "4")]
	public bool ContainsKey(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3090FF0", Offset = "0x308FDF0", VA = "0x183090FF0", Slot = "5")]
	public bool TryGetValue(TKey JLDFGFPAIIN, [Out] TVal GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3090250", Offset = "0x308F050", VA = "0x183090250", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3090250", Offset = "0x308F050", VA = "0x183090250", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3091040", Offset = "0x308FE40", VA = "0x183091040")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IINFFMIDOKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EKMKNOHIPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public EKMKNOHIPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3060DC0", Offset = "0x305FBC0", VA = "0x183060DC0")]
		internal bool MAPDDPLOLIK(INHELDLJPNF<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float ENBDDDIKIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float NDGLMKKOEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<INHELDLJPNF<float, T>> NNFMECCPMCF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HPMPNEPMKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36640A0", Offset = "0x3662EA0", VA = "0x1836640A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3664690", Offset = "0x3663490", VA = "0x183664690")]
	public IINFFMIDOKO(float FHAGDCAPHPM, float NDMPEHFOALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3664420", Offset = "0x3663220", VA = "0x183664420")]
	public bool JDKPENKOFBI(float MGIGPHHIMPB, T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3664110", Offset = "0x3662F10", VA = "0x183664110")]
	public IEnumerable<T> IHHPCFKGJFN(float MGIGPHHIMPB, [Optional] float? NECMPLAPOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3664070", Offset = "0x3662E70", VA = "0x183664070")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36645B0", Offset = "0x36633B0", VA = "0x1836645B0")]
	private void OIFGHOALBAO(float MGIGPHHIMPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class DLHOCEHINLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NPICMICGJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T GMPOHOAMMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float MOIPJLJDBHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GDHKGDHPONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> GMOGKNCGCNH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int JOBEANHOIEB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NPICMICGJJE[] FNIMPMJDPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int FJGHAKOHALJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MGFGHLEKDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA9D060", Offset = "0xA9BE60", VA = "0x180A9D060")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA9D040", Offset = "0xA9BE40", VA = "0x180A9D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D03710", Offset = "0x4D02510", VA = "0x184D03710")]
	public DLHOCEHINLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D03730", Offset = "0x4D02530", VA = "0x184D03730")]
	public DLHOCEHINLN(int MEDHPDICIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D028F0", Offset = "0x4D016F0", VA = "0x184D028F0")]
	public void AAFNAGDLNDC(float MGIGPHHIMPB, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D03230", Offset = "0x4D02030", VA = "0x184D03230")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D029E0", Offset = "0x4D017E0", VA = "0x184D029E0")]
	public bool CPLKPJCEFJD(float DDFMCFEFMFD, float IFIOAPFGBDL, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D03510", Offset = "0x4D02310", VA = "0x184D03510")]
	public bool HGELJMOINOA(float DDFMCFEFMFD, float IFIOAPFGBDL, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D02E60", Offset = "0x4D01C60", VA = "0x184D02E60")]
	public void DGPKDJCBELL(float DDFMCFEFMFD, float IFIOAPFGBDL, List<T> BKOBMCKFFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D029B0", Offset = "0x4D017B0", VA = "0x184D029B0")]
	private int CIFAEIFBFGB(int LPBLCEAFOJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D030F0", Offset = "0x4D01EF0", VA = "0x184D030F0")]
	private void EJMKMKDGPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T INIMIOOLMIA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LCMNAFCGPFN(T GNLEHBFFNFG, float MOEPCGBEMKK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NPAJCFADELA(T KNEDKAAPLCI, T FPBOJHIIPAI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FLFMLCNMFDB(T KNEDKAAPLCI, T FPBOJHIIPAI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HPEKBFNBJEB : DLHOCEHINLN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7718A0", VA = "0x180772AA0", Slot = "4")]
	protected override Vector3 INIMIOOLMIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC9F0", Offset = "0x5CAB7F0", VA = "0x185CAC9F0", Slot = "5")]
	protected override Vector3 LCMNAFCGPFN(Vector3 GNLEHBFFNFG, float MOEPCGBEMKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CACA30", Offset = "0x5CAB830", VA = "0x185CACA30", Slot = "6")]
	protected override Vector3 NPAJCFADELA(Vector3 KNEDKAAPLCI, Vector3 FPBOJHIIPAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC970", Offset = "0x5CAB770", VA = "0x185CAC970", Slot = "7")]
	protected override Vector3 FLFMLCNMFDB(Vector3 KNEDKAAPLCI, Vector3 FPBOJHIIPAI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CACA80", Offset = "0x5CAB880", VA = "0x185CACA80")]
	public HPEKBFNBJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AHOMLGNMHHB
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29B0E90", Offset = "0x29AFC90", VA = "0x1829B0E90")]
	public static INHELDLJPNF<T1, T2> HKJMJGOBNGA<T1, T2>(T1 OGONCHNEMGL, T2 LKMLHMLLBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29B0F10", Offset = "0x29AFD10", VA = "0x1829B0F10")]
	public static LFHNFFCBBKI<T1, T2, T3> HKJMJGOBNGA<T1, T2, T3>(T1 OGONCHNEMGL, T2 LKMLHMLLBBO, T3 MEEMDDFMIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB5B0", Offset = "0x3BAA3B0", VA = "0x183BAB5B0")]
	internal static int JEJOAINBOBA(int EOPNEBAPADK, int NDDOPDMHLJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51AB750", Offset = "0x51AA550", VA = "0x1851AB750")]
	internal static int JEJOAINBOBA(int EOPNEBAPADK, int NDDOPDMHLJN, int MOMHEKOKIMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class INHELDLJPNF<T1, T2> : IComparable<INHELDLJPNF<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 DDGINGMFMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 LGMMOAMLANP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x369A2A0", Offset = "0x36990A0", VA = "0x18369A2A0")]
	public INHELDLJPNF(T1 OGONCHNEMGL, T2 LKMLHMLLBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3698260", Offset = "0x3697060", VA = "0x183698260", Slot = "4")]
	public int CompareTo(INHELDLJPNF<T1, T2> MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3698980", Offset = "0x3697780", VA = "0x183698980", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36995E0", Offset = "0x36983E0", VA = "0x1836995E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x36999F0", Offset = "0x36987F0", VA = "0x1836999F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LFHNFFCBBKI<T1, T2, T3> : IComparable<LFHNFFCBBKI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 DDGINGMFMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 LGMMOAMLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 PBCGICHGJPB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x393EF40", Offset = "0x393DD40", VA = "0x18393EF40")]
	public LFHNFFCBBKI(T1 OGONCHNEMGL, T2 LKMLHMLLBBO, T3 MEEMDDFMIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x393E740", Offset = "0x393D540", VA = "0x18393E740", Slot = "4")]
	public int CompareTo(LFHNFFCBBKI<T1, T2, T3> MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x393E990", Offset = "0x393D790", VA = "0x18393E990", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x393EBD0", Offset = "0x393D9D0", VA = "0x18393EBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x393ED80", Offset = "0x393DB80", VA = "0x18393ED80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E585A0", Offset = "0x1E573A0", VA = "0x181E585A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E585D0", Offset = "0x1E573D0", VA = "0x181E585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HCDLMOMFHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA339B0", Offset = "0xA327B0", VA = "0x180A339B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41F57D0", Offset = "0x41F45D0", VA = "0x1841F57D0")]
	public T OOECJMJAOJP(float MOEPCGBEMKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41F53C0", Offset = "0x41F41C0", VA = "0x1841F53C0")]
	public T AAJHKODHHGJ(float MOEPCGBEMKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LFKDCHLNMLN(T KNEDKAAPLCI, T FPBOJHIIPAI, float MOEPCGBEMKK);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB400", Offset = "0x5CAA200", VA = "0x185CAB400", Slot = "4")]
	protected override float LFKDCHLNMLN(float KNEDKAAPLCI, float FPBOJHIIPAI, float MOEPCGBEMKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB440", Offset = "0x5CAA240", VA = "0x185CAB440")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB66AE0", Offset = "0xB658E0", VA = "0x180B66AE0", Slot = "4")]
	protected override Vector3 LFKDCHLNMLN(Vector3 KNEDKAAPLCI, Vector3 FPBOJHIIPAI, float MOEPCGBEMKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF470", Offset = "0x5CAE270", VA = "0x185CAF470")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAD20", Offset = "0x5CA9B20", VA = "0x185CAAD20", Slot = "4")]
	protected override Color LFKDCHLNMLN(Color KNEDKAAPLCI, Color FPBOJHIIPAI, float MOEPCGBEMKK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CAADE0", Offset = "0x5CA9BE0", VA = "0x185CAADE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MGOKJOGGHHE : EJJGPIEDHBG<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CACEF0", Offset = "0x5CABCF0", VA = "0x185CACEF0")]
	public MGOKJOGGHHE(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CACE80", Offset = "0x5CABC80", VA = "0x185CACE80", Slot = "6")]
	protected override uint NNDONELLJKG(uint BOLKJAHMCHK, string GNLEHBFFNFG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IMJKBMEABLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IMJKBMEABLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FKFEAGADOJA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AOKCLEIDEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int AOHCCHJABDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int EHBNDNAFBJE;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x33EFE30", Offset = "0x33EEC30", VA = "0x1833EFE30")]
	private FKFEAGADOJA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ADKIMFEFDKD, int IDNBKKLCLOP, int NCLNGNKCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33EFD30", Offset = "0x33EEB30", VA = "0x1833EFD30")]
	public static FKFEAGADOJA<T> NPAOPBPEFCO()
	{
		return default(FKFEAGADOJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x33EF150", Offset = "0x33EDF50", VA = "0x1833EF150")]
	public (int, int, Task<T>) JHEPBOBJHFC(int GFCHFCPDOFJ, [Optional] CancellationToken BIBHFGFDEGJ, double MILPBPEIAGI = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x33EFB40", Offset = "0x33EE940", VA = "0x1833EFB40")]
	public void LOONHOLGIMD(int GFCHFCPDOFJ, int NCLNGNKCOBO, [In] T EKOLPKLNMBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MENFNICFCBA
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CACE30", Offset = "0x5CABC30", VA = "0x185CACE30")]
	public static FKFEAGADOJA<LIGKMPLCELA> NPAOPBPEFCO()
	{
		return default(FKFEAGADOJA<LIGKMPLCELA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CACDB0", Offset = "0x5CABBB0", VA = "0x185CACDB0")]
	public static void LOONHOLGIMD([In] this FKFEAGADOJA<LIGKMPLCELA> LNKCIHFCLHG, int GFCHFCPDOFJ, int NCLNGNKCOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class DODDJHOFOCN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> NCNGEHIDPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> JIEIBOBPFND;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F580", Offset = "0x2E9E380", VA = "0x182E9F580", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MGKAFOIHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> PKLFCPDOEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x34A7060", Offset = "0x34A5E60", VA = "0x1834A7060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> JAFLGLCJABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4D201E0", Offset = "0x4D1EFE0", VA = "0x184D201E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4D20180", Offset = "0x4D1EF80", VA = "0x184D20180", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4D20240", Offset = "0x4D1F040", VA = "0x184D20240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4D1F540", Offset = "0x4D1E340", VA = "0x184D1F540")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F590", Offset = "0x4D1E390", VA = "0x184D1F590", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FFB0", Offset = "0x4D1EDB0", VA = "0x184D1FFB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F4A0", Offset = "0x4D1E2A0", VA = "0x184D1F4A0", Slot = "9")]
	public void Add(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F450", Offset = "0x4D1E250", VA = "0x184D1F450", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3688870", Offset = "0x3687670", VA = "0x183688870", Slot = "8")]
	public bool ContainsKey(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F650", Offset = "0x4D1E450", VA = "0x184D1F650", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FF00", Offset = "0x4D1ED00", VA = "0x184D1FF00", Slot = "10")]
	public bool Remove(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FED0", Offset = "0x4D1ECD0", VA = "0x184D1FED0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D20050", Offset = "0x4D1EE50", VA = "0x184D20050", Slot = "11")]
	public bool TryGetValue(TKey JLDFGFPAIIN, [Out] TVal GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F700", Offset = "0x4D1E500", VA = "0x184D1F700", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F680", Offset = "0x4D1E480", VA = "0x184D1F680", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FNIMPMJDPGM, int KOPIDODGMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FCC0", Offset = "0x4D1EAC0", VA = "0x184D1FCC0")]
	public bool PGDPBMGNNCL(TVal JLDFGFPAIIN, [Out] TKey GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FDA0", Offset = "0x4D1EBA0", VA = "0x184D1FDA0")]
	private void PGPLCIHCIME(TKey JLDFGFPAIIN, TVal AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F830", Offset = "0x4D1E630", VA = "0x184D1F830")]
	private void KODKPFNDAKM(TKey JLDFGFPAIIN, TVal AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FAC0", Offset = "0x4D1E8C0", VA = "0x184D1FAC0")]
	private bool NAEDALGPPAE(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4D20090", Offset = "0x4D1EE90", VA = "0x184D20090")]
	public DODDJHOFOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class FCCOOKJJFLK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private FCCOOKJJFLK<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x30EC220", Offset = "0x30EB020", VA = "0x1830EC220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x30ECD50", Offset = "0x30EBB50", VA = "0x1830ECD50")]
		public Enumerator(FCCOOKJJFLK<T> BKOBMCKFFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x30E94E0", Offset = "0x30E82E0", VA = "0x1830E94E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x30EAB80", Offset = "0x30E9980", VA = "0x1830EAB80", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30E80C0", Offset = "0x30E6EC0", VA = "0x1830E80C0")]
		private void CAEEHFBFDDB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] AAGGKIKNJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int KMGLIANDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HGLKCBGIIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KCPGKFKLEJL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x33CF520", Offset = "0x33CE320", VA = "0x1833CF520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x33CE980", Offset = "0x33CD780", VA = "0x1833CE980")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x33CE860", Offset = "0x33CD660", VA = "0x1833CE860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33CF7C0", Offset = "0x33CE5C0", VA = "0x1833CF7C0")]
	public FCCOOKJJFLK(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x33CE650", Offset = "0x33CD450", VA = "0x1833CE650")]
	public void AAFNAGDLNDC(T MOEPCGBEMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33CEA50", Offset = "0x33CD850", VA = "0x1833CEA50")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x33CEA70", Offset = "0x33CD870", VA = "0x1833CEA70")]
	public void FKHIGDOPKFL(int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x33CEF70", Offset = "0x33CDD70", VA = "0x1833CEF70")]
	public void GPENDMHDDPP(T[] FNIMPMJDPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x33CF560", Offset = "0x33CE360", VA = "0x1833CF560")]
	public Enumerator MIBGMGJFDKE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x33CF6C0", Offset = "0x33CE4C0", VA = "0x1833CF6C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x33CF6C0", Offset = "0x33CE4C0", VA = "0x1833CF6C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x33CF300", Offset = "0x33CE100", VA = "0x1833CF300")]
	private int IHLHCEGGFKL(int DOJILIOCHKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x33CF610", Offset = "0x33CE410", VA = "0x1833CF610")]
	private int NPODJKLIBCA(int DOJILIOCHKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class AHKAAKBFKKN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> AFPLDOJPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> NDKEAGMKBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x348ACC0", Offset = "0x3489AC0", VA = "0x18348ACC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x348AC00", Offset = "0x3489A00", VA = "0x18348AC00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public AHKAAKBFKKN(Func<Internal, External> AFPLDOJPIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x348ABB0", Offset = "0x34899B0", VA = "0x18348ABB0")]
	public AHKAAKBFKKN(IReadOnlyList<Internal> NDKEAGMKBJJ, Func<Internal, External> AFPLDOJPIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x348AB30", Offset = "0x3489930", VA = "0x18348AB30", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3263D50", Offset = "0x3262B50", VA = "0x183263D50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CMOGGAAGIAM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> FLGEPFLHMFN(TRequest GDHOLDPNHCL, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum BEKPJICGLJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class LGFMBALOHJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float LOELIIAOOBG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan ENCNAMOFNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int ODAAHINIEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BEKPJICGLJD OJDJACPLONP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly LGFMBALOHJB BKEFLEENBBL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float CFBKFFPNNLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x39425E0", Offset = "0x39413E0", VA = "0x1839425E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan AFGHGKFLNAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x39426C0", Offset = "0x39414C0", VA = "0x1839426C0")]
		public LGFMBALOHJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct HNPJBHIHCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest GDHOLDPNHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken BIBHFGFDEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> HBJHKLELGAL;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x35ABF80", Offset = "0x35AAD80", VA = "0x1835ABF80")]
		public HNPJBHIHCPO(TRequest GDHOLDPNHCL, TaskCompletionSource<TResult> HBJHKLELGAL, CancellationToken BIBHFGFDEGJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct KKACHDKPHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CMOGGAAGIAM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x389B610", Offset = "0x389A410", VA = "0x18389B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x389B9F0", Offset = "0x389A7F0", VA = "0x18389B9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct LILEHJCFGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CMOGGAAGIAM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HNPJBHIHCPO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3952C10", Offset = "0x3951A10", VA = "0x183952C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3953D80", Offset = "0x3952B80", VA = "0x183953D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource OADAJFIHGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<HNPJBHIHCPO> LPLLEJIFIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LGFMBALOHJB KIECPODDIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FLGEPFLHMFN LPKJOANKLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task MMEGBFCLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int DNLHBJKIGCE;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B12E50", Offset = "0x4B11C50", VA = "0x184B12E50")]
	public CMOGGAAGIAM(FLGEPFLHMFN LPKJOANKLBG, [Optional] LGFMBALOHJB KIECPODDIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B11990", Offset = "0x4B10790", VA = "0x184B11990")]
	public Task<TResult> HFICGKGCJCM(TRequest GDHOLDPNHCL, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B113F0", Offset = "0x4B101F0", VA = "0x184B113F0")]
	private void DLAOANBPNFC(HNPJBHIHCPO DHHKDCODMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B128E0", Offset = "0x4B116E0", VA = "0x184B128E0")]
	[AsyncStateMachine(typeof(CMOGGAAGIAM<, >.KKACHDKPHBC))]
	private Task PEGIEIKEMIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4B11B60", Offset = "0x4B10960", VA = "0x184B11B60")]
	private HNPJBHIHCPO JEJBJJKNMEP()
	{
		return default(HNPJBHIHCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4B12330", Offset = "0x4B11130", VA = "0x184B12330")]
	[AsyncStateMachine(typeof(CMOGGAAGIAM<, >.LILEHJCFGFB))]
	private Task JFAFBMOHOAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4B12700", Offset = "0x4B11500", VA = "0x184B12700")]
	private void KMOJJLDJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4B11540", Offset = "0x4B10340", VA = "0x184B11540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class JFGPFBBNPMM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> NDKEAGMKBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> AGCPJIOFLKK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F580", Offset = "0x2E9E380", VA = "0x182E9F580", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MGKAFOIHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3822AF0", Offset = "0x38218F0", VA = "0x183822AF0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3822C10", Offset = "0x3821A10", VA = "0x183822C10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3423290", Offset = "0x3422090", VA = "0x183423290", Slot = "11")]
	public void Add(T PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x38222B0", Offset = "0x38210B0", VA = "0x1838222B0")]
	public bool GJCIIACGELM(T PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x38228C0", Offset = "0x38216C0", VA = "0x1838228C0", Slot = "15")]
	public bool Remove(T PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3822430", Offset = "0x3821230", VA = "0x183822430", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x33BAA20", Offset = "0x33B9820", VA = "0x1833BAA20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x38221E0", Offset = "0x3820FE0", VA = "0x1838221E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3822240", Offset = "0x3821040", VA = "0x183822240", Slot = "13")]
	public bool Contains(T PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3822280", Offset = "0x3821080", VA = "0x183822280", Slot = "14")]
	public void CopyTo(T[] FNIMPMJDPGM, int KOPIDODGMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x38224C0", Offset = "0x38212C0", VA = "0x1838224C0", Slot = "6")]
	public int IndexOf(T PEGAJFMFKFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3822510", Offset = "0x3821310", VA = "0x183822510", Slot = "7")]
	public void Insert(int DOJILIOCHKM, T PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x38227D0", Offset = "0x38215D0", VA = "0x1838227D0", Slot = "8")]
	public void RemoveAt(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3822A00", Offset = "0x3821800", VA = "0x183822A00")]
	public JFGPFBBNPMM()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F29B00", Offset = "0x1F28900", VA = "0x181F29B00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE9F0", Offset = "0x5CAD7F0", VA = "0x185CAE9F0")]
		public SerializedGuid([In] Guid FGCEIIELPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE7E0", Offset = "0x5CAD5E0", VA = "0x185CAE7E0")]
		public static SerializedGuid FBKHCKBEBCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE8D0", Offset = "0x5CAD6D0", VA = "0x185CAE8D0")]
		public static SerializedGuid HIBHHCEIBAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE860", Offset = "0x5CAD660", VA = "0x185CAE860")]
		public bool GBAJLLCPBJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE9C0", Offset = "0x5CAD7C0", VA = "0x185CAE9C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE940", Offset = "0x5CAD740", VA = "0x185CAE940", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE710", Offset = "0x5CAD510", VA = "0x185CAE710", Slot = "7")]
		public bool Equals(SerializedGuid MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE750", Offset = "0x5CAD550", VA = "0x185CAE750", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE8C0", Offset = "0x5CAD6C0", VA = "0x185CAE8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE6E0", Offset = "0x5CAD4E0", VA = "0x185CAE6E0", Slot = "6")]
		public int CompareTo(SerializedGuid MFMJJEFODHB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AKFBMLPBCKD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type NJNCHFNIOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string CJCPIHGJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool DCOKJAIBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool GDFKFMLGKOI;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9CF0", Offset = "0x5CA8AF0", VA = "0x185CA9CF0")]
	public AKFBMLPBCKD(Type OAPNJCOGFPI, string EJHMOHMOCJL, bool GOCCOMCPNGD = false, bool COCEPMBFLEF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EIIPDELDDBE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct KGLDPPFGJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long KOFMEHMODBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long GHLIDEKDLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int GGCJBLFAMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int FEKLCLNGEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool LKALNEAEBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string GNDNHAFGJKD;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3895EE0", Offset = "0x3894CE0", VA = "0x183895EE0")]
		public KGLDPPFGJJG(long KOFMEHMODBF, int GGCJBLFAMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3895EB0", Offset = "0x3894CB0", VA = "0x183895EB0")]
		public KGLDPPFGJJG(long KOFMEHMODBF, long GHLIDEKDLKL, int GGCJBLFAMIE, int FEKLCLNGEFA, bool LKALNEAEBCM, string GNDNHAFGJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3895D40", Offset = "0x3894B40", VA = "0x183895D40")]
		public int CFMPEMDDBCH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3895E90", Offset = "0x3894C90", VA = "0x183895E90")]
		public int PCGKPDDHEFI(int KFPAABBMCFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3895E30", Offset = "0x3894C30", VA = "0x183895E30")]
		public double GAFNFMMOAON()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3895D90", Offset = "0x3894B90", VA = "0x183895D90")]
		public KGLDPPFGJJG DAGGHEDMMMC(long GHLIDEKDLKL, int FEKLCLNGEFA)
		{
			return default(KGLDPPFGJJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class OABKDIIPOLN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct PAHGPPHEPHD<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public OABKDIIPOLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<OABKDIIPOLN, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private OABKDIIPOLN <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3DC58A0", Offset = "0x3DC46A0", VA = "0x183DC58A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x35C14A0", Offset = "0x35C02A0", VA = "0x1835C14A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey FPPHOMLMMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly EIIPDELDDBE<TKey> JICPEFHJENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly GKFGDEJLFAD CGHEBMJOFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<OABKDIIPOLN> HLBMPGJBPNI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string KOIDHCJAHKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3C94050", Offset = "0x3C92E50", VA = "0x183C94050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<OABKDIIPOLN> CAINKDIPLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3C93C80", Offset = "0x3C92A80", VA = "0x183C93C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KGLDPPFGJJG KAHNDCOCFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3C94080", Offset = "0x3C92E80", VA = "0x183C94080")]
			[CompilerGenerated]
			get
			{
				return default(KGLDPPFGJJG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3C94020", Offset = "0x3C92E20", VA = "0x183C94020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C940A0", Offset = "0x3C92EA0", VA = "0x183C940A0")]
		internal OABKDIIPOLN(EIIPDELDDBE<TKey> JICPEFHJENB, TKey JLDFGFPAIIN, GKFGDEJLFAD CGHEBMJOFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C93EC0", Offset = "0x3C92CC0", VA = "0x183C93EC0")]
		public OABKDIIPOLN FGCCJMINPOC(TKey JLDFGFPAIIN, [Optional] GKFGDEJLFAD? MIDCCOLMCEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2292900", Offset = "0x2291700", VA = "0x182292900")]
		[AsyncStateMachine(typeof(PAHGPPHEPHD<>))]
		public Task<T> DAHJOGFPHDJ<T>(TKey JLDFGFPAIIN, Func<OABKDIIPOLN, Task<T>> BCIFBAGGNNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C93CC0", Offset = "0x3C92AC0", VA = "0x183C93CC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class COOLGMNGGAK : IEnumerable<(TKey, List<TKey>, KGLDPPFGJJG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KGLDPPFGJJG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, KGLDPPFGJJG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EIIPDELDDBE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, KGLDPPFGJJG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, KGLDPPFGJJG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x369F480", Offset = "0x369E280", VA = "0x18369F480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KGLDPPFGJJG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4B3E3A0", Offset = "0x4B3D1A0", VA = "0x184B3E3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x369F6A0", Offset = "0x369E4A0", VA = "0x18369F6A0")]
		[DebuggerHidden]
		public COOLGMNGGAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x325F240", Offset = "0x325E040", VA = "0x18325F240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B3DF50", Offset = "0x4B3CD50", VA = "0x184B3DF50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B3DF00", Offset = "0x4B3CD00", VA = "0x184B3DF00")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E350", Offset = "0x4B3D150", VA = "0x184B3E350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E290", Offset = "0x4B3D090", VA = "0x184B3E290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KGLDPPFGJJG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x30632C0", Offset = "0x30620C0", VA = "0x1830632C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class COAGLKJIKNN : IEnumerable<(TKey, List<TKey>, KGLDPPFGJJG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KGLDPPFGJJG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, KGLDPPFGJJG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private OABKDIIPOLN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OABKDIIPOLN <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EIIPDELDDBE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<OABKDIIPOLN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, KGLDPPFGJJG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, KGLDPPFGJJG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x369F480", Offset = "0x369E280", VA = "0x18369F480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KGLDPPFGJJG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4B3D4F0", Offset = "0x4B3C2F0", VA = "0x184B3D4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x369F6A0", Offset = "0x369E4A0", VA = "0x18369F6A0")]
		[DebuggerHidden]
		public COAGLKJIKNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D550", Offset = "0x4B3C350", VA = "0x184B3D550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4B3CC20", Offset = "0x4B3BA20", VA = "0x184B3CC20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4B3CBC0", Offset = "0x4B3B9C0", VA = "0x184B3CBC0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D360", Offset = "0x4B3C160", VA = "0x184B3D360")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D4A0", Offset = "0x4B3C2A0", VA = "0x184B3D4A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D3C0", Offset = "0x4B3C1C0", VA = "0x184B3D3C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KGLDPPFGJJG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x400F1C0", Offset = "0x400DFC0", VA = "0x18400F1C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, KGLDPPFGJJG, GKFGDEJLFAD> CIIHMKDEELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, KGLDPPFGJJG, GKFGDEJLFAD> IPBLLKJLPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<EIIPDELDDBE<TKey>, GKFGDEJLFAD> PDNNHCBHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OABKDIIPOLN MDNPDHAPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool FABLEFHCLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int OBLCNGPMEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch GLMEEAHODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int GOJMEKPADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string OPMKAJBLPHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OABKDIIPOLN LPGLIBFNDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string KOIDHCJAHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3058430", Offset = "0x3057230", VA = "0x183058430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3058490", Offset = "0x3057290", VA = "0x183058490")]
	public EIIPDELDDBE(TKey JAPBNODBOEH, GKFGDEJLFAD CGHEBMJOFGL, [Optional] int? GGCJBLFAMIE, [Optional][CanBeNull] Stopwatch GLMEEAHODNJ, [Optional] Action<TKey, KGLDPPFGJJG, GKFGDEJLFAD> CIIHMKDEELE, [Optional] Action<TKey, KGLDPPFGJJG, GKFGDEJLFAD> IPBLLKJLPJI, [Optional] Action<EIIPDELDDBE<TKey>, GKFGDEJLFAD> PDNNHCBHNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3058240", Offset = "0x3057040", VA = "0x183058240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x30582D0", Offset = "0x30570D0", VA = "0x1830582D0")]
	[IteratorStateMachine(typeof(EIIPDELDDBE<>.COOLGMNGGAK))]
	public IEnumerable<(TKey, List<TKey>, KGLDPPFGJJG)> IPPBPDPCAHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3058360", Offset = "0x3057160", VA = "0x183058360")]
	[IteratorStateMachine(typeof(EIIPDELDDBE<>.COAGLKJIKNN))]
	private IEnumerable<(TKey, List<TKey>, KGLDPPFGJJG)> IPPBPDPCAHN(List<TKey> GKNFKOKBKMK, OABKDIIPOLN DALIPKFLPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x30581C0", Offset = "0x3056FC0", VA = "0x1830581C0")]
	private (long, int) BFNAACBMAAI()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class LHFFNAGADKM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut MBLGKBHHDLJ(EIIPDELDDBE<TKey> JICPEFHJENB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected LHFFNAGADKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class GFPJMFOGCNC<TKey> : LHFFNAGADKM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string PNNGPABABBC(TKey JLDFGFPAIIN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34AFA10", Offset = "0x34AE810", VA = "0x1834AFA10")]
	private static string FANHDFCFFBA(TKey JLDFGFPAIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34AFA50", Offset = "0x34AE850", VA = "0x1834AFA50", Slot = "4")]
	public override string MBLGKBHHDLJ(EIIPDELDDBE<TKey> JICPEFHJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34AFB10", Offset = "0x34AE910", VA = "0x1834AFB10")]
	public string MBLGKBHHDLJ(EIIPDELDDBE<TKey> JICPEFHJENB, [NotNull] PNNGPABABBC CAHGNFNEHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GIOEKAAMNNG(EIIPDELDDBE<TKey> JICPEFHJENB, [NotNull] PNNGPABABBC CAHGNFNEHNA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3463A30", Offset = "0x3462830", VA = "0x183463A30")]
	protected GFPJMFOGCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class BLLKLCHELAM<TKey> : LHFFNAGADKM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string NLEFPIGJIGA(TKey JLDFGFPAIIN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string PHNFNFNFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double LNNKEPPIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool GJNNNEFFHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int KOLJBDNLJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> HKAKKPEKLEK;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4448D20", Offset = "0x4447B20", VA = "0x184448D20")]
	private static string FANHDFCFFBA(TKey JLDFGFPAIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x44497B0", Offset = "0x44485B0", VA = "0x1844497B0")]
	public BLLKLCHELAM(string PHNFNFNFMFO = "F2", double LNNKEPPIAPA = double.MaxValue, bool GJNNNEFFHIK = false, int KOLJBDNLJKH = int.MaxValue, [Optional] ISet<string> HKAKKPEKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4448D60", Offset = "0x4447B60", VA = "0x184448D60", Slot = "4")]
	public override Dictionary<string, string> MBLGKBHHDLJ(EIIPDELDDBE<TKey> JICPEFHJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4448C40", Offset = "0x4447A40", VA = "0x184448C40")]
	private bool EEOKHKLJPBE(string KNLAPAANBFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4448E20", Offset = "0x4447C20", VA = "0x184448E20")]
	public Dictionary<string, string> MBLGKBHHDLJ(EIIPDELDDBE<TKey> JICPEFHJENB, NLEFPIGJIGA CAHGNFNEHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4449410", Offset = "0x4448210", VA = "0x184449410")]
	private string MPFNBDLNBIP(StringBuilder HBDLIJPGOAH, List<TKey> IKNOMOKHOMC, NLEFPIGJIGA CAHGNFNEHNA, bool IMIPIKJOMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4449650", Offset = "0x4448450", VA = "0x184449650")]
	private static void PEOFDHMLLGD(StringBuilder PEGOADHKPNC, string HKLJJPEDLIL, bool FNIAMICJLLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DBEJMICMMGI<TKey> : GFPJMFOGCNC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OLDLHFLCGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public PNNGPABABBC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static DBEJMICMMGI<TKey> GOPCOAILBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] EDOMPOKGKBN;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB75A0", Offset = "0x4CB63A0", VA = "0x184CB75A0")]
	private DBEJMICMMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6670", Offset = "0x4CB5470", VA = "0x184CB6670", Slot = "5")]
	protected override string GIOEKAAMNNG(EIIPDELDDBE<TKey> JICPEFHJENB, PNNGPABABBC CAHGNFNEHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6580", Offset = "0x4CB5380", VA = "0x184CB6580")]
	[CompilerGenerated]
	internal static string BBFMFOIBDEP(string BJDNGGHFEKE, TKey JLDFGFPAIIN, OLDLHFLCGON P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LEGEELODMFJ : EIIPDELDDBE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NLJAHDEGMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<LEGEELODMFJ, GKFGDEJLFAD> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NLJAHDEGMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD0B0", Offset = "0x5CABEB0", VA = "0x185CAD0B0")]
		internal void BHHNAKGHLAN(EIIPDELDDBE<string> timer, GKFGDEJLFAD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CACC20", Offset = "0x5CABA20", VA = "0x185CACC20")]
	public LEGEELODMFJ(GKFGDEJLFAD CGHEBMJOFGL, [Optional] string IFIHPGOBLHH, [Optional] int? GGCJBLFAMIE, [Optional] Stopwatch GLMEEAHODNJ, [Optional] Action<string, KGLDPPFGJJG, GKFGDEJLFAD> CIIHMKDEELE, [Optional] Action<string, KGLDPPFGJJG, GKFGDEJLFAD> IPBLLKJLPJI, [Optional] Action<LEGEELODMFJ, GKFGDEJLFAD> PDNNHCBHNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CACB60", Offset = "0x5CAB960", VA = "0x185CACB60")]
	private static Action<EIIPDELDDBE<string>, GKFGDEJLFAD> PKHCNNKADDI(Action<LEGEELODMFJ, GKFGDEJLFAD> MEKLMIFMFCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class NKCCCPJMGBB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class DJLOEEIGBJI : NKCCCPJMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static NKCCCPJMGBB GOPCOAILBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5CAAE20", Offset = "0x5CA9C20", VA = "0x185CAAE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float NOBAOFDDALK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C07780", Offset = "0x1C06580", VA = "0x181C07780", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAF20", Offset = "0x5CA9D20", VA = "0x185CAAF20")]
		public DJLOEEIGBJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static NKCCCPJMGBB OKKDOFNFGGB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static NKCCCPJMGBB BKEFLEENBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5CACF40", Offset = "0x5CABD40", VA = "0x185CACF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float NOBAOFDDALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected NKCCCPJMGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LFIANKHAKAI : BPKDAABEHJF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CACD70", Offset = "0x5CABB70", VA = "0x185CACD70")]
	public LFIANKHAKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BPKDAABEHJF<T> : DMPKAHEOBML<T>, FBNFCIJAKIE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> GEFJLIOPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BOOMHLJDOCA<T> DCMOKMIAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x444D1E0", Offset = "0x444BFE0", VA = "0x18444D1E0")]
	public BPKDAABEHJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LGHHFFHNMEE<T> : DMPKAHEOBML<T>, FBNFCIJAKIE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> GEFJLIOPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public BOOMHLJDOCA<T> DCMOKMIAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3942810", Offset = "0x3941610", VA = "0x183942810")]
	public LGHHFFHNMEE(Exception LLMCFHBADKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FBNFCIJAKIE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DMPKAHEOBML<T> : FBNFCIJAKIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> GEFJLIOPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	BOOMHLJDOCA<T> DCMOKMIAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class OCDPCPLAEIP
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool LPKCONCFGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD140", Offset = "0x5CABF40", VA = "0x185CAD140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD190", Offset = "0x5CABF90", VA = "0x185CAD190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD1F0", Offset = "0x5CABFF0", VA = "0x185CAD1F0")]
	static OCDPCPLAEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected OCDPCPLAEIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class LEGONFACABJ<TTask, T> : OCDPCPLAEIP, DMPKAHEOBML<T>, FBNFCIJAKIE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DJPOHBEGJJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public DJPOHBEGJJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2E8F6F0", Offset = "0x2E8E4F0", VA = "0x182E8F6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2E8FC60", Offset = "0x2E8EA60", VA = "0x182E8FC60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LEGONFACABJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DJPOHBEGJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4CF3CC0", Offset = "0x4CF2AC0", VA = "0x184CF3CC0")]
		[AsyncStateMachine(typeof(LEGONFACABJ<, >.DJPOHBEGJJN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CGAGDKHPGGG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> CKLPGPGBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool FABLEFHCLJG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> GEFJLIOPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BOOMHLJDOCA<T> DCMOKMIAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x393E110", Offset = "0x393CF10", VA = "0x18393E110")]
	protected LEGONFACABJ(TTask CKLPGPGBFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x393DED0", Offset = "0x393CCD0", VA = "0x18393DED0", Slot = "1")]
	~LEGONFACABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x393DEB0", Offset = "0x393CCB0", VA = "0x18393DEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x393DBD0", Offset = "0x393C9D0", VA = "0x18393DBD0")]
	private void DGLGEELFCGD(bool EBDEJNNIKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HEAEOFEOLBF(TTask MDAMMAFCOJF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OAAFLIELPEH();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GDALHFMALEM
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB480", Offset = "0x5CAA280", VA = "0x185CAB480")]
	[NotNull]
	public static byte[] CIAGLHCBCAK(this HOFAIGJKEJN HLOKDKNMEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB4F0", Offset = "0x5CAA2F0", VA = "0x185CAB4F0")]
	[NotNull]
	public static byte[] CIAGLHCBCAK(this HOFAIGJKEJN HLOKDKNMEHI, HashAlgorithmName HEEMIEEBEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB560", Offset = "0x5CAA360", VA = "0x185CAB560")]
	public static bool FHKEJNHCPLL([CanBeNull] this HOFAIGJKEJN HLOKDKNMEHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB6F0", Offset = "0x5CAA4F0", VA = "0x185CAB6F0")]
	public static bool FHKEJNHCPLL([CanBeNull] this HOFAIGJKEJN HLOKDKNMEHI, [Out] string OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB890", Offset = "0x5CAA690", VA = "0x185CAB890")]
	private static bool LLFNKKGNJIJ([NotNull] HOFAIGJKEJN HLOKDKNMEHI, [Out][CanBeNull] byte[] NNCDMIALIKE, [Out][CanBeNull] byte[] LHMIKFHHICB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GKIPKFGMNJD
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB9B0", Offset = "0x5CAA7B0", VA = "0x185CAB9B0")]
	[NotNull]
	public static byte[] CIAGLHCBCAK(this KOAIMJBJNBM NFMOOLEOCGL, HashAlgorithmName HEEMIEEBEOI, byte[] ILHBJNIOINA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KOAIMJBJNBM
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BOLKJAHMCHK);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HOFAIGJKEJN : KOAIMJBJNBM
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] HCBDABCJNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] HPNOKFONCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HONBCDFNBCG
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> LLJPMMKAPOK;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool OJMBAMFLECC;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CABD40", Offset = "0x5CAAB40", VA = "0x185CABD40")]
	public static void GKLLAEBAJFJ(this IncrementalHash DMNALJGLJBO, [CanBeNull] GameObject DEGGPBGPMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x237F500", Offset = "0x237E300", VA = "0x18237F500")]
	public static void GKLLAEBAJFJ<T>(this IncrementalHash DMNALJGLJBO, [CanBeNull] T PMEJDDFHMDG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x237F5C0", Offset = "0x237E3C0", VA = "0x18237F5C0")]
	public static void KPKKLGHAOPJ<T>(this IncrementalHash DMNALJGLJBO, [CanBeNull] T NFMOOLEOCGL) where T : KOAIMJBJNBM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x237F650", Offset = "0x237E450", VA = "0x18237F650")]
	public static void NMHALOAOJBC<T>(this IncrementalHash DMNALJGLJBO, [CanBeNull] IList<T> PKGAEKAIFGG) where T : KOAIMJBJNBM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5CABCB0", Offset = "0x5CAAAB0", VA = "0x185CABCB0")]
	private static bool ELMLOCEPLGG([CanBeNull] KOAIMJBJNBM NFMOOLEOCGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC570", Offset = "0x5CAB370", VA = "0x185CAC570")]
	public static void OBDOGCLNBNN(this IncrementalHash BOLKJAHMCHK, [CanBeNull] string ONDJJMNFKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC0A0", Offset = "0x5CAAEA0", VA = "0x185CAC0A0")]
	public static void JMDOFIFHABN(this IncrementalHash BOLKJAHMCHK, long OADMBGAAFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC5D0", Offset = "0x5CAB3D0", VA = "0x185CAC5D0")]
	public static void OEBNNAKFHNG(this IncrementalHash BOLKJAHMCHK, int JDCIOBICFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC3A0", Offset = "0x5CAB1A0", VA = "0x185CAC3A0")]
	public static void MPNFJAHOGNE(this IncrementalHash BOLKJAHMCHK, short NLDLMBGCEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CABE20", Offset = "0x5CAAC20", VA = "0x185CABE20")]
	public static void IPHAFJKAGBE(this IncrementalHash BOLKJAHMCHK, byte PKKNLOAAKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5CABF30", Offset = "0x5CAAD30", VA = "0x185CABF30")]
	public static void JHANDBGBDKA(this IncrementalHash BOLKJAHMCHK, bool GIPOMFKKMID, bool GNIIKFOFOFL = false, bool CIEBDANAOFO = false, bool IOPMEDKBKNL = false, bool AOECKCKLJLF = false, bool KBPMPCGNHAF = false, bool DDDABGONPCA = false, bool KEOCPDAMDIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x237EED0", Offset = "0x237DCD0", VA = "0x18237EED0")]
	public static void BFBIAFOBJED<T>(this IncrementalHash BOLKJAHMCHK, T JAEAMOHJHNM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5CABBF0", Offset = "0x5CAA9F0", VA = "0x185CABBF0")]
	public static void DCIOLEHEIBI(this IncrementalHash BOLKJAHMCHK, float KIEMKHGFMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5CABC50", Offset = "0x5CAAA50", VA = "0x185CABC50")]
	public static void EJDGPNCFHBJ(this IncrementalHash BOLKJAHMCHK, ulong FIDEIEIMEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC7A0", Offset = "0x5CAB5A0", VA = "0x185CAC7A0")]
	public static void OKKNKCKPBKF(this IncrementalHash BOLKJAHMCHK, uint IFBBLDFIFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC800", Offset = "0x5CAB600", VA = "0x185CAC800")]
	public static void PDBHBMJFDIH(this IncrementalHash BOLKJAHMCHK, ushort NNHBFHGDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC270", Offset = "0x5CAB070", VA = "0x185CAC270")]
	public static void KGJACGLJELH(this IncrementalHash BOLKJAHMCHK, Vector3 NKGOLACDEKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BADEJDPLPHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9D60", Offset = "0x5CA8B60", VA = "0x185CA9D60")]
	public BADEJDPLPHI(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class MABLAFGOLEP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class OKPKAGDNFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode LNKCIHFCLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode LBLLNFOEKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JGOFABHMKAD ECKGDPNKHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<JGOFABHMKAD> PKBBOKBCKKP;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OKPKAGDNFLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct JGOFABHMKAD : IComparable<JGOFABHMKAD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int HNKBNELEHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant ELHHFNEMNAC;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0130", Offset = "0xAAEF30", VA = "0x180AB0130")]
		public JGOFABHMKAD(int HNKBNELEHOC, TClaimant ELHHFNEMNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3824040", Offset = "0x3822E40", VA = "0x183824040")]
		public bool IPHAPMIGFDF([In] JGOFABHMKAD MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3824030", Offset = "0x3822E30", VA = "0x183824030")]
		public bool GMEGAFCJIGN([In] JGOFABHMKAD MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3824020", Offset = "0x3822E20", VA = "0x183824020", Slot = "4")]
		public int CompareTo(JGOFABHMKAD MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x38240A0", Offset = "0x3822EA0", VA = "0x1838240A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum ICINONAEICE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IJAFPKDBAAK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MABLAFGOLEP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public IJAFPKDBAAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3680D40", Offset = "0x367FB40", VA = "0x183680D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3680F00", Offset = "0x367FD00", VA = "0x183680F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3680E20", Offset = "0x367FC20", VA = "0x183680E20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32606B0", Offset = "0x325F4B0", VA = "0x1832606B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly KHMJOLNNJGJ<OKPKAGDNFLN> GAFCFCNCLIK;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly KHMJOLNNJGJ<List<JGOFABHMKAD>> KACPJCFFJMB;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int ACJFGFAKPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> KBFPNFFHIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, OKPKAGDNFLN> PIONFMDMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private ICINONAEICE CPGOEPLHNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DGLCEEOLIGB(TNode NNLCCKHBAKP);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NEOGPCOEJEE(TNode NNLCCKHBAKP, TClaimant IIOGNOLDDHH, TClaimant KILENKLBAIO);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E970", Offset = "0x3B1D770", VA = "0x183B1E970")]
	public MABLAFGOLEP(ICINONAEICE CPGOEPLHNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DB40", Offset = "0x3B1C940", VA = "0x183B1DB40")]
	public void GGJAEHFHIDG(TNode NNLCCKHBAKP, TNode KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E320", Offset = "0x3B1D120", VA = "0x183B1E320")]
	public void LDNCNFLICMN(TClaimant ELHHFNEMNAC, TNode IEAPLBAIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D730", Offset = "0x3B1C530", VA = "0x183B1D730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DBD0", Offset = "0x3B1C9D0", VA = "0x183B1DBD0")]
	private void GLHMADPBLGM(TClaimant ELHHFNEMNAC, TNode MCAGCPNIFGB, TNode IEAPLBAIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D900", Offset = "0x3B1C700", VA = "0x183B1D900")]
	private int ECGOIHFMKJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DF50", Offset = "0x3B1CD50", VA = "0x183B1DF50")]
	private void IHCDEFACLAL(TClaimant ELHHFNEMNAC, TNode CGLBCEBPCML, TNode IKGHEPBMABE, int POOCKDKGEEN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E290", Offset = "0x3B1D090", VA = "0x183B1E290")]
	private void JNGMMINGEEI(JGOFABHMKAD CMFHEIKDFPO, OKPKAGDNFLN AMPANLCHEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DC70", Offset = "0x3B1CA70", VA = "0x183B1DC70")]
	private void HMOIIIFOFME(TClaimant ELHHFNEMNAC, TNode CGLBCEBPCML, TNode IKGHEPBMABE, int POOCKDKGEEN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E5B0", Offset = "0x3B1D3B0", VA = "0x183B1E5B0")]
	private void OAIIOEDNBKF(JGOFABHMKAD CMFHEIKDFPO, TNode NNLCCKHBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D970", Offset = "0x3B1C770", VA = "0x183B1D970")]
	private void EODJJCNKGHJ(JGOFABHMKAD CMFHEIKDFPO, OKPKAGDNFLN AMPANLCHEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D150", Offset = "0x3B1BF50", VA = "0x183B1D150")]
	private void ANEJDLLDOGD(OKPKAGDNFLN AMPANLCHEKM, bool MMODAICGPME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D280", Offset = "0x3B1C080", VA = "0x183B1D280")]
	private void COKPANKGLCC(OKPKAGDNFLN AMPANLCHEKM, TNode KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DA60", Offset = "0x3B1C860", VA = "0x183B1DA60")]
	[IteratorStateMachine(typeof(MABLAFGOLEP<, >.IJAFPKDBAAK))]
	private IEnumerable<TNode> GBEGOPEGFKB(TNode CGLBCEBPCML, TNode IKGHEPBMABE, bool LBHENHHBHDD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E6C0", Offset = "0x3B1D4C0", VA = "0x183B1E6C0")]
	private OKPKAGDNFLN PCFLFPGKLBI(TNode NNLCCKHBAKP, TNode LBLLNFOEKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3B1E440", Offset = "0x3B1D240", VA = "0x183B1E440")]
	private OKPKAGDNFLN NAGCEHEKPEE(TNode NNLCCKHBAKP, TNode LBLLNFOEKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D5C0", Offset = "0x3B1C3C0", VA = "0x183B1D5C0")]
	private void DKBBCBIEHJH(OKPKAGDNFLN AMPANLCHEKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EJJGPIEDHBG<T> : IEnumerable<EJJGPIEDHBG<T>.GIBGIDJKLGL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct GIBGIDJKLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T GNLEHBFFNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int DOJILIOCHKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class KPPEHDHHFNG : IEnumerator<GIBGIDJKLGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private EJJGPIEDHBG<T> MFNMDNHFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int DOJILIOCHKM;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x30920D0", Offset = "0x3090ED0", VA = "0x1830920D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public GIBGIDJKLGL MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x38B38D0", Offset = "0x38B26D0", VA = "0x1838B38D0", Slot = "4")]
			get
			{
				return default(GIBGIDJKLGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x38B37E0", Offset = "0x38B25E0", VA = "0x1838B37E0")]
		public KPPEHDHHFNG(EJJGPIEDHBG<T> MFNMDNHFIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x38B3760", Offset = "0x38B2560", VA = "0x1838B3760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30E1E30", Offset = "0x30E0C30", VA = "0x1830E1E30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E590", Offset = "0x1A0D390", VA = "0x181A0E590", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct ILMOILEEPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool DIAOKOKNPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T GNLEHBFFNFG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int IECOKAKPFCJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> AOONCNMPNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private ILMOILEEPLC[] IBBNOMDLOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int PAGFMPKCJGD;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DJEHAIBHMED
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2CE0", Offset = "0x7A1AE0", VA = "0x1807A2CE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7A2950", Offset = "0x7A1750", VA = "0x1807A2950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F580", Offset = "0x2E9E380", VA = "0x182E9F580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x305BC00", Offset = "0x305AA00", VA = "0x18305BC00")]
	public EJJGPIEDHBG(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x305B830", Offset = "0x305A630", VA = "0x18305B830")]
	public EJJGPIEDHBG(GIBGIDJKLGL[] FHDKONBGGKE, bool BEGNNAFDLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x305AB00", Offset = "0x3059900", VA = "0x18305AB00")]
	public int BFFHJMOPNOO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x305B560", Offset = "0x305A360", VA = "0x18305B560")]
	private int NMJMKGFFKFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x305B780", Offset = "0x305A580", VA = "0x18305B780", Slot = "6")]
	protected virtual uint NNDONELLJKG(uint BOLKJAHMCHK, T GNLEHBFFNFG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x305AB90", Offset = "0x3059990", VA = "0x18305AB90")]
	public bool BKIDPMGAKIE(T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x305B300", Offset = "0x305A100", VA = "0x18305B300")]
	public int ILLBNGMBDLH(T GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x305B230", Offset = "0x305A030", VA = "0x18305B230")]
	public T HNNHIMHOOOM(int DOJILIOCHKM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x305AF30", Offset = "0x3059D30", VA = "0x18305AF30")]
	public bool GJCIIACGELM(T GNLEHBFFNFG, bool MOIPCOGOGIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x305AFD0", Offset = "0x3059DD0", VA = "0x18305AFD0")]
	public bool GJCIIACGELM(T GNLEHBFFNFG, int DOJILIOCHKM, bool MOIPCOGOGIJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x305AC80", Offset = "0x3059A80", VA = "0x18305AC80")]
	private int GHKGMGOEHEB(int KMGLIANDLEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x305B7B0", Offset = "0x305A5B0", VA = "0x18305B7B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x305B7B0", Offset = "0x305A5B0", VA = "0x18305B7B0", Slot = "4")]
	private IEnumerator<GIBGIDJKLGL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KHMJOLNNJGJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> FMIKANHCAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> OEPBENIIOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int KABPBLHAIGP;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3896860", Offset = "0x3895660", VA = "0x183896860")]
	public static KHMJOLNNJGJ<T> IAAMGPFNBLP(int DECKGNHFLHF = 0, int KABPBLHAIGP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3896E60", Offset = "0x3895C60", VA = "0x183896E60")]
	public KHMJOLNNJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3896CC0", Offset = "0x3895AC0", VA = "0x183896CC0")]
	public KHMJOLNNJGJ(int DECKGNHFLHF, int KABPBLHAIGP = int.MaxValue, bool MHJMLNPJABD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3896B40", Offset = "0x3895940", VA = "0x183896B40")]
	public T MPJIKIDJOGP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x38966B0", Offset = "0x38954B0", VA = "0x1838966B0")]
	public void GFINLAFBDPN(T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3896780", Offset = "0x3895580", VA = "0x183896780")]
	private void HJJBKDOBKHJ(T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3896690", Offset = "0x3895490", VA = "0x183896690")]
	private void EBCDEOOODEA(T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3896550", Offset = "0x3895350", VA = "0x183896550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3896940", Offset = "0x3895740", VA = "0x183896940")]
	private void JKHDMLLILDC(IEnumerable<T> HJOJMOBKMOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AOGMOJKDGFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> FAHEFJJEKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T NELIKGAIIOL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T FNCODMLGPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x367A620", Offset = "0x3679420", VA = "0x18367A620")]
	public bool JPPNIIILNPH(T GNLEHBFFNFG, int HNKBNELEHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x33D8CA0", Offset = "0x33D7AA0", VA = "0x1833D8CA0")]
	public bool IGLDGAEFJDA(int HNKBNELEHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x367A1D0", Offset = "0x3678FD0", VA = "0x18367A1D0")]
	public T ALIMGOFBCDM(int GEIPJAPMOGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x367A020", Offset = "0x3678E20", VA = "0x18367A020")]
	private bool AENLNMPEOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x367A6A0", Offset = "0x36794A0", VA = "0x18367A6A0")]
	public bool PGDPBMGNNCL(int HNKBNELEHOC, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x367A6F0", Offset = "0x36794F0", VA = "0x18367A6F0")]
	public AOGMOJKDGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BKDDCIDHEDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct ICFEMLBAHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T GMPOHOAMMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int GONKNNGKOIN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<ICFEMLBAHJK> AAGGKIKNJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T KOKDPBODDDP;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F580", Offset = "0x2E9E380", VA = "0x182E9F580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4443730", Offset = "0x4442530", VA = "0x184443730")]
	public bool FEMGIDLEFLP(T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x44434D0", Offset = "0x44422D0", VA = "0x1844434D0")]
	public void AAFNAGDLNDC(T GNLEHBFFNFG, int HNKBNELEHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x44438B0", Offset = "0x44426B0", VA = "0x1844438B0")]
	public bool ILBKIBAINPM(T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x44436D0", Offset = "0x44424D0", VA = "0x1844436D0")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4443A00", Offset = "0x4442800", VA = "0x184443A00")]
	public T OIFKCGMGIDD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4443570", Offset = "0x4442370", VA = "0x184443570")]
	private void ENLFOIGIJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4443A80", Offset = "0x4442880", VA = "0x184443A80")]
	public BKDDCIDHEDP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD3E0", Offset = "0x5CAC1E0", VA = "0x185CAD3E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD6B0", Offset = "0x5CAC4B0", VA = "0x185CAD6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD5C0", Offset = "0x5CAC3C0", VA = "0x185CAD5C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD330", Offset = "0x5CAC130", VA = "0x185CAD330")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD600", Offset = "0x5CAC400", VA = "0x185CAD600")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD510", Offset = "0x5CAC310", VA = "0x185CAD510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD2A0", Offset = "0x5CAC0A0", VA = "0x185CAD2A0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FBA910", Offset = "0x3FB9710", VA = "0x183FBA910", Slot = "4")]
		public virtual T CBMLBOMIGKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class BMKNLEKMFJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, EGLBBDMIIJN> LIPDBOCKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly KHMJOLNNJGJ<EGLBBDMIIJN> HJBMLGLLEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool LPEEBGDJFGO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public EGLBBDMIIJN PLDKNJOBKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 CHEHGBJKGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A240", Offset = "0xA29040", VA = "0x180A2A240")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD1A9F0", Offset = "0xD197F0", VA = "0x180D1A9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 MIEOCPEAFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD5FD40", Offset = "0xD5EB40", VA = "0x180D5FD40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 DOOAKHDAFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA870", Offset = "0x5CA9670", VA = "0x185CAA870")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76B140", Offset = "0x769F40", VA = "0x18076B140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int BEBINDLAOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x768180", Offset = "0x766F80", VA = "0x180768180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7685A0", Offset = "0x7673A0", VA = "0x1807685A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA890", Offset = "0x5CA9690", VA = "0x185CAA890")]
	public BMKNLEKMFJL(Bounds KDDCPPGFOHF, Vector2[] ANJCLBFELJM, int KKEGHCHKCKK, byte KMGLIANDLEO, float HHHPMDANFLD = 0f, [Optional] KHMJOLNNJGJ<EGLBBDMIIJN> HJBMLGLLEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9DC0", Offset = "0x5CA8BC0", VA = "0x185CA9DC0")]
	public EGLBBDMIIJN ANGEECOFMAG(byte DOJILIOCHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA5A0", Offset = "0x5CA93A0", VA = "0x185CAA5A0")]
	public void OIJBPCBPMNK(Vector3 AILFIIEAPKM, float OKKEELBPOAD, float IKGKIJNMLOK, List<byte> EOCFPACLFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A19630", Offset = "0x1A18430", VA = "0x181A19630")]
	public void IPGHKFDFLIO(EGLBBDMIIJN.AILNGIDIKMB AKLIPFHLDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA100", Offset = "0x5CA8F00", VA = "0x185CAA100")]
	public static int IIMGPCOPOHA(Vector2[] ANJCLBFELJM, int KKEGHCHKCKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA670", Offset = "0x5CA9470", VA = "0x185CAA670")]
	private EGLBBDMIIJN OKENCMFNHKC(byte DOJILIOCHKM, EGLBBDMIIJN.CHLKIJLOPHA DLNFFOJLPCO, EGLBBDMIIJN LBLLNFOEKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA1F0", Offset = "0x5CA8FF0", VA = "0x185CAA1F0")]
	private void JNGJLOPBDFE(EGLBBDMIIJN LBLLNFOEKNE, Vector2[] ANJCLBFELJM, int OHOGGKMPAOB, int IPLGJKMIEGF, int IIECLDJAGHA, int KOMIJJMAMGI, float HHHPMDANFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9EE0", Offset = "0x5CA8CE0", VA = "0x185CA9EE0")]
	private void GDBPHJIPNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9E20", Offset = "0x5CA8C20", VA = "0x185CA9E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9E80", Offset = "0x5CA8C80", VA = "0x185CA9E80", Slot = "1")]
	~BMKNLEKMFJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EGLBBDMIIJN
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum CHLKIJLOPHA
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum AILNGIDIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte FNEOLKMBLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 CBNGOLEICDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 ALAHGBICDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 OLDLGMGNNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 COCNLOALJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public CHLKIJLOPHA KGOEDIPHDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EGLBBDMIIJN ADEHKCCOJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<EGLBBDMIIJN> DCNNNCHJGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool IPEDCCLAMPG;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB3E0", Offset = "0x5CAA1E0", VA = "0x185CAB3E0")]
	public EGLBBDMIIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAF70", Offset = "0x5CA9D70", VA = "0x185CAAF70")]
	public void HHIIPGJELHJ(EGLBBDMIIJN FKKAOLHJCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	public void IPGHKFDFLIO(int GIMFEKJFACP, AILNGIDIKMB AKLIPFHLDMP, int OHHDFOGGGPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB0F0", Offset = "0x5CA9EF0", VA = "0x185CAB0F0")]
	public void OIJBPCBPMNK(List<byte> EOCFPACLFGL, Vector3 AILFIIEAPKM, float OKKEELBPOAD, float IKGKIJNMLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB090", Offset = "0x5CA9E90", VA = "0x185CAB090")]
	public bool JIBEMMOIMDN(Vector3 EPFKACHOOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB0C0", Offset = "0x5CA9EC0", VA = "0x185CAB0C0")]
	public bool OICGMIJIEHE(Vector3 EPFKACHOOEF, float APGBJAIDHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB350", Offset = "0x5CAA150", VA = "0x185CAB350")]
	public void OOCIGOIJKNJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct GFLJPFOBHKG<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> NDKEAGMKBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool OKLAKCFMGDH;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x34AF9E0", Offset = "0x34AE7E0", VA = "0x1834AF9E0")]
			public GFLJPFOBHKG(List<Component> NDKEAGMKBJJ, bool OKLAKCFMGDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x34AF8A0", Offset = "0x34AE6A0", VA = "0x1834AF8A0")]
			public KGDJJOCOCDE<T> MIBGMGJFDKE()
			{
				return default(KGDJJOCOCDE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x34AF910", Offset = "0x34AE710", VA = "0x1834AF910", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x34AF910", Offset = "0x34AE710", VA = "0x1834AF910", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct KGDJJOCOCDE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> NDKEAGMKBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool OKLAKCFMGDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int DOJILIOCHKM;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T MNPEEGLNGOK
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3894E50", Offset = "0x3893C50", VA = "0x183894E50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3894DE0", Offset = "0x3893BE0", VA = "0x183894DE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3894E20", Offset = "0x3893C20", VA = "0x183894E20")]
			public KGDJJOCOCDE(List<Component> NDKEAGMKBJJ, bool OKLAKCFMGDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3894D20", Offset = "0x3893B20", VA = "0x183894D20", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3894D30", Offset = "0x3893B30", VA = "0x183894D30", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x30D3A80", Offset = "0x30D2880", VA = "0x1830D3A80", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF020", Offset = "0x5CADE20", VA = "0x185CAF020")]
		private void OOCIGOIJKNJ(GameObject FJNLKHDMLBO, bool PJCPHDDKADF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEE60", Offset = "0x5CADC60", VA = "0x185CAEE60")]
		public static void OOCIGOIJKNJ(GameObject FJNLKHDMLBO, ToolHierarchyCache PCFHBLIBKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2644FE0", Offset = "0x2643DE0", VA = "0x182644FE0")]
		public void FOBNIGGCBFK<T>(Action<T> HMHDIIODGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2645200", Offset = "0x2644000", VA = "0x182645200")]
		public T LEIKCICENKG<T>(bool OKLAKCFMGDH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2645270", Offset = "0x2644070", VA = "0x182645270")]
		public GFLJPFOBHKG<T> MKEAKICHLIJ<T>(bool OKLAKCFMGDH = false) where T : class
		{
			return default(GFLJPFOBHKG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEA20", Offset = "0x5CAD820", VA = "0x185CAEA20")]
		public List<Component> CANOIPGEJEP(Type PEMNIEMPPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CAED70", Offset = "0x5CADB70", VA = "0x185CAED70", Slot = "4")]
		public bool Equals(ToolHierarchyCache HOELCINBFKH, ToolHierarchyCache JOHINIOFBIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEDF0", Offset = "0x5CADBF0", VA = "0x185CAEDF0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HBDENJGMDDF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DLIDPEKMOKD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int DECKGNHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int CFEGEPNAMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> GBGFELNIFAG;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x33CB740", Offset = "0x33CA540", VA = "0x1833CB740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T PAJMFNOPIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D03AD0", Offset = "0x4D028D0", VA = "0x184D03AD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T BCNIHEHHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D03C30", Offset = "0x4D02A30", VA = "0x184D03C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T GHLEKMJJDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D03CA0", Offset = "0x4D02AA0", VA = "0x184D03CA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D03EB0", Offset = "0x4D02CB0", VA = "0x184D03EB0")]
	public DLIDPEKMOKD(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D03820", Offset = "0x4D02620", VA = "0x184D03820")]
	public void AAFNAGDLNDC(T JOACNMJHNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4D03B90", Offset = "0x4D02990", VA = "0x184D03B90")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D03DE0", Offset = "0x4D02BE0", VA = "0x184D03DE0")]
	public void NKJLBEAIBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D03D80", Offset = "0x4D02B80", VA = "0x184D03D80")]
	public void KAHPEIBPLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D03A10", Offset = "0x4D02810", VA = "0x184D03A10")]
	public void CJJOKJLDMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LDDBEDPPGDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct KHLEHHCOPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int GONKNNGKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T GMPOHOAMMIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, KHLEHHCOPIE> FAHEFJJEKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> DALKBHEAAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T NELIKGAIIOL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T FNCODMLGPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x392FEE0", Offset = "0x392ECE0", VA = "0x18392FEE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool MEMHDGIHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x392FE70", Offset = "0x392EC70", VA = "0x18392FE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object EGJNBMHJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x392F7D0", Offset = "0x392E5D0", VA = "0x18392F7D0")]
	public bool JPPNIIILNPH(T GNLEHBFFNFG, object PFKLELGAJPH, int HNKBNELEHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x392F420", Offset = "0x392E220", VA = "0x18392F420")]
	public bool IGLDGAEFJDA(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3930380", Offset = "0x392F180", VA = "0x183930380")]
	public bool PGDPBMGNNCL(object PFKLELGAJPH, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x392F3F0", Offset = "0x392E1F0", VA = "0x18392F3F0")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x392EDA0", Offset = "0x392DBA0", VA = "0x18392EDA0")]
	private bool AENLNMPEOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x39306E0", Offset = "0x392F4E0", VA = "0x1839306E0")]
	public LDDBEDPPGDC()
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
