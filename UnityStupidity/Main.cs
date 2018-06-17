using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace UnityEngine.SceneManagement
{
    public class AsyncOperation
    {
        public Action<AsyncOperation> completed;
    }
    public static class SceneManager
    {
        public static Scene GetActiveScene()
        {
            return new Scene();
        }
        public static AsyncOperation LoadSceneAsync(string name, LoadSceneMode mode)
        {
            return new AsyncOperation();
        }
        public static AsyncOperation UnloadSceneAsync(Scene scene)
        {
            return new AsyncOperation();
        }
        public static int sceneCount
        {
            get
            {
                return 0;
            }
        }
        public static Scene GetSceneAt(int index)
        {
            return new Scene();
        }
        public static void MoveGameObjectToScene(GameObject obj, Scene scene)
        {

        }
    }
    public class Scene
    {
        public string name;
    }
    public enum LoadSceneMode
    {
        Additive
    }
}
namespace UnityEngine.Networking
{
    public static class NetworkTransport
    {
        public static void Init()
        {

        }
        public static void Shutdown()
        {

        }
        public static bool QueueMessageForSending(int hostId, int connectionId, int channelId, byte[] data, int size, out byte error)
        {
            error = 0;
            return true;
        }
        public static bool Send(int hostId, int connectionId, int channelId, byte[] data, int size, out byte error)
        {
            error = 0;
            return true;
        }
        public static bool SendQueuedMessages(int hostId, int connectionId, out byte error)
        {
            error = 0;
            return true;
        }
        public static int AddHost(HostTopology top)
        {
            return 0;
        }
        public static int AddHost(HostTopology top, int port)
        {
            return 0;
        }
        public static int AddHost(HostTopology top, int port, string ip)
        {
            return 0;
        }
        public static int AddWebsocketHost(HostTopology top, int port)
        {
            return 0;
        }
        public static int AddWebsocketHost(HostTopology top, int port, string ip)
        {
            return 0;
        }
        public static int AddHostWithSimulator(HostTopology top, int mintimeout, int maxTimeout)
        {
            return 0;
        }
        public static int AddHostWithSimulator(HostTopology top, int mintimeout, int maxTimeout, int port)
        {
            return 0;
        }
        public static int AddHostWithSimulator(HostTopology top, int mintimeout, int maxTimeout, int port, string ip)
        {
            return 0;
        }
        public static int Connect(int hostId, string address, int port, int cantRememberWhatThisIs, out byte error)
        {
            error = 0;
            return 0;
        }
        public static int ConnectWithSimulator(int hostId, string address, int port, int exceptionConnectionId, out byte error, ConnectionSimulatorConfig conf)
        {
            error = 0;
            return 0;
        }
        public static int ConnectEndPoint(int hostId, EndPoint endPoint, int exceptionConnectionId, out byte error)
        {
            error = 0;
            return 0;
        }
        public static bool Disconnect(int hostId, int connectionId, out byte error)
        {
            error = 0;
            return false;
        }
        public static int GetCurrentRTT(int hostId, int connectionId, out byte error)
        {
            error = 0;
            return 0;
        }
        public static int GetNetworkTimestamp()
        {
            return 0;
        }
        public static int GetRemoteDelayTimeMS(int hostId, int connectionId, int stamp, out byte error)
        {
            error = 0;
            return 0;
        }
        public static NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
        {
            hostId = 0;
            connectionId = 0;
            channelId = 0;
            error = 0;
            receivedSize = 0;
            return NetworkEventType.Nothing;
        }
        public static NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
        {
            connectionId = 0;
            channelId = 0;
            error = 0;
            receivedSize = 0;
            return NetworkEventType.Nothing;
        }
    }

    public enum NetworkEventType
    {
        Nothing,
        DataEvent,
        BroadcastEvent,
        DisconnectEvent,
        ConnectEvent
    }
    public enum QosType
    {
        Unreliable,
        UnreliableSequenced,
        Reliable,
        ReliableSequenced,
        ReliableFragmented,
        ReliableFragmentedSequenced,
        StateUpdate,
        ReliableStateUpdate,
        UnreliableFragmented,
        AllCostDelivery,
        UnreliableFragmentedSequenced
    }
    public enum NetworkError
    {
        Ok,
        Timeout,
        CRCMismatch
    }

    public class HostTopology
    {
        public ConnectionConfig DefaultConfig;
        public HostTopology(ConnectionConfig config, int maxCon)
        {

        }
    }

    public class ConnectionConfig
    {
        public List<ChannelQOS> Channels;
        public int SendDelay;
        public int AddChannel(QosType type)
        {
            return 0;
        }
    }
    public class ConnectionSimulatorConfig
    {

    }
    public class ChannelQOS
    {
        public bool BelongsToSharedOrderChannel;
        public QosType QOS;
    }
}
namespace UnityEngine.AI
{
    public class NavMeshAgent : Component
    {
        public Vector3 destination;
        public void Warp(Vector3 pos)
        {

        }
        public void SetDestination(Vector3 pos)
        {

        }
        public Vector3 velocity;
    }
}

namespace UnityEngine
{
    public static class Mathf
    {
        public static float Infinity = float.PositiveInfinity;
    }
    public struct LayerMask
    {

    }
    public enum QueryTriggerInteraction
    {
        UseGlobal,
        Ignore,
        Collide
    }
    public static class Physics
    {
        public static int OverlapSphereNonAlloc(Vector3 pos, float range, Collider[] cols)
        {
            return 0;
        }
        public static int OverlapSphereNonAlloc(Vector3 pos, float range, Collider[] cols, LayerMask mask, QueryTriggerInteraction trigger)
        {
            return 0;
        }
        public static bool CheckSphere(Vector3 pos, float range, LayerMask mask, QueryTriggerInteraction trigger)
        {
            return false;
        }
    }
    public static class Physics2D
    {
        public static int OverlapCircleNonAlloc(Vector3 pos, float range, Collider2D[] cols)
        {
            return 0;
        }
        public static int OverlapCircleNonAlloc(Vector3 pos, float range, Collider2D[] cols, LayerMask mask, float minDepth, float maxDepth)
        {
            return 0;
        }
    }
    public class Collider : Component
    {

    }
    public class Collider2D : Component
    {

    }
    public class Range : Attribute
    {
        public Range(float min, float max)
        {

        }
    }
    public class SerializeField : Attribute
    {

    }
    public class HideInInspector : Attribute
    {

    }
    public class TextArea : Attribute
    {

    }
    public class Animator : Component
    {
        public void SetTrigger(int hash)
        {

        }
        public void Play(int hash, int idkWhatThisIsMaybeLayer, float normalizedTime)
        {

        }
        public static int StringToHash(string str)
        {
            return 0;
        }
        public void SetInteger(int hash, int val)
        {

        }
        public void SetFloat(int hash, float val)
        {

        }
        public void SetBool(int hash, bool val)
        {

        }
        public int GetInteger(int hash)
        {
            return 0;
        }
        public float GetFloat(int hash)
        {
            return 0;
        }
        public bool GetBool(int hash)
        {
            return false;
        }
        public AnimatorControllerParameter[] parameters;
        public bool IsInTransition(int idk)
        {
            return true;
        }
        public AnimatorTransitionInfo GetAnimatorTransitionInfo(int idk)
        {
            return new AnimatorTransitionInfo();
        }
        public AnimatorStateInfo GetCurrentAnimatorStateInfo(int idk)
        {
            return new AnimatorStateInfo();
        }
    }
    public enum AnimatorControllerParameterType
    {
        Int,
        Float,
        Bool
    }
    public class AnimatorControllerParameter
    {
        public int nameHash;
        public string name;
        public AnimatorControllerParameterType type;
    }
    public class AnimatorTransitionInfo
    {
        public int fullPathHash;
    }
    public class AnimatorStateInfo
    {
        public float normalizedTime;
        public int fullPathHash;
    }
    public class AddComponentMenu : Attribute
    {
        public AddComponentMenu(string name)
        {

        }
        public AddComponentMenu(string name, int order)
        {

        }
    }
    public class Tooltip : Attribute
    {
        public Tooltip(string name)
        {

        }
    }
    public static class Debug
    {
        public static void Log(string text)
        {

        }
        public static void Log(object obj)
        {

        }
        public static void LogWarning(string text)
        {

        }
        public static void LogError(string text)
        {

        }
    }
    public static class Application
    {
        public static bool runInBackground;
    }
    public class GameObject
    {
        public T AddComponent<T>()
        {
            return default(T);
        }
        public void SetActive(bool state)
        {

        }
        public bool activeInHierarchy;
        public string name;
        public Transform transform;

        public GameObject()
        {

        }
        public GameObject(string name)
        {

        }
        public GameObject(string name, Type component)
        {

        }

        public T GetComponent<T>()
        {
            return default(T);
        }
        public T GetComponentInParent<T>()
        {
            return default(T);
        }
        public T[] GetComponentsInParent<T>()
        {
            return default(T[]);
        }
        public T GetComponentInChildren<T>()
        {
            return default(T);
        }
        public T[] GetComponentsInChildren<T>()
        {
            return default(T[]);
        }
        public T FindObjectOfType<T>()
        {
            return default(T);
        }
        public T[] FindObjectsOfType<T>()
        {
            return default(T[]);
        }
        public IEnumerator StartCoroutine(IEnumerator routine)
        {
            return routine;
        }
    }

    public class MonoBehaviour : Component
    {
        public GameObject gameObject;
        public Transform transform;
    }

    public class Transform : Component
    {
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public void SetParent(Transform parent)
        {

        }
    }

    public class Component
    {
        public bool enabled;
        public static void Destroy(Component c)
        {

        }
        public static void Destroy(GameObject go)
        {

        }
        public void DontDestroyOnLoad(GameObject go)
        {

        }
        public static GameObject Instantiate(GameObject prefab)
        {
            return new GameObject();
        }
        public static GameObject Instantiate(GameObject prefab, Vector3 pos, Quaternion rot)
        {
            return new GameObject();
        }

        public T GetComponent<T>()
        {
            return default(T);
        }
        public T GetComponentInParent<T>()
        {
            return default(T);
        }
        public T[] GetComponentsInParent<T>()
        {
            return default(T[]);
        }
        public T GetComponentInChildren<T>()
        {
            return default(T);
        }
        public T[] GetComponentsInChildren<T>()
        {
            return default(T[]);
        }
        public static T FindObjectOfType<T>()
        {
            return default(T);
        }
        public static T[] FindObjectsOfType<T>()
        {
            return default(T[]);
        }
        public IEnumerator StartCoroutine(IEnumerator routine)
        {
            return routine;
        }
    }

    public class Renderer : Component
    {

    }

    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector3 zero = new Vector3(0, 0, 0);
        public static bool operator ==(Vector3 o, Vector3 t)
        {
            return true;
        }
        public static bool operator !=(Vector3 o, Vector3 t)
        {
            return true;
        }
        public static Vector3 operator -(Vector3 o, Vector3 t)
        {
            return Vector3.zero;
        }
        public static float Distance(Vector3 o, Vector3 t)
        {
            return 0;
        }
        public static Vector3 Lerp(Vector3 o, Vector3 t, float tt)
        {
            return Vector3.zero;
        }
        public float magnitude
        {
            get
            {
                return 0;
            }
        }
    }

    public struct Quaternion
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public static Quaternion Slerp(Quaternion o, Quaternion t, float tt)
        {
            return Quaternion.identity;
        }
        public static Quaternion identity
        {
            get
            {
                return new Quaternion();
            }
        }
        public static float Angle(Quaternion o, Quaternion t)
        {
            return 0;
        }
        public static Quaternion Euler(Vector3 rot)
        {
            return Quaternion.identity;
        }
        public static Quaternion Euler(float x, float y, float z)
        {
            return Quaternion.identity;
        }
        public Vector3 eulerAngles
        {
            get
            {
                return Vector3.zero;
            }
        }
    }
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2 zero = new Vector2(0, 0);
    }
    public static class Time
    {
        public static float deltaTime => 0;
        public static float unscaledDeltaTime => 0;
        public static float time => 0;
        public static float unscaledTime => 0;
        public static int frameCount => 0;
    }
}
